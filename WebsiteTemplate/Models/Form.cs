using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Models
{
    public class Form
    {
        public int Age { get; set; }
        public float Weight { get; set; }
        public float Heigth { get; set; }
        public string PhysicalActivity { get; set; }
    }
}