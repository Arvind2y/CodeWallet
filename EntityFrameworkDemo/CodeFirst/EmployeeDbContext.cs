﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // modelBuilder

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}