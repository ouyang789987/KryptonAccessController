﻿/**  版本信息模板在安装目录下，可自行修改。
* InteractHoliday.cs
*
* 功 能： N/A
* 类 名： InteractHoliday
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:15   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace KryptonAccessController.AccessSdkDataBase.Model
{
	/// <summary>
	/// InteractHoliday:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InteractHoliday
	{
		public InteractHoliday()
		{}
		#region Model
		private int _interactholidayid;
		private string _interactholidayname;
		private string _interactholidaydate;
		private int? _interactholidaytype=1;
		/// <summary>
		/// 
		/// </summary>
		public int InteractHolidayID
		{
			set{ _interactholidayid=value;}
			get{return _interactholidayid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InteractHolidayName
		{
			set{ _interactholidayname=value;}
			get{return _interactholidayname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InteractHolidayDate
		{
			set{ _interactholidaydate=value;}
			get{return _interactholidaydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InteractHolidayType
		{
			set{ _interactholidaytype=value;}
			get{return _interactholidaytype;}
		}
		#endregion Model

	}
}

