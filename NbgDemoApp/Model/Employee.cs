using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbgDemoApp.Model
{
    public class Employee:Person
    {
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" Salary= {Salary}";
        }
    }
}
