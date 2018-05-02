using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    public class Dogs: Animals
    {

        public override void Print()
        {
            Console.WriteLine("This picture contains a dog.");
        }

        public override void Animal_finder(Tag var)
        {
            if (var.name == "dog" && Certainty(var) >= .8)
                Is_found = true;
            else if (var.name == "dogs" && Certainty(var) >= .8)
                Is_found = true;

        }

        public override double Certainty(Tag var)
        {
            return var.confidence;
        }

    }
}
