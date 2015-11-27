using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;
using System.Collections.Generic;//Please add references
namespace VipSoft.DAL
{
	/// <summary>
	/// 数据访问类:OrderLog
	/// </summary>
	public partial class OrderLog
	{
		public OrderLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "OrderLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OrderLog");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(VipSoft.Model.OrderLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OrderLog(");
			strSql.Append("OrderCode,OrderType,MemID,CardID,MemName,TotalNumber,TotalMoney,DisCountMoney,PayInfo,Point,CreateDateTime,PayType,MasterID,MasterName,ShopID,ShopName)");
			strSql.Append(" values (");
			strSql.Append("@OrderCode,@OrderType,@MemID,@CardID,@MemName,@TotalNumber,@TotalMoney,@DisCountMoney,@PayInfo,@Point,@CreateDateTime,@PayType,@MasterID,@MasterName,@ShopID,@ShopName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderCode", SqlDbType.NChar,10),
					new SqlParameter("@OrderType", SqlDbType.Int,4),
					new SqlParameter("@MemID", SqlDbType.Int,4),
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@MemName", SqlDbType.VarChar,20),
					new SqlParameter("@TotalNumber", SqlDbType.Int,4),
					new SqlParameter("@TotalMoney", SqlDbType.Money,8),
					new SqlParameter("@DisCountMoney", SqlDbType.Money,8),
					new SqlParameter("@PayInfo", SqlDbType.VarChar,50),
					new SqlParameter("@Point", SqlDbType.Int,4),
					new SqlParameter("@CreateDateTime", SqlDbType.DateTime),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@MasterID", SqlDbType.Int,4),
					new SqlParameter("@MasterName", SqlDbType.VarChar,50),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.OrderCode;
			parameters[1].Value = model.OrderType;
			parameters[2].Value = model.MemID;
			parameters[3].Value = model.CardID;
			parameters[4].Value = model.MemName;
			parameters[5].Value = model.TotalNumber;
			parameters[6].Value = model.TotalMoney;
			parameters[7].Value = model.DisCountMoney;
			parameters[8].Value = model.PayInfo;
			parameters[9].Value = model.Point;
			parameters[10].Value = model.CreateDateTime;
			parameters[11].Value = model.PayType;
			parameters[12].Value = model.MasterID;
			parameters[13].Value = model.MasterName;
			parameters[14].Value = model.ShopID;
			parameters[15].Value = model.ShopName;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
        /// <summary>
        /// 散客消费
        /// </summary>
        /// <param name="model"></param>
        /// <param name="listOrder"></param>
        /// <returns></returns>
        public bool Add(VipSoft.Model.OrderLog model, List<VipSoft.Model.OrderDetail> listOrder)
        {
            List<string> arr = new List<string>();
            string sq1 = "delete from OrderLog where OrderCode='" + model.OrderCode + "'";
            string sq2 = "delete from OrderDetail where OrderCode='" + model.OrderCode + "'";
            arr.Add(sq1);
            arr.Add(sq2);

            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into OrderLog(");
            strSql.Append("OrderCode,OrderType,MemID,CardID,MemName,TotalNumber,TotalMoney,DisCountMoney,PayInfo,Point,CreateDateTime,PayType,MasterID,MasterName,ShopID,ShopName)");
            strSql.Append(" values (");
            strSql.Append("@OrderCode,@OrderType,@MemID,@CardID,@MemName,@TotalNumber,@TotalMoney,@DisCountMoney,@PayInfo,@Point,@CreateDateTime,@PayType,@MasterID,@MasterName,@ShopID,@ShopName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderCode", SqlDbType.NChar,10),
					new SqlParameter("@OrderType", SqlDbType.Int,4),
					new SqlParameter("@MemID", SqlDbType.Int,4),
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@MemName", SqlDbType.VarChar,20),
					new SqlParameter("@TotalNumber", SqlDbType.Int,4),
					new SqlParameter("@TotalMoney", SqlDbType.Money,8),
					new SqlParameter("@DisCountMoney", SqlDbType.Money,8),
					new SqlParameter("@PayInfo", SqlDbType.VarChar,50),
					new SqlParameter("@Point", SqlDbType.Int,4),
					new SqlParameter("@CreateDateTime", SqlDbType.DateTime),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@MasterID", SqlDbType.Int,4),
					new SqlParameter("@MasterName", SqlDbType.VarChar,50),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50)};
            parameters[0].Value = model.OrderCode;
            parameters[1].Value = model.OrderType;
            parameters[2].Value = model.MemID;
            parameters[3].Value = model.CardID;
            parameters[4].Value = model.MemName;
            parameters[5].Value = model.TotalNumber;
            parameters[6].Value = model.TotalMoney;
            parameters[7].Value = model.DisCountMoney;
            parameters[8].Value = model.PayInfo;
            parameters[9].Value = model.Point;
            parameters[10].Value = model.CreateDateTime;
            parameters[11].Value = model.PayType;
            parameters[12].Value = model.MasterID;
            parameters[13].Value = model.MasterName;
            parameters[14].Value = model.ShopID;
            parameters[15].Value = model.ShopName;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return false;
            }
            else
            {
                // 添加订单详细，同时将产品数量减少
                foreach (VipSoft.Model.OrderDetail detail in listOrder)
                {
                    string sql = "insert into OrderDetail(OrderCode,GoodsID,GoodsCode,GoodsName,Price,DiscountPrice,[Number],Percent,IsService) " +
                        "values('{0}',{1},'{2}','{3}',{4},{5},{6},{7})";
                    sql = string.Format(sql, detail.OrderCode, detail.GoodsID, detail.GoodsCode, detail.GoodsName, detail.Price,  detail.DiscountPrice, detail.Number,detail.Percent,detail.IsService);
                    arr.Add(sql);

                    string sqlGoods = "update Goods set [Number]=[Number]-" + detail.Number + ",SaleNumber=SaleNumber+" + detail.Number + " where ID=" + detail.GoodsID;
                    if (detail.IsService)
                        sqlGoods = "update Goods set SaleNumber=SaleNumber+" + detail.Number + " where ID=" + detail.GoodsID;
                    arr.Add(sqlGoods);
                }

                return DbHelperSQL.ExecuteSqlTran(arr)>0;
            }
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(VipSoft.Model.OrderLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OrderLog set ");
			strSql.Append("OrderCode=@OrderCode,");
			strSql.Append("OrderType=@OrderType,");
			strSql.Append("MemID=@MemID,");
			strSql.Append("CardID=@CardID,");
			strSql.Append("MemName=@MemName,");
			strSql.Append("TotalNumber=@TotalNumber,");
			strSql.Append("TotalMoney=@TotalMoney,");
			strSql.Append("DisCountMoney=@DisCountMoney,");
			strSql.Append("PayInfo=@PayInfo,");
			strSql.Append("Point=@Point,");
			strSql.Append("CreateDateTime=@CreateDateTime,");
			strSql.Append("PayType=@PayType,");
			strSql.Append("MasterID=@MasterID,");
			strSql.Append("MasterName=@MasterName,");
			strSql.Append("ShopID=@ShopID,");
			strSql.Append("ShopName=@ShopName");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderCode", SqlDbType.NChar,10),
					new SqlParameter("@OrderType", SqlDbType.Int,4),
					new SqlParameter("@MemID", SqlDbType.Int,4),
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@MemName", SqlDbType.VarChar,20),
					new SqlParameter("@TotalNumber", SqlDbType.Int,4),
					new SqlParameter("@TotalMoney", SqlDbType.Money,8),
					new SqlParameter("@DisCountMoney", SqlDbType.Money,8),
					new SqlParameter("@PayInfo", SqlDbType.VarChar,50),
					new SqlParameter("@Point", SqlDbType.Int,4),
					new SqlParameter("@CreateDateTime", SqlDbType.DateTime),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@MasterID", SqlDbType.Int,4),
					new SqlParameter("@MasterName", SqlDbType.VarChar,50),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.OrderCode;
			parameters[1].Value = model.OrderType;
			parameters[2].Value = model.MemID;
			parameters[3].Value = model.CardID;
			parameters[4].Value = model.MemName;
			parameters[5].Value = model.TotalNumber;
			parameters[6].Value = model.TotalMoney;
			parameters[7].Value = model.DisCountMoney;
			parameters[8].Value = model.PayInfo;
			parameters[9].Value = model.Point;
			parameters[10].Value = model.CreateDateTime;
			parameters[11].Value = model.PayType;
			parameters[12].Value = model.MasterID;
			parameters[13].Value = model.MasterName;
			parameters[14].Value = model.ShopID;
			parameters[15].Value = model.ShopName;
			parameters[16].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OrderLog ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OrderLog ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public VipSoft.Model.OrderLog GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,OrderCode,OrderType,MemID,CardID,MemName,TotalNumber,TotalMoney,DisCountMoney,PayInfo,Point,CreateDateTime,PayType,MasterID,MasterName,ShopID,ShopName from OrderLog ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			VipSoft.Model.OrderLog model=new VipSoft.Model.OrderLog();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public VipSoft.Model.OrderLog DataRowToModel(DataRow row)
		{
			VipSoft.Model.OrderLog model=new VipSoft.Model.OrderLog();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["OrderCode"]!=null)
				{
					model.OrderCode=row["OrderCode"].ToString();
				}
				if(row["OrderType"]!=null && row["OrderType"].ToString()!="")
				{
					model.OrderType=int.Parse(row["OrderType"].ToString());
				}
				if(row["MemID"]!=null && row["MemID"].ToString()!="")
				{
					model.MemID=int.Parse(row["MemID"].ToString());
				}
				if(row["CardID"]!=null)
				{
					model.CardID=row["CardID"].ToString();
				}
				if(row["MemName"]!=null)
				{
					model.MemName=row["MemName"].ToString();
				}
				if(row["TotalNumber"]!=null && row["TotalNumber"].ToString()!="")
				{
					model.TotalNumber=int.Parse(row["TotalNumber"].ToString());
				}
				if(row["TotalMoney"]!=null && row["TotalMoney"].ToString()!="")
				{
					model.TotalMoney=decimal.Parse(row["TotalMoney"].ToString());
				}
				if(row["DisCountMoney"]!=null && row["DisCountMoney"].ToString()!="")
				{
					model.DisCountMoney=decimal.Parse(row["DisCountMoney"].ToString());
				}
				if(row["PayInfo"]!=null)
				{
					model.PayInfo=row["PayInfo"].ToString();
				}
				if(row["Point"]!=null && row["Point"].ToString()!="")
				{
					model.Point=int.Parse(row["Point"].ToString());
				}
				if(row["CreateDateTime"]!=null && row["CreateDateTime"].ToString()!="")
				{
					model.CreateDateTime=DateTime.Parse(row["CreateDateTime"].ToString());
				}
				if(row["PayType"]!=null && row["PayType"].ToString()!="")
				{
					model.PayType=int.Parse(row["PayType"].ToString());
				}
				if(row["MasterID"]!=null && row["MasterID"].ToString()!="")
				{
					model.MasterID=int.Parse(row["MasterID"].ToString());
				}
				if(row["MasterName"]!=null)
				{
					model.MasterName=row["MasterName"].ToString();
				}
				if(row["ShopID"]!=null && row["ShopID"].ToString()!="")
				{
					model.ShopID=int.Parse(row["ShopID"].ToString());
				}
				if(row["ShopName"]!=null && row["ShopName"].ToString()!="")
				{
					model.ShopName=row["ShopName"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,OrderCode,OrderType,MemID,CardID,MemName,TotalNumber,TotalMoney,DisCountMoney,PayInfo,Point,CreateDateTime,PayType,MasterID,MasterName,ShopID,ShopName ");
			strSql.Append(" FROM OrderLog ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// 普通消费数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetOrderGoodsList(string strWhere)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select OrderLog.ID,OrderLog.OrderCode,OrderLog.OrderType,OrderLog.MemID,OrderLog.CardID,OrderLog.MemName,OrderLog.TotalNumber,OrderLog.TotalMoney,OrderLog.DiscountMoney,OrderLog.Point,OrderLog.CreateDateTime,OrderLog.MasterID,OrderLog.MasterName,OrderLog.PayType,OrderLog.PayInfo,OrderLog.Remark,OrderLog.PayInfo,MemCard.ID,MemCard.CardmianID,MemCard.ID,MemCard.Mobile");
            sb.Append(" FROM OrderLog INNER JOIN MemCard on OrderLog.MemID=MemCard.ID ");
            if (strWhere.Trim() != "")
                sb.Append(" where " + strWhere);
            sb.Append(" Order By OrderLog.ID desc");
            return DbHelperSQL.Query(sb.ToString());
        }

        /// <summary>
        /// 快速消费数据报表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetOrderPointList(string strWhere)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select OrderLog.ID,OrderLog.OrderCode,OrderLog.OrderType,OrderLog.MemID,OrderLog.CardID,OrderLog.MemName,OrderLog.TotalNumber,OrderLog.TotalMoney,OrderLog.DiscountMoney,OrderLog.Point,OrderLog.CreateDateTime,OrderLog.MasterID,OrderLog.MasterName,OrderLog.PayType,OrderLog.PayInfo,OrderLog.Remark,MemCard.ID,MemCard.CardmianID,MemCard.Mobile");
            sb.Append(" FROM OrderLog INNER JOIN MemCard on OrderLog.MemID=MemCard.ID ");
            if (strWhere.Trim() != "")
                sb.Append(" where " + strWhere);
            sb.Append(" Order By OrderLog.ID desc");
            return DbHelperSQL.Query(sb.ToString());
        }

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,OrderCode,OrderType,MemID,CardID,MemName,TotalNumber,TotalMoney,DisCountMoney,PayInfo,Point,CreateDateTime,PayType,MasterID,MasterName,ShopID,ShopName ");
			strSql.Append(" FROM OrderLog ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM OrderLog ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from OrderLog T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "OrderLog";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string[] strWhere, out int resCount)
        {
            string tableName = "OrderLog";
            string[] columns = { "ID,OrderCode,OrderType,MemID,CardID,MemName,TotalNumber,TotalMoney,DisCountMoney,PayInfo,Point,CreateDateTime,PayType,MasterID,MasterName,ShopID,ShopName" };
            string[] condition = strWhere;
            int recordCount = 1;
            DataSet ds = DbHelperSQL.GetTable(tableName, columns, condition, "ID", false, PageSize, PageIndex, recordCount);
            resCount = int.Parse(ds.Tables[1].Rows[0][0].ToString());
            return ds;
        }

        public DataSet GetListCollect(string sql)
        {
            return DbHelperSQL.Query(sql);
        }
		#endregion  ExtensionMethod
	}
}

