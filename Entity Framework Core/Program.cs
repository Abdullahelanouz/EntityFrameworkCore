using System;

namespace Entity_Framework_Core
{
     class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            
            _context.SaveChanges();
        }
    }
}
