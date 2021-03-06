﻿
//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by template for T4.
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

using Vulcan.DataAccess.ORMapping;

namespace UUAC.DataAccess.Mysql.Entitis
{

	[TableName("api_auth")]
	public partial class ApiAuth : UUAC.DataAccess.Mysql.Enities.BaseEntity
	{
		private int _Idx;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>
		[MapField("idx"), Identity, PrimaryKey(1)] 
		public int Idx
		{ get{ return _Idx; } 	set{ _Idx = value ; } }
		private string _AppCode;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*系统标识*/
		///  varchar(50)
		/// </summary>
		[MapField("app_code")    ] 
		public string AppCode
		{ get{ return _AppCode; } 	set{ _AppCode = value ;  OnPropertyChanged("app_code"); } }
		private string _ApiCode;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*客户端访问ID*/
		///  varchar(50)
		/// </summary>
		[MapField("api_code")    ] 
		public string ApiCode
		{ get{ return _ApiCode; } 	set{ _ApiCode = value ;  OnPropertyChanged("api_code"); } }
		private string _SecretKey;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*密钥*/
		///  varchar(50)
		/// </summary>
		[MapField("secret_key")    ] 
		public string SecretKey
		{ get{ return _SecretKey; } 	set{ _SecretKey = value ;  OnPropertyChanged("secret_key"); } }
		private string _ClientName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*客户端名称--调用方系统名*/
		///  varchar(50)
		/// </summary>
		[MapField("client_name")    ] 
		public string ClientName
		{ get{ return _ClientName; } 	set{ _ClientName = value ;  OnPropertyChanged("client_name"); } }
		private string _LinkUser;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*对方联系人*/
		///  varchar(50)
		/// </summary>
		[MapField("link_user")    ] 
		public string LinkUser
		{ get{ return _LinkUser; } 	set{ _LinkUser = value ;  OnPropertyChanged("link_user"); } }
		private string _AllowIps;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*允许访问的IP列表，用逗号分隔*/
		///  varchar(2000)
		/// </summary>
		[MapField("allow_ips"), Nullable  ] 
		public string AllowIps
		{ get{ return _AllowIps; } 	set{ _AllowIps = value ;  OnPropertyChanged("allow_ips"); } }
		private sbyte? _Status;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*状态  0  = 无效  1= 有效*/
		///  tinyint(3)
		/// </summary>
		[MapField("status"), Nullable  ] 
		public sbyte? Status
		{ get{ return _Status; } 	set{ _Status = value ;  OnPropertyChanged("status"); } }
		private sbyte _Channel;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*渠道-扩展字段 */
		///  tinyint(3)
		/// </summary>
		[MapField("channel")    ] 
		public sbyte Channel
		{ get{ return _Channel; } 	set{ _Channel = value ;  OnPropertyChanged("channel"); } }
		private string _LastModifyUserId;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人账号*/
		///  varchar(50)
		/// </summary>
		[MapField("last_modify_user_id")    ] 
		public string LastModifyUserId
		{ get{ return _LastModifyUserId; } 	set{ _LastModifyUserId = value ;  OnPropertyChanged("last_modify_user_id"); } }
		private string _LastModifyUserName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人名称*/
		///  varchar(200)
		/// </summary>
		[MapField("last_modify_user_name")    ] 
		public string LastModifyUserName
		{ get{ return _LastModifyUserName; } 	set{ _LastModifyUserName = value ;  OnPropertyChanged("last_modify_user_name"); } }
		private DateTime _LastModifyTime;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新时间*/
		///  datetime
		/// </summary>
		[MapField("last_modify_time")    ] 
		public DateTime LastModifyTime
		{ get{ return _LastModifyTime; } 	set{ _LastModifyTime = value ;  OnPropertyChanged("last_modify_time"); } }
	}

