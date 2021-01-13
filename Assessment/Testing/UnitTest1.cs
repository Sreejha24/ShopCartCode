using System;
using Xunit;
using Assessment;
using Assessment.Controllers;
using Assessment.Data;
using Microsoft.EntityFrameworkCore;

namespace Testing
{
    public class UnitTest1
    {
        private readonly ApplicationDbContext _context;
        private readonly FileUploadsController _fileUploads;
        static string Connstr = null;

        public UnitTest1(ApplicationDbContext context,FileUploadsController fileUploads)
        {
            Connstr = " Data Source = 192.168.50.95; Initial Catalog = gmekala; Integrated Security = True; Persist Security Info = False; Pooling = False; Encrypt = False; TrustServerCertificate = False; MultipleActiveResultSets = true";
            var contextOptions = new DbContextOptionsBuilder().UseSqlServer(connStr);
            _context = context;
            _fileUploads = fileUploads;
        }
        [Fact]
        public void Test1()
        {
          
        }
    }
}
