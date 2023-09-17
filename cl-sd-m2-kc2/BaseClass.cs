using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cl_sd_m2_kc2
{
    internal class BaseClass
    {
        public string name { get; set; }
        public string description { get; set; }

        public virtual void DisplayProperties()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Description: {description}");
        }
    }
}
