using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace fileUpload.Models
{
    public class File
    {
        [Key]
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        [NotMapped]
        public IFormFile photo { get; set; }
    }
}
