﻿using System.Collections.Generic;

namespace CodeFirst
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; }
    }
}