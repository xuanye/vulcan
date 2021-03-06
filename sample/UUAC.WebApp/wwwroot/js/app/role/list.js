﻿(function (window, $, factory) {
    if (typeof define === 'function') {
        // 如果define已被定义，模块化代码
        define('app/role/list', function (require, exports, module) {
            module.exports = factory(window, $);
        });
    } else {
        // 如果define没有被定义，正常执行
        return factory(window, $);
    }
})(window, jQuery, function (window, $) {


    var opt = window.options;
 
    var tree = null, xjgrid =null;
    post(opt.getAppsUrl, {}, function (ret) {
        if(!ret ) {
            showError("错误提示", "获取数据错误，请稍后重试！");
            return false;
        }
        if(ret.status !==0 ) {
            showError("错误提示", "获取数据错误:"+ret.message);
            return false;
        }
        
        if(ret.data) {
            var treeData = parseTreeData(ret.data);
            tree = new xjTree("roleTree",
            {
                url: opt.loadTreeUrl,
                onnodeclick: navi,
                data: treeData
            });
            initGrid();
        }
    });

    function initGrid() {
        var maiheight = document.documentElement.clientHeight;
        //var mainWidth = document.documentElement.clientWidth - 2; // 减去边框和左边的宽度
        var otherpm = 120;
        var gh = maiheight - otherpm;
        var listOption = {
            height: gh,
            width: '100%',
            url: opt.listUrl,
            colModel: [
                { display: "角色标识", name: "RoleCode", width:130, sortable: false, align: "left", iskey: true },
                { display: "角色名称", name: "RoleName", sortable: false, align: "center" },
                { display: "系统角色", name: "IsSystemRole", sortable: false, align: "center", process: formatSR },
                { display: "备注", name: "Remark", sortable: false, align: "left" },
                { display: "操作", name: "RoleCode", width: 140, sortable: false, align: "left", dvCss: "hidden-sm hidden-xs action-buttons", process: formatOp, toggle: false }
            ],
            sortname: "sequence",
            sortorder: "asc",
            title: false,
            rp: 80,
            usepager: false,
            autoload:false,
            showcheckbox: true,
            extparams: []
        };
        xjgrid = new xjGrid("roleList", listOption);
    }
    function navi(item) {
        if(!xjgrid) {
            showError("错误警告", "列表未初始化，请刷新后重试");
            return;
        }
        if (item.classes === "AppICO") {
            xjgrid.QueryByFields([
                { "name": "pCode", "value": "" },
                { "name": "AppCode", "value":item.value }
            ]);
        }
        else {
            xjgrid.QueryByFields([
              { "name": "pCode", "value": item.id },
              { "name": "AppCode", "value": item.value }
            ]);
        }

      
    }
    function parseTreeData(data) {
        var root = [];
        for(var i=0,l=data.length;i<l ;i++) {
            var node = {
                id: data[i].appCode,
                text: data[i].appName,
                value: data[i].appCode,
                classes: "AppICO",
                complete: false,
                hasChildren:true
            };
            root.push(node);
        }
        return root;
    }

    //按钮事件
    $("#btnAdd").click(function (e) {
        var node = tree.GetCurrentItem();
        if (!!node) {
            var pcode ,pname;
            var appcode = node.value;
            if(node.id === node.value) {//选择了系统节点
                pcode = "";
                pname = "根节点";
            }
            else {
                pcode =node.id;
                pname = node.text;
            }
            var url = StrFormatNoEncode("{0}?pcode={1}&pname={2}&appcode={3}", [opt.editUrl, encodeURIComponent(pcode), encodeURIComponent(pname), appcode]);
            window.Choose.Open(url, {
                width: 480,
                height:450,
                caption: '新建权限',
                theme: "simple", //默认
                onclose: function (state) {
                    showSuccess("操作成功","操作成功",true);
                    xjgrid.Reload();
                } //窗口关闭时执行的回调函数  只有窗口通过函数主动关闭时才会触发。
            });
        }
        else { //根节点
            showError("错误信息","请先选中一个父组织");
        }
       
    });
    function formatSR(value) {
        if (value == 0) {
            return "否";
        }
        else {
            return "是";
        }
    }
    function formatOp(value,cell) {
        var ret = [];
        if (cell[2] == 0) {
            ret.push('<a class="green" href="javascript:window.options.Edit(\'', value, '\')"><i class="ace-icon fa fa-pencil bigger-130"></i></a>');
            ret.push('<a class="red" href="javascript:window.options.Remove(\'', value, '\')"><i class="ace-icon fa fa-trash-o bigger-130"></i></a>');
        }
        ret.push('<a class="orange" title="查看角色用户" href="javascript:window.options.ViewUsers(\'', value, '\')"><i class="ace-icon fa fa-users bigger-130"></i></a>');
        ret.push('<a class="blue" title="角色授权" href="javascript:window.options.Auth(\'', value, '\')"><i class="ace-icon fa fa-sitemap bigger-130"></i></a>');
        return ret.join("");

    }
    opt.Edit = function (Id) {
        
        var url = opt.editUrl + "/" + Id;
        window.Choose.Open(url, {
            width: 480,
            height: 450,
            caption: '修改角色信息',
            onclose: function () {
                xjgrid.Reload();
            }
        });
    };

    opt.ViewUsers = function (Id) {
        
        var url = opt.usersUrl + "/?roleCode=" + Id;
        window.Choose.Open(url, {
            width: 750,
            height: 650,
            caption: '查看角色用户'
        });
      };

    opt.Auth = function (Id) {

        var url = opt.authUrl + "/" + Id;
        window.Choose.Open(url, {
            width: 480,
            height: 520,
            caption: '角色授权'
        });
    };
    opt.Remove = function (Id) {
        if (!confirm("你确定要删除角色信息吗？")) {
            return false;
        }
        var url = opt.removeUrl + "/" + Id;
        post(url, null, function (ret) {
            if (ret && ret.status === 0) {
                showSuccess("操作成功", "删除成功", true);
                xjgrid.Reload();
            }
            else {
                showError("操作失败", ret ? ret.message : "删除失败，请刷新后重试", true);
            }
        });
    };
  
});