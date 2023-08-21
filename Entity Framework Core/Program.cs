using System;

namespace Entity_Framework_Core
{
     class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            var employee = new Employee
            {
                Name = "Test 1",
            };

            _context.Employes.Add(employee);
            _context.SaveChanges();
        }
    }
}
