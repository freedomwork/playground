using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using VipSoft.Model;
namespace VipSoft.BLL
{
	/// <summary>
	/// MemCard
	/// </summary>
	public partial class MemCard
	{
		private readonly VipSoft.DAL.MemCard dal=new VipSoft.DAL.MemCard();
		public MemCard()
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
        /// 取得某等级的会员列表
        /// </summary>
        public string GetMemIDs(int levelID)
        {
            return dal.GetMemIDs(levelID);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(VipSoft.Model.MemCard model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(VipSoft.Model.MemCard model)
		{
			return dal.Update(model);
		}

        /// <summary>
        /// 更新会员等级
        /// </summary>
        public void UpdateLevel(int ID, int levelID)
        {
            dal.UpdateLevel(ID, levelID);
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
		public VipSoft.Model.MemCard GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public VipSoft.Model.MemCard GetModel(string CardID)
        {

            return dal.GetModel(CardID);
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

        public DataSet GetExportList(string strWhere)
        {
            return dal.GetExportList(strWhere);
        }

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<VipSoft.Model.MemCard> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<VipSoft.Model.MemCard> DataTableToList(DataTable dt)
		{
			List<VipSoft.Model.MemCard> modelList = new List<VipSoft.Model.MemCard>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				VipSoft.Model.MemCard model;
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
        /// <summary>
        /// 分页获得数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, out int resCount, params string[] strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, out resCount);
        }

        /// <summary>
        /// 按某字段排序得到前几条数据
        /// </summary>
        public DataSet GetList(int number, string sort, bool isAsc, string strWhere)
        {
            return dal.GetList(number, sort, isAsc, strWhere);
        }

        public Boolean importMemCard(DataTable dt)
        {
            return dal.importMemCard(dt);
        }


        public DataTable getTblModel()
        {
            return dal.getTblModel();
        }

        public DataTable getQuery(String sqlStr)
        {
            return dal.getQuery(sqlStr);
        }

        #endregion  ExtensionMethod
	}
}

