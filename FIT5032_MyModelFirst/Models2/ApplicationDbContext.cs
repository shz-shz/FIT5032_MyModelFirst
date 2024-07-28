using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FIT5032_MyModelFirst.Models2;

namespace FIT5032_MyModelFirst.Models2
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}