	[TableName("app_info")]
	public partial class AppInfo : UUAC.DataAccess.Mysql.Enities.BaseEntity
	{
		private string _AppCode;
		/// <summary>
		/// 
		///  varchar(50)
		/// </summary>
		[MapField("app_code"),   PrimaryKey(1)] 
		public string AppCode
		{ get{ return _AppCode; } 	set{ _AppCode = value ;  OnPropertyChanged("app_code"); } }
		private string _AppName;
		/// <summary>
		/// 
		///  varchar(200)
		/// </summary>
		[MapField("app_name")    ] 
		public string AppName
		{ get{ return _AppName; } 	set{ _AppName = value ;  OnPropertyChanged("app_name"); } }
		private string _Description;
		/// <summary>
		/// 
		///  varchar(2000)
		/// </summary>
		[MapField("description"), Nullable  ] 
		public string Description
		{ get{ return _Description; } 	set{ _Description = value ;  OnPropertyChanged("description"); } }
		private string _LastModifyUserId;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人账号*/
		///  varchar(50)
		/// </summary>
		[MapField("last_modify_user_id")    ] 
		public string LastModifyUserId
		{ get{ return _LastModifyUserId; } 	set{ _LastModifyUserId = value ;  OnPropertyChanged("last_modify_user_id"); } }
		private string _LastModifyUserName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人名称*/
		///  varchar(200)
		/// </summary>
		[MapField("last_modify_user_name")    ] 
		public string LastModifyUserName
		{ get{ return _LastModifyUserName; } 	set{ _LastModifyUserName = value ;  OnPropertyChanged("last_modify_user_name"); } }
		private DateTime _LastModifyTime;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新事件*/
		///  datetime
		/// </summary>
		[MapField("last_modify_time")    ] 
		public DateTime LastModifyTime
		{ get{ return _LastModifyTime; } 	set{ _LastModifyTime = value ;  OnPropertyChanged("last_modify_time"); } }
	}

	[TableName("organization")]
	public partial class Organization : UUAC.DataAccess.Mysql.Enities.BaseEntity
	{
		private string _OrgCode;
		/// <summary>
		/// 
		///  varchar(50)
		/// </summary>
		[MapField("org_code"),   PrimaryKey(1)] 
		public string OrgCode
		{ get{ return _OrgCode; } 	set{ _OrgCode = value ;  OnPropertyChanged("org_code"); } }
		private string _OrgName;
		/// <summary>
		/// 
		///  varchar(200)
		/// </summary>
		[MapField("org_name")    ] 
		public string OrgName
		{ get{ return _OrgName; } 	set{ _OrgName = value ;  OnPropertyChanged("org_name"); } }
		private string _ParentCode;
		/// <summary>
		/// 
		///  varchar(50)
		/// </summary>
		[MapField("parent_code"), Nullable  ] 
		public string ParentCode
		{ get{ return _ParentCode; } 	set{ _ParentCode = value ;  OnPropertyChanged("parent_code"); } }
		private string _Remark;
		/// <summary>
		/// 
		///  varchar(500)
		/// </summary>
		[MapField("remark"), Nullable  ] 
		public string Remark
		{ get{ return _Remark; } 	set{ _Remark = value ;  OnPropertyChanged("remark"); } }
		private int _Sequence;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>
		[MapField("sequence")    ] 
		public int Sequence
		{ get{ return _Sequence; } 	set{ _Sequence = value ;  OnPropertyChanged("sequence"); } }
		private sbyte _OrgType;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*组织类型 ： 0 组  1 部门  2 中心  3 公司*/
		///  tinyint(3)
		/// </summary>
		[MapField("org_type")    ] 
		public sbyte OrgType
		{ get{ return _OrgType; } 	set{ _OrgType = value ;  OnPropertyChanged("org_type"); } }
		private string _UnitCode;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*所属中心*/
		///  varchar(50)
		/// </summary>
		[MapField("unit_code"), Nullable  ] 
		public string UnitCode
		{ get{ return _UnitCode; } 	set{ _UnitCode = value ;  OnPropertyChanged("unit_code"); } }
		private string _UnitName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*所属中心名称*/
		///  varchar(200)
		/// </summary>
		[MapField("unit_name"), Nullable  ] 
		public string UnitName
		{ get{ return _UnitName; } 	set{ _UnitName = value ;  OnPropertyChanged("unit_name"); } }
		private string _LastModifyUserId;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人账号*/
		///  varchar(50)
		/// </summary>
		[MapField("last_modify_user_id")    ] 
		public string LastModifyUserId
		{ get{ return _LastModifyUserId; } 	set{ _LastModifyUserId = value ;  OnPropertyChanged("last_modify_user_id"); } }
		private string _LastModifyUserName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人名称*/
		///  varchar(200)
		/// </summary>
		[MapField("last_modify_user_name")    ] 
		public string LastModifyUserName
		{ get{ return _LastModifyUserName; } 	set{ _LastModifyUserName = value ;  OnPropertyChanged("last_modify_user_name"); } }
		private DateTime _LastModifyTime;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新事件*/
		///  datetime
		/// </summary>
		[MapField("last_modify_time")    ] 
		public DateTime LastModifyTime
		{ get{ return _LastModifyTime; } 	set{ _LastModifyTime = value ;  OnPropertyChanged("last_modify_time"); } }
		private int _Left;
		/// <summary>
		/// 左侧节点-标示
		///  int(10)
		/// </summary>
		[MapField("left")    ] 
		public int Left
		{ get{ return _Left; } 	set{ _Left = value ;  OnPropertyChanged("left"); } }
		private int _Right;
		/// <summary>
		/// 右侧节点标识
		///  int(10)
		/// </summary>
		[MapField("right")    ] 
		public int Right
		{ get{ return _Right; } 	set{ _Right = value ;  OnPropertyChanged("right"); } }
	}

