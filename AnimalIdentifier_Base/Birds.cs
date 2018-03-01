using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Birds: Animals
    {
        public override void Print()
        {
            Console.WriteLine("This picture contains a bird.");
        }
        public override void Animal_finder(Tag var)
        {
            Birds check_Bird = new Birds();

            if (var.name == "bird")
                Is_found = true;
            else if (var.name == "birds")
                Is_found = true;
        }
    }
}
