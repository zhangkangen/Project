using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02省市联动
{
	public class Area
	{
		int _areaId;

		public int AreaId
		{
			get { return _areaId; }
			set { _areaId = value; }
		}
		string _areaName;

		public string AreaName
		{
			get { return _areaName; }
			set { _areaName = value; }
		}
		int _areaPid;

		public int AreaPid
		{
			get { return _areaPid; }
			set { _areaPid = value; }
		}
		public override string ToString()
		{
			return this.AreaName;
		}
	}
}