	[TableName("privilege")]
	public partial class Privilege : UUAC.DataAccess.Mysql.Enities.BaseEntity
	{
		private string _PrivilegeCode;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*权限标识*/
		///  varchar(100)
		/// </summary>
		[MapField("privilege_code"),   PrimaryKey(1)] 
		public string PrivilegeCode
		{ get{ return _PrivilegeCode; } 	set{ _PrivilegeCode = value ;  OnPropertyChanged("privilege_code"); } }
		private string _PrivilegeName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*权限名称*/
		///  varchar(200)
		/// </summary>
		[MapField("privilege_name")    ] 
		public string PrivilegeName
		{ get{ return _PrivilegeName; } 	set{ _PrivilegeName = value ;  OnPropertyChanged("privilege_name"); } }
		private sbyte _PrivilegeType;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*权限类型： 0 菜单权限  1 一般权限*/
		///  tinyint(3)
		/// </summary>
		[MapField("privilege_type")    ] 
		public sbyte PrivilegeType
		{ get{ return _PrivilegeType; } 	set{ _PrivilegeType = value ;  OnPropertyChanged("privilege_type"); } }
		private string _Remark;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*备注*/
		///  varchar(500)
		/// </summary>
		[MapField("remark"), Nullable  ] 
		public string Remark
		{ get{ return _Remark; } 	set{ _Remark = value ;  OnPropertyChanged("remark"); } }
		private string _ParentCode;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*父权限标识*/
		///  varchar(100)
		/// </summary>
		[MapField("parent_code"), Nullable  ] 
		public string ParentCode
		{ get{ return _ParentCode; } 	set{ _ParentCode = value ;  OnPropertyChanged("parent_code"); } }
		private string _Resource;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*资源  一般为URL*/
		///  varchar(2000)
		/// </summary>
		[MapField("resource"), Nullable  ] 
		public string Resource
		{ get{ return _Resource; } 	set{ _Resource = value ;  OnPropertyChanged("resource"); } }
		private int _Sequence;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*排序*/
		///  int(10)
		/// </summary>
		[MapField("sequence")    ] 
		public int Sequence
		{ get{ return _Sequence; } 	set{ _Sequence = value ;  OnPropertyChanged("sequence"); } }
		private string _AppCode;
		/// <summary>
		/// 
		///  varchar(50)
		/// </summary>
		[MapField("app_code"),   PrimaryKey(2)] 
		public string AppCode
		{ get{ return _AppCode; } 	set{ _AppCode = value ;  OnPropertyChanged("app_code"); } }
		private string _LastModifyUserId;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人账号*/
		///  varchar(50)
		/// </summary>
		[MapField("last_modify_user_id")    ] 
		public string LastModifyUserId
		{ get{ return _LastModifyUserId; } 	set{ _LastModifyUserId = value ;  OnPropertyChanged("last_modify_user_id"); } }
		private string _LastModifyUserName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人名称*/
		///  varchar(200)
		/// </summary>
		[MapField("last_modify_user_name")    ] 
		public string LastModifyUserName
		{ get{ return _LastModifyUserName; } 	set{ _LastModifyUserName = value ;  OnPropertyChanged("last_modify_user_name"); } }
		private DateTime _LastModifyTime;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新事件*/
		///  datetime
		/// </summary>
		[MapField("last_modify_time")    ] 
		public DateTime LastModifyTime
		{ get{ return _LastModifyTime; } 	set{ _LastModifyTime = value ;  OnPropertyChanged("last_modify_time"); } }
		private string _Mark;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*标识-一般用于菜单图标什么*/
		///  varchar(100)
		/// </summary>
		[MapField("mark"), Nullable  ] 
		public string Mark
		{ get{ return _Mark; } 	set{ _Mark = value ;  OnPropertyChanged("mark"); } }
	}

