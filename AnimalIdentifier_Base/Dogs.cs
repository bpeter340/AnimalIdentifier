using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Dogs: Animals
    {

        public override void Print()
        {
            Console.WriteLine("This picture contains a dog.");
        }

        public override void Animal_finder(Tag var)
        {
            Dogs check_Dog = new Dogs();

            if (var.name == "dog")
                Is_found = true;
            else if (var.name == "dogs")
                Is_found = true;
        }

    }
}
