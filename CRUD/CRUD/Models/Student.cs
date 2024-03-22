using CRUD.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CRUD.Models
{
    public class Student:Person
    {
        public decimal SSN { get; set; }
        public DepartMent DepartMent { get; set; }  //Navigation Prop

        public Student(DepartMent d, string name = "No Name", string address = "NoAddress", int age = 0, decimal ssn = 0) : base(name, address, age)
        {
            SSN = ssn;
            DepartMent = d;
        }

        public Student()
        {
        }

        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Age = {Age} , Address = {Address} , SSN = {SSN} , {DepartMent}";
        }
    }
}
