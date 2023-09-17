using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_sd_m2_kc2
{
    internal class InheritingClass : BaseClass
    {
        public string type { get; set; }

        public override void DisplayProperties()
        {
            base.DisplayProperties();
            Console.WriteLine($"Type: {type}");
            Console.WriteLine("\n");
        }
    }
}
