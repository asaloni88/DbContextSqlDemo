﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContextSqlDemo.Models
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Job { get; set; }
        public int Age { get; set; }    
    }
}