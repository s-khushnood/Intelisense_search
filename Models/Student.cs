﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentIntelisenceApi.Models
{
    public class Student
    {
       public int ID { get; set; }
       public  string FirstName { get; set; }
       public string LastName { get; set; }
       public string Course { get; set; }
       public int Age { get; set; }
    }
}