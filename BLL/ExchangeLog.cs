﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using VipSoft.Model;
namespace VipSoft.BLL
{
	/// <summary>
	/// ExchangeLog
	/// </summary>
	public partial class ExchangeLog
	{
		private readonly VipSoft.DAL.ExchangeLog dal=new VipSoft.DAL.ExchangeLog();
		public ExchangeLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(VipSoft.Model.ExchangeLog model)
		{
			return dal.Add(model);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(List<VipSoft.Model.ExchangeLog> exchangList)
        {
            return dal.Add(exchangList);
        }

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(VipSoft.Model.ExchangeLog model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public VipSoft.Model.ExchangeLog GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}

        /// <summary>
        /// 获得报表统计所需数据
        /// </summary>
        public DataSet GetReportList(string condition)
        {
            return dal.GetReportList(condition);
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<VipSoft.Model.ExchangeLog> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<VipSoft.Model.ExchangeLog> DataTableToList(DataTable dt)
		{
			List<VipSoft.Model.ExchangeLog> modelList = new List<VipSoft.Model.ExchangeLog>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				VipSoft.Model.ExchangeLog model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

