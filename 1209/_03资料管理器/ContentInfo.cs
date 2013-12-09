using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03资料管理器
{
	public class ContentInfo
	{
		int _dId;

		public int DId
		{
			get { return _dId; }
			set { _dId = value; }
		}
		int _dTId;

		public int DTId
		{
			get { return _dTId; }
			set { _dTId = value; }
		}
		string _dName;

		public string DName
		{
			get { return _dName; }
			set { _dName = value; }
		}
		string _dContent;

		public string DContent
		{
			get { return _dContent; }
			set { _dContent = value; }
		}
	}
}
