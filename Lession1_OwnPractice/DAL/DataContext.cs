using Lession1_OwnPractice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lession1_OwnPractice.DAL
{
    public class DataContext :DbContext
    {
        public DataContext():base("name=DbConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}