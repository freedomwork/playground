using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace VipSoft.DAL
{
	/// <summary>
	/// 数据访问类:OrderGoods
	/// </summary>
	public partial class OrderGoods
	{
		public OrderGoods()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "OrderGoods"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OrderGoods");
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
		public int Add(VipSoft.Model.OrderGoods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OrderGoods(");
            strSql.Append("GoodsID,GoodsCode,GoodsName,type,GoodsUnit,Price,Number,TotalMoney,MasterID,MasterName,ShopID,ShopName,CreateTime)");
			strSql.Append(" values (");
            strSql.Append("@GoodsID,@GoodsCode,@GoodsName,@type,@GoodsUnit,@Price,@Number,@TotalMoney,@MasterID,@MasterName,@ShopID,@ShopName,@CreateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GoodsID", SqlDbType.Int,4),
					new SqlParameter("@GoodsCode", SqlDbType.VarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.VarChar,50),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@GoodsUnit", SqlDbType.VarChar,20),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@TotalMoney", SqlDbType.Money,8),
					new SqlParameter("@MasterID", SqlDbType.Int,4),
					new SqlParameter("@MasterName", SqlDbType.VarChar,50),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime)
                                        };
			parameters[0].Value = model.GoodsID;
			parameters[1].Value = model.GoodsCode;
			parameters[2].Value = model.GoodsName;
			parameters[3].Value = model.type;
			parameters[4].Value = model.GoodsUnit;
			parameters[5].Value = model.Price;
			parameters[6].Value = model.Number;
			parameters[7].Value = model.TotalMoney;
			parameters[8].Value = model.MasterID;
			parameters[9].Value = model.MasterName;
			parameters[10].Value = model.ShopID;
			parameters[11].Value = model.ShopName;
            parameters[12].Value = model.CreateTime;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(VipSoft.Model.OrderGoods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OrderGoods set ");
			strSql.Append("GoodsID=@GoodsID,");
			strSql.Append("GoodsCode=@GoodsCode,");
			strSql.Append("GoodsName=@GoodsName,");
			strSql.Append("type=@type,");
			strSql.Append("GoodsUnit=@GoodsUnit,");
			strSql.Append("Price=@Price,");
			strSql.Append("Number=@Number,");
			strSql.Append("TotalMoney=@TotalMoney,");
			strSql.Append("MasterID=@MasterID,");
			strSql.Append("MasterName=@MasterName,");
			strSql.Append("ShopID=@ShopID,");
			strSql.Append("ShopName=@ShopName,");
            strSql.Append("CreateTime=@CreateTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@GoodsID", SqlDbType.Int,4),
					new SqlParameter("@GoodsCode", SqlDbType.VarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.VarChar,50),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@GoodsUnit", SqlDbType.VarChar,20),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@TotalMoney", SqlDbType.Money,8),
					new SqlParameter("@MasterID", SqlDbType.Int,4),
					new SqlParameter("@MasterName", SqlDbType.VarChar,50),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50),
                    new SqlParameter("@CreateTime",SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.GoodsID;
			parameters[1].Value = model.GoodsCode;
			parameters[2].Value = model.GoodsName;
			parameters[3].Value = model.type;
			parameters[4].Value = model.GoodsUnit;
			parameters[5].Value = model.Price;
			parameters[6].Value = model.Number;
			parameters[7].Value = model.TotalMoney;
			parameters[8].Value = model.MasterID;
			parameters[9].Value = model.MasterName;
			parameters[10].Value = model.ShopID;
			parameters[11].Value = model.ShopName;
            parameters[12].Value = model.CreateTime;
			parameters[13].Value = model.ID;

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
			strSql.Append("delete from OrderGoods ");
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
			strSql.Append("delete from OrderGoods ");
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
		public VipSoft.Model.OrderGoods GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,GoodsID,GoodsCode,GoodsName,type,GoodsUnit,Price,Number,TotalMoney,MasterID,MasterName,ShopID,ShopName,CreateTime from OrderGoods ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			VipSoft.Model.OrderGoods model=new VipSoft.Model.OrderGoods();
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
		public VipSoft.Model.OrderGoods DataRowToModel(DataRow row)
		{
			VipSoft.Model.OrderGoods model=new VipSoft.Model.OrderGoods();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["GoodsID"]!=null && row["GoodsID"].ToString()!="")
				{
					model.GoodsID=int.Parse(row["GoodsID"].ToString());
				}
				if(row["GoodsCode"]!=null)
				{
					model.GoodsCode=row["GoodsCode"].ToString();
				}
				if(row["GoodsName"]!=null)
				{
					model.GoodsName=row["GoodsName"].ToString();
				}
				if(row["type"]!=null && row["type"].ToString()!="")
				{
					model.type=int.Parse(row["type"].ToString());
				}
				if(row["GoodsUnit"]!=null)
				{
					model.GoodsUnit=row["GoodsUnit"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["Number"]!=null && row["Number"].ToString()!="")
				{
					model.Number=int.Parse(row["Number"].ToString());
				}
				if(row["TotalMoney"]!=null && row["TotalMoney"].ToString()!="")
				{
					model.TotalMoney=decimal.Parse(row["TotalMoney"].ToString());
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
				if(row["ShopName"]!=null)
				{
					model.ShopName=row["ShopName"].ToString();
				}
                if (row["CreateTime"] != null && row["CreateTime"].ToString() != "")
                {
                    model.CreateTime = DateTime.Parse(row["CreateTime"].ToString());
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
			strSql.Append("select ID,GoodsID,GoodsCode,GoodsName,type,GoodsUnit,Price,Number,TotalMoney,MasterID,MasterName,ShopID,ShopName,CreateTime ");
			strSql.Append(" FROM OrderGoods ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
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
            strSql.Append(" ID,GoodsID,GoodsCode,GoodsName,type,GoodsUnit,Price,Number,TotalMoney,MasterID,MasterName,ShopID,ShopName,CreateTime ");
			strSql.Append(" FROM OrderGoods ");
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
			strSql.Append("select count(1) FROM OrderGoods ");
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
			strSql.Append(")AS Row, T.*  from OrderGoods T ");
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
			parameters[0].Value = "OrderGoods";
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
        public DataSet GetListCollect(string sql)
        {
            return DbHelperSQL.Query(sql);
        }
		#endregion  ExtensionMethod
	}
}

