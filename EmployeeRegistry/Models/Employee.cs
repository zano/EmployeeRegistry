﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeRegistry.Models
{
    public class Employee
    {
        // This is just a plain old C# object class

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Company { get; set; } 

        // Todo: Extract Company to own entity
    }
}