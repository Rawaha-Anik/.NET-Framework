using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
