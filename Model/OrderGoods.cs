using System;
namespace VipSoft.Model
{
	/// <summary>
	/// OrderGoods:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderGoods
	{
		public OrderGoods()
		{}
		#region Model
		private int _id;
		private int? _goodsid;
		private string _goodscode;
		private string _goodsname;
		private int? _type;
		private string _goodsunit;
		private decimal? _price;
		private int? _number;
		private decimal? _totalmoney;
        private DateTime _createtime;
		private int? _masterid;
		private string _mastername;
		private int? _shopid;
		private string _shopname;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GoodsID
		{
			set{ _goodsid=value;}
			get{return _goodsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoodsCode
		{
			set{ _goodscode=value;}
			get{return _goodscode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoodsName
		{
			set{ _goodsname=value;}
			get{return _goodsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoodsUnit
		{
			set{ _goodsunit=value;}
			get{return _goodsunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalMoney
		{
			set{ _totalmoney=value;}
			get{return _totalmoney;}
		}
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            get { return _createtime; }
            set { _createtime = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int? MasterID
		{
			set{ _masterid=value;}
			get{return _masterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MasterName
		{
			set{ _mastername=value;}
			get{return _mastername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ShopID
		{
			set{ _shopid=value;}
			get{return _shopid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShopName
		{
			set{ _shopname=value;}
			get{return _shopname;}
		}
		#endregion Model

	}
}