	[TableName("role_info")]
	public partial class RoleInfo : UUAC.DataAccess.Mysql.Enities.BaseEntity
	{
		private string _RoleCode;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*角色代码*/
		///  varchar(100)
		/// </summary>
		[MapField("role_code"),   PrimaryKey(1)] 
		public string RoleCode
		{ get{ return _RoleCode; } 	set{ _RoleCode = value ;  OnPropertyChanged("role_code"); } }
		private string _RoleName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*角色名称*/
		///  varchar(200)
		/// </summary>
		[MapField("role_name")    ] 
		public string RoleName
		{ get{ return _RoleName; } 	set{ _RoleName = value ;  OnPropertyChanged("role_name"); } }
		private string _ParentCode;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*父角色代码*/
		///  varchar(100)
		/// </summary>
		[MapField("parent_code"), Nullable  ] 
		public string ParentCode
		{ get{ return _ParentCode; } 	set{ _ParentCode = value ;  OnPropertyChanged("parent_code"); } }
		private sbyte _IsSystemRole;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*是否系统角色*/
		///  tinyint(3)
		/// </summary>
		[MapField("is_system_role")    ] 
		public sbyte IsSystemRole
		{ get{ return _IsSystemRole; } 	set{ _IsSystemRole = value ;  OnPropertyChanged("is_system_role"); } }
		private string _Remark;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*备注*/
		///  varchar(500)
		/// </summary>
		[MapField("remark"), Nullable  ] 
		public string Remark
		{ get{ return _Remark; } 	set{ _Remark = value ;  OnPropertyChanged("remark"); } }
		private string _AppCode;
		/// <summary>
		/// 
		///  varchar(50)
		/// </summary>
		[MapField("app_code"),   PrimaryKey(2)] 
		public string AppCode
		{ get{ return _AppCode; } 	set{ _AppCode = value ;  OnPropertyChanged("app_code"); } }
		private string _LastModifyUserId;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人账号*/
		///  varchar(50)
		/// </summary>
		[MapField("last_modify_user_id")    ] 
		public string LastModifyUserId
		{ get{ return _LastModifyUserId; } 	set{ _LastModifyUserId = value ;  OnPropertyChanged("last_modify_user_id"); } }
		private string _LastModifyUserName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人名称*/
		///  varchar(200)
		/// </summary>
		[MapField("last_modify_user_name")    ] 
		public string LastModifyUserName
		{ get{ return _LastModifyUserName; } 	set{ _LastModifyUserName = value ;  OnPropertyChanged("last_modify_user_name"); } }
		private DateTime _LastModifyTime;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新事件*/
		///  datetime
		/// </summary>
		[MapField("last_modify_time")    ] 
		public DateTime LastModifyTime
		{ get{ return _LastModifyTime; } 	set{ _LastModifyTime = value ;  OnPropertyChanged("last_modify_time"); } }
		private int _Left;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>
		[MapField("left")    ] 
		public int Left
		{ get{ return _Left; } 	set{ _Left = value ;  OnPropertyChanged("left"); } }
		private int _Right;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>
		[MapField("right")    ] 
		public int Right
		{ get{ return _Right; } 	set{ _Right = value ;  OnPropertyChanged("right"); } }
	}

	[TableName("role_privilege_relation")]
	public partial class RolePrivilegeRelation : UUAC.DataAccess.Mysql.Enities.BaseEntity
	{
		private string _PrivilegeCode;
		/// <summary>
		/// 
		///  varchar(100)
		/// </summary>
		[MapField("privilege_code"), PrimaryKey(1)] 
		public string PrivilegeCode
		{ get{ return _PrivilegeCode; } 	set{ _PrivilegeCode = value ;  OnPropertyChanged("privilege_code"); } }
		private string _RoleCode;
		/// <summary>
		/// 
		///  varchar(100)
		/// </summary>
		[MapField("role_code"), PrimaryKey(2)] 
		public string RoleCode
		{ get{ return _RoleCode; } 	set{ _RoleCode = value ;  OnPropertyChanged("role_code"); } }
	}

	[TableName("role_user_relation")]
	public partial class RoleUserRelation : UUAC.DataAccess.Mysql.Enities.BaseEntity
	{
		private string _RoleCode;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*角色账号*/
		///  varchar(100)
		/// </summary>
		[MapField("role_code"), PrimaryKey(1)] 
		public string RoleCode
		{ get{ return _RoleCode; } 	set{ _RoleCode = value ;  OnPropertyChanged("role_code"); } }
		private string _UserUid;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*用户账号*/
		///  varchar(50)
		/// </summary>
		[MapField("user_uid"), PrimaryKey(2)] 
		public string UserUid
		{ get{ return _UserUid; } 	set{ _UserUid = value ;  OnPropertyChanged("user_uid"); } }
	}

