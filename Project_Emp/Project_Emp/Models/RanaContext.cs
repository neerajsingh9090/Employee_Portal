using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Project_Emp.Models
{

    public class RanaContext: DbContext
    {
        public RanaContext():base("mycon1")
        {

        }
        public DbSet<Employee> employee { get; set; }
       

    }
}