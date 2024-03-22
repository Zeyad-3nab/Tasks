using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BaseModel
{
    public abstract class Person
    {
        static int id = 1;
        public int Id { get;}
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }


        protected Person(string name="No Name" , string address = "NoAddress" , int age=0) 
        {
            Id = id++;
            Name = name;
            Address = address;
            Age = age;
        }






    }
}
