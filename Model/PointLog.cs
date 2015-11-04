using System;
namespace VipSoft.Model
{
	/// <summary>
	/// PointLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PointLog
	{
		public PointLog()
		{}
		#region Model
		private int _id;
		private string _cardid;
		private string _memname;
		private int? _point;
		private int? _type;
		private DateTime? _createdatetime;
		private int? _shopid;
		private string _shopname;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MemName
		{
			set{ _memname=value;}
			get{return _memname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Point
		{
			set{ _point=value;}
			get{return _point;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDateTime
		{
			set{ _createdatetime=value;}
			get{return _createdatetime;}
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

