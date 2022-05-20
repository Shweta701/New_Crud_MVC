using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace New_Crud_MVC.Models
{
    public class ApplicationDb:DbContext
    {
        public ApplicationDb() : base("Data Source=CHETUIWK560\\SQLEXPRESS;Initial Catalog=MVC_CRUD;Integrated " +
            "Security=True") { }
        public DbSet<Employee>employees { get; set; }
    }
}