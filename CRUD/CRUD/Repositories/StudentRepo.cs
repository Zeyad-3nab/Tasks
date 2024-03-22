using CRUD.Models;
using CRUD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Repositories
{
    public class StudentRepo:IEmployeeStudentRepo<Student>
    {
        List<Student> students = new List<Student>();
        public void Add(Student std)
        {
            students.Add(std);
        }

        public void Delete(int id)
        {
            bool check = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    check = true;
                    students.Remove(students[i]);
                    break;
                }
            }
            if (check)
                Console.WriteLine("Student was deleted");
            else
                Console.WriteLine("Student Not Founded");
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            Student e = null;
            bool check = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    check = true;
                    e = students[i];
                    break;
                }
            }
            if (check)
                return e;
            else
                throw new Exception("Student Not Founded");
        }

        public void Update(Student std, int id)
        {
            Student e = null;
            bool check = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    check = true;
                    students[i] = std;
                    break;
                }
            }
            if (check)
                Console.WriteLine("Student Updated");
            else
                Console.WriteLine("Student Not Founded");
        }
    }
}

