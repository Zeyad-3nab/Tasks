using CRUD.Models;
using CRUD.Repositories;

namespace CRUD
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            StudentRepo studentRepo = new StudentRepo();
            Employee emp;
            Student std;
            int id;
            int x;

            do
            {
                Console.WriteLine("1- Employee , 2-Student , any num to exit");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine("1- Add ,  2- Update , 3-Get All Employee , 4- Get by Id , 5- Delete ");
                    int op = int.Parse(Console.ReadLine());
                    switch (op)
                    {

                        //Add
                        case 1:
                            emp = new Employee();
                            Console.Write("Enter Your Name : ");
                            emp.Name = Console.ReadLine();
                            Console.Write("Enter Your Age : ");
                            emp.Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Your Address : ");
                            emp.Address = Console.ReadLine();
                            Console.Write("Enter Your Salary : ");
                            emp.Salary = decimal.Parse(Console.ReadLine());
                            emp.DepartMent = new DepartMent();
                            Console.Write("Enter Your DepartMent Name : ");
                            emp.DepartMent.DeptName = Console.ReadLine();
                            Console.Write("Enter Your DepartMent Code : ");
                            emp.DepartMent.DeptCode = int.Parse(Console.ReadLine());
                            employeeRepo.Add(emp);
                            break;

                        //Update
                        case 2:
                            emp = new Employee();
                            Console.Write("Enter Your Id : ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Your Name : ");
                            emp.Name = Console.ReadLine();
                            Console.Write("Enter Your Age : ");
                            emp.Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Your Address : ");
                            emp.Address = Console.ReadLine();
                            Console.Write("Enter Your Salary : ");
                            emp.Salary = decimal.Parse(Console.ReadLine());
                            emp.DepartMent = new DepartMent();
                            Console.Write("Enter Your DepartMent Name : ");
                            emp.DepartMent.DeptName = Console.ReadLine();
                            Console.Write("Enter Your DepartMent Code : ");
                            emp.DepartMent.DeptCode = int.Parse(Console.ReadLine());
                            employeeRepo.Update(emp, id);
                            break;

                        //GetAll
                        case 3:
                            foreach (var item in employeeRepo.GetAll())
                            {
                                Console.WriteLine(item);
                            }
                            break;

                        //Get By Id
                        case 4:
                            Console.Write("Enter The id that u want to get it");
                            id = int.Parse(Console.ReadLine());
                            Console.WriteLine(employeeRepo.GetById(id));
                            break;

                        //Delete
                        case 5:
                            Console.Write("Enter The id that u want to Delete");
                            id = int.Parse(Console.ReadLine());
                            employeeRepo.Delete(id);
                            break;

                        default:
                            Console.WriteLine("End");
                            break;


                    }
                }
                else if (x == 2)
                {
                    Console.WriteLine("1- Add ,  2- Update , 3-Get All Employee , 4- Get by Id , 5- Delete ");
                    int op = int.Parse(Console.ReadLine());
                    switch (op)
                    {

                        //Add
                        case 1:
                            std = new Student();
                            Console.Write("Enter Your Name : ");
                            std.Name = Console.ReadLine();
                            Console.Write("Enter Your Age : ");
                            std.Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Your Address : ");
                            std.Address = Console.ReadLine();
                            Console.Write("Enter Your SSN : ");
                            std.SSN = decimal.Parse(Console.ReadLine());
                            std.DepartMent = new DepartMent();
                            Console.Write("Enter Your DepartMent Name : ");
                            std.DepartMent.DeptName = Console.ReadLine();
                            Console.Write("Enter Your DepartMent Code : ");
                            std.DepartMent.DeptCode = int.Parse(Console.ReadLine());
                            studentRepo.Add(std);
                            break;

                        //Update
                        case 2:
                            std = new Student();
                            Console.Write("Enter Your Id : ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Your Name : ");
                            std.Name = Console.ReadLine();
                            Console.Write("Enter Your Age : ");
                            std.Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Your Address : ");
                            std.Address = Console.ReadLine();
                            Console.Write("Enter Your SSN : ");
                            std.SSN = decimal.Parse(Console.ReadLine());
                            std.DepartMent = new DepartMent();
                            Console.Write("Enter Your DepartMent Name : ");
                            std.DepartMent.DeptName = Console.ReadLine();
                            Console.Write("Enter Your DepartMent Code : ");
                            std.DepartMent.DeptCode = int.Parse(Console.ReadLine());
                            studentRepo.Update(std, id);
                            break;

                        //GetAll
                        case 3:
                            foreach (var item in studentRepo.GetAll())
                            {
                                Console.WriteLine(item);
                            }
                            break;

                        //Get By Id
                        case 4:
                            Console.Write("Enter The id that u want to get it");
                            id = int.Parse(Console.ReadLine());
                            Console.WriteLine(studentRepo.GetById(id));
                            break;

                        //Delete
                        case 5:
                            Console.Write("Enter The id that u want to Delete");
                            id = int.Parse(Console.ReadLine());
                            studentRepo.Delete(id);
                            break;

                        default:
                            Console.WriteLine("End");
                            break;


                    }
                }
                else
                    break;

            } while (x == 1 || x == 2);




        }
    }
}
