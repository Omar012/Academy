using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength (60, MinimumLength= 3)]
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime  JoiningDate { get; set; }

        [Range(18,60)]
        public int Age { get; set; }

    }

    public class EmpDBContext : DbContext
    {
        public EmpDBContext() { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EmpDBContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}