﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenWF_Mañana_30052023.models
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public abstract string MaritalStatus { get; set; }
    }
}