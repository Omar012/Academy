using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCScaffolding.Models
{
    public class Employee
    {
        public int Id { get; set; }

            
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime JoiningDate { get; set; }

        public int Age { get; set; }


    }
    public class EmpDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