	[TableName("user_info")]
	public partial class UserInfo : UUAC.DataAccess.Mysql.Enities.BaseEntity
	{
		private string _UserUid;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*用户账号唯一标识*/
		///  varchar(50)
		/// </summary>
		[MapField("user_uid"),   PrimaryKey(1)] 
		public string UserUid
		{ get{ return _UserUid; } 	set{ _UserUid = value ;  OnPropertyChanged("user_uid"); } }
		private string _FullName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*用户姓名*/
		///  varchar(200)
		/// </summary>
		[MapField("full_name")    ] 
		public string FullName
		{ get{ return _FullName; } 	set{ _FullName = value ;  OnPropertyChanged("full_name"); } }
		private string _Password;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*密码*/
		///  varchar(200)
		/// </summary>
		[MapField("password"), Nullable  ] 
		public string Password
		{ get{ return _Password; } 	set{ _Password = value ;  OnPropertyChanged("password"); } }
		private sbyte _AccountType;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*账号类型 ：0 自建OR外部  1 内部员工  9 系统*/
		///  tinyint(3)
		/// </summary>
		[MapField("account_type")    ] 
		public sbyte AccountType
		{ get{ return _AccountType; } 	set{ _AccountType = value ;  OnPropertyChanged("account_type"); } }
		private string _OrgCode;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*所属结构代码*/
		///  varchar(50)
		/// </summary>
		[MapField("org_code")    ] 
		public string OrgCode
		{ get{ return _OrgCode; } 	set{ _OrgCode = value ;  OnPropertyChanged("org_code"); } }
		private string _OrgName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*所属机构名称*/
		///  varchar(200)
		/// </summary>
		[MapField("org_name")    ] 
		public string OrgName
		{ get{ return _OrgName; } 	set{ _OrgName = value ;  OnPropertyChanged("org_name"); } }
		private int _Sequence;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*排序号*/
		///  int(10)
		/// </summary>
		[MapField("sequence")    ] 
		public int Sequence
		{ get{ return _Sequence; } 	set{ _Sequence = value ;  OnPropertyChanged("sequence"); } }
		private sbyte _Status;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*账号状态： 0 正常 1 停用*/
		///  tinyint(3)
		/// </summary>
		[MapField("status")    ] 
		public sbyte Status
		{ get{ return _Status; } 	set{ _Status = value ;  OnPropertyChanged("status"); } }
		private string _LastModifyUserId;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人账号*/
		///  varchar(50)
		/// </summary>
		[MapField("last_modify_user_id")    ] 
		public string LastModifyUserId
		{ get{ return _LastModifyUserId; } 	set{ _LastModifyUserId = value ;  OnPropertyChanged("last_modify_user_id"); } }
		private string _LastModifyUserName;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新人名称*/
		///  varchar(200)
		/// </summary>
		[MapField("last_modify_user_name")    ] 
		public string LastModifyUserName
		{ get{ return _LastModifyUserName; } 	set{ _LastModifyUserName = value ;  OnPropertyChanged("last_modify_user_name"); } }
		private DateTime _LastModifyTime;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*最后一次更新事件*/
		///  datetime
		/// </summary>
		[MapField("last_modify_time")    ] 
		public DateTime LastModifyTime
		{ get{ return _LastModifyTime; } 	set{ _LastModifyTime = value ;  OnPropertyChanged("last_modify_time"); } }
		private string _UserNum;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*工号*/
		///  varchar(50)
		/// </summary>
		[MapField("user_num"), Nullable  ] 
		public string UserNum
		{ get{ return _UserNum; } 	set{ _UserNum = value ;  OnPropertyChanged("user_num"); } }
		private sbyte? _Gender;
		/// <summary>
		///  /* COMMENT TRUNCATED */ /*1：男，0：女*/
		///  tinyint(3)
		/// </summary>
		[MapField("gender"), Nullable  ] 
		public sbyte? Gender
		{ get{ return _Gender; } 	set{ _Gender = value ;  OnPropertyChanged("gender"); } }
		private string _ViewRootCode;
		/// <summary>
		/// 用户可见组织范围-最高层组织编码
		///  varchar(50)
		/// </summary>
		[MapField("view_root_code"), Nullable  ] 
		public string ViewRootCode
		{ get{ return _ViewRootCode; } 	set{ _ViewRootCode = value ;  OnPropertyChanged("view_root_code"); } }
		private string _ViewRootName;
		/// <summary>
		/// 用户可见组织范围-最高层组织名称
		///  varchar(200)
		/// </summary>
		[MapField("view_root_name"), Nullable  ] 
		public string ViewRootName
		{ get{ return _ViewRootName; } 	set{ _ViewRootName = value ;  OnPropertyChanged("view_root_name"); } }
	}
}
