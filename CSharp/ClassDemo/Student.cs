using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Student
    {
        private int RollNo;
        private string Name;
        public Student(int RollNo, string Name)
        {
            this.RollNo = RollNo;
            this.Name = Name;
        }
        public int GetRollNo()
        {
            return RollNo;
        }
        public void SetRollNo(int RollNo)
        {
            this.RollNo = RollNo;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
    }
}
