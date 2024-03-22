using CRUD.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Employee:Person
    {
        public decimal Salary{ get; set; }
        public DepartMent DepartMent { get; set; }  //Navigation Prop

        public Employee(DepartMent d , string name = "No Name", string address = "NoAddress", int age = 0 , decimal s = 0) :base(name, address, age)
        {
            Salary = s;
            DepartMent = d;
        }

        public Employee()
        {

        }

        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Age = {Age} , Address = {Address} , Salary = {Salary} , {DepartMent}";
        }
    }
}
