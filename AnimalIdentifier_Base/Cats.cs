using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Cats: Animals
    {
        public override void Print()
        {
            Console.WriteLine("This picture contains a cat.");
        }
        public override void Animal_finder(Tag var)
        {
            Cats check_Cat = new Cats();
            
            if (var.name == "cat")
                Is_found = true;
            else if (var.name == "cats")
                Is_found = true;
        }
    }
}
