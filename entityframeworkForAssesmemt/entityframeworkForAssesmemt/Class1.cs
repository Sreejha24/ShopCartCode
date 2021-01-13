using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace entityframeworkForAssesmemt
{
    class Class1
    {

        private readonly ContextClass _context;
            public Class1()
            {
                _context = new ContextClass();
            }

            public IList<Employee> GetEmployees()
            {

                var Data = _context.Employees.ToList();
                return Data;

            }
        public void insertRecords()
        {
            var emp = new Employee()
            {
                EmpName = "roshini",
                Id = 9,
                Salary = 566556,
                DeptNo = 12,
            };
            _context.Employees.Add(emp);
            _context.SaveChanges();
        }
        public void UpdateEmployee(int EmpId,string EmpName)
        {
            var data = _context.Employees.Where(d => d.Id == EmpId).FirstOrDefault();
            if(data!=null)
            {
                data.EmpName = EmpName;
                _context.SaveChanges();
            }

        }
        public void DeleteRecord(int empid)
        {
            var data = _context.Employees.Where(d => d.Id == empid).FirstOrDefault();
            if(data!=null)
            {
                _context.Employees.Remove(data);
                _context.SaveChanges();
            }
        }
        public void InsertRecords()
        {
            var emp = new Employee()
            {
                EmpName = Console.ReadLine(),
                Id = int.Parse(Console.ReadLine()),
                Salary=decimal.Parse(Console.ReadLine()),
                DeptNo=int.Parse(Console.ReadLine())

            };
            _context.Employees.Add(emp);
            _context.SaveChanges();
        }

        
    }
}

