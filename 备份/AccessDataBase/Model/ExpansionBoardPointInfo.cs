﻿/**  版本信息模板在安装目录下，可自行修改。
* ExpansionBoardPointInfo.cs
*
* 功 能： N/A
* 类 名： ExpansionBoardPointInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-18 16:33:07   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace KryptonAccessController.AccessDataBase.Model
{
	/// <summary>
	/// ExpansionBoardPointInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ExpansionBoardPointInfo
	{
		public ExpansionBoardPointInfo()
		{}
		#region Model
		private int _expansionboardpointid;
		private string _inputname="Input1";
		private int _pointtype;
		private int _pointid;
		private int? _pointstate;
		private int? _expansionboardid;
		/// <summary>
		/// 
		/// </summary>
		public int ExpansionBoardPointID
		{
			set{ _expansionboardpointid=value;}
			get{return _expansionboardpointid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InputName
		{
			set{ _inputname=value;}
			get{return _inputname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PointType
		{
			set{ _pointtype=value;}
			get{return _pointtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PointID
		{
			set{ _pointid=value;}
			get{return _pointid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PointState
		{
			set{ _pointstate=value;}
			get{return _pointstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpansionBoardID
		{
			set{ _expansionboardid=value;}
			get{return _expansionboardid;}
		}
		#endregion Model

	}
}

