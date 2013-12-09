using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03资料管理器
{
	public class Category
	{
		int _tId;

		public int TId
		{
			get { return _tId; }
			set { _tId = value; }
		}
		string _tName;

		public string TName
		{
			get { return _tName; }
			set { _tName = value; }
		}
		int _tParentId;

		public int TParentId
		{
			get { return _tParentId; }
			set { _tParentId = value; }
		}
	}
}
