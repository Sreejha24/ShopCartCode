using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Models
{
    [Table("EmployeeFile")]
    public class FileUpload
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        [DataType(DataType.Upload)]
        public string photo { get; set; }
    }
}
