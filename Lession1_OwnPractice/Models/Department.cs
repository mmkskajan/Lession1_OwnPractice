using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lession1_OwnPractice.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee DepartmentHead { get; set; }
        
    }
}