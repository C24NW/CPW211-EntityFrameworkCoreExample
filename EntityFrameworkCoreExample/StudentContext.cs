using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
    public class StudentContext : DbContext
    {
        public StudentContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Server = The server we are connecting to. LocalDB is included with VS.
            //Database = The desired name for the database.
            //Trusted_Connection = Indicates that our windows account should be used.
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
