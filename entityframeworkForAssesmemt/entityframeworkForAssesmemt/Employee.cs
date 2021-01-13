using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entityframeworkForAssesmemt
{
    [Table("Employee")]
    class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
       
        public decimal Salary{ get; set; }
        public int DeptNo { get; set; }
    }
}
