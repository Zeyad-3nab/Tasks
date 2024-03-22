using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Services
{
    public interface IEmployeeStudentRepo<T>
    {
        public void Add(T emp);
        public void Update(T emp , int id);
        public void Delete(int id);
        public List<T> GetAll();
        public T GetById(int id);


    }
}
