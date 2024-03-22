using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class DepartMent
    {
        public int DeptCode { get; set; }
        public string DeptName { get; set; }


        public DepartMent(int deptCode=0 , string deptName="No Name") 
        {
            DeptCode = deptCode;
            DeptName = deptName;
        }

        public override string ToString()
        {
            return $"DepartMent Code = {DeptCode} , DepartMent Name = {DeptName}";
        }


    }
}
