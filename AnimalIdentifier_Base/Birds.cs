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
           
            if (var.name == "bird" && Certainty(var) >= .8)
                Is_found = true;
            else if (var.name == "birds" && Certainty(var) >= .8)
                Is_found = true;
        }
        public override double Certainty(Tag var)
        {
            return var.confidence;
        }

    }
}
