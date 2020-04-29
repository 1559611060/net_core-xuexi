using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_start.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }//部门ID
        public string FirstName { get; set; }//姓名
        public string LastName { get; set; }//名
        public Gender Gender { get; set; }//性别
        public bool Fired { get; set; }//是否解雇


    }
    public enum Gender
    {
        女 = 0,
        男 = 1
    }
}
