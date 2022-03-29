using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Student
    {
        private string _groupNo;
        private string _fullName;
        private byte _age;
        public string FullName 
        {
            get => _fullName; 
            set
            {
                if(value.FullNameChecker())
                    _fullName = value;
            }
                }
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if(value.GroupNoChecker())
                    _groupNo = value;
            }
        }
        public byte Age
        {
            get => _age;
            set
            {
                if (value > 5)
                    _age = value;
            }
        }
        public Student(string gropNo ,string fullName, byte age)
        {
            GroupNo = gropNo;
            FullName = fullName;
            Age = age;
        }
        public string ShowInfo()
        {
            return $"GropNo: {this.GroupNo} - FullName: {this.FullName} - Age: {this.Age}";
        }
    }
}
