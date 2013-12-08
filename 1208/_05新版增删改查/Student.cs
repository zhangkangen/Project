using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05新版增删改查
{
	public class Student
	{
		//tsname,tsgender,tsage,tsclassid
		int _tsId;

		public int TsId
		{
			get { return _tsId; }
			set { _tsId = value; }
		}
		string _tsName;

		public string TsName
		{
			get { return _tsName; }
			set { _tsName = value; }
		}
		char _tsGender;

		public char TsGender
		{
			get { return _tsGender; }
			set { _tsGender = value; }
		}
		int _tsAge;

		public int TsAge
		{
			get { return _tsAge; }
			set { _tsAge = value; }
		}
		int _tsClassId;

		public int TsClassId
		{
			get { return _tsClassId; }
			set { _tsClassId = value; }
		}

	}
}
