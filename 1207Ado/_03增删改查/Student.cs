using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03增删改查
{
    public class Student
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}
