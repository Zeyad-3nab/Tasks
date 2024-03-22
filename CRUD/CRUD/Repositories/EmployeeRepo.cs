using CRUD.Models;
using CRUD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Repositories
{
    public class EmployeeRepo : IEmployeeStudentRepo<Employee>
    {
        List<Employee> employees=new List<Employee>();
        public void Add(Employee emp)
        {
            employees.Add(emp);
        }

        public void Delete(int id)
        {
            bool check = false;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    check = true;
                    employees.Remove(employees[i]);
                    break;
                }
            }
            if (check)
                Console.WriteLine("Employee was deleted");
            else
                Console.WriteLine("Employee Not Founded");
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetById(int id)
        {
            Employee e =null ;
            bool check = false;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    check = true;
                    e= employees[i];
                    break;
                }
            }
            if (check)
                return e;
            else
                throw new Exception("Employee Not Founded");
        }

        public void Update(Employee emp, int id)
        {
            Employee e = null;
            bool check = false;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    check = true;
                     employees[i]=emp;
                    break;
                }
            }
            if (check)
                Console.WriteLine("Employee Updated");
            else
                Console.WriteLine("Employee Not Founded");
        }
    }
}
