using System;
namespace VipSoft.Model
{
	/// <summary>
	/// MoneyRule:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MoneyRule
	{
		public MoneyRule()
		{}
		#region Model
		private int? _id;
		private string _name;
		private decimal? _onehourmoney;
		private decimal? _secondhourmoney;
		private decimal? _thirdhourmoney;
		private int? _thantime;
		/// <summary>
		/// 
		/// </summary>
		public int? ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OneHourMoney
		{
			set{ _onehourmoney=value;}
			get{return _onehourmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SecondHourMoney
		{
			set{ _secondhourmoney=value;}
			get{return _secondhourmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ThirdHourMoney
		{
			set{ _thirdhourmoney=value;}
			get{return _thirdhourmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ThanTime
		{
			set{ _thantime=value;}
			get{return _thantime;}
		}
		#endregion Model

	}
}

