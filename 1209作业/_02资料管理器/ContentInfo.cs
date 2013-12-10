using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02资料管理器
{
	public class ContentInfo
	{
		int dId;

		public int DId
		{
			get { return dId; }
			set { dId = value; }
		}
		int dtId;

		public int DtId
		{
			get { return dtId; }
			set { dtId = value; }
		}
		string dName;

		public string DName
		{
			get { return dName; }
			set { dName = value; }
		}
		string dContent;

		public string DContent
		{
			get { return dContent; }
			set { dContent = value; }
		}
	}
}
