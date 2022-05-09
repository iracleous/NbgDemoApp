using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbgDemoApp.Model
{
    public class Customer:Person
    {
        public decimal Credit { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" Credit= {Credit}";
        }
    }
}
