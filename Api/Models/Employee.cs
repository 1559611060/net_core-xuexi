using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }//部门ID
        [Display(Name = "姓名")]
        public string FirstName { get; set; }//姓名
        [Display(Name ="名称")]
        public string LastName { get; set; }//名
        [Display(Name ="性别")]
        public Gender Gender { get; set; }//性别
        public bool Fired { get; set; }//是否解雇


    }
    public enum Gender
    {
        女 = 0,
        男 = 1
    }
}
