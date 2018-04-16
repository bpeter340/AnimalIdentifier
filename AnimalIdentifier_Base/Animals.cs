using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    abstract class Animals
    {
        public bool Is_found = false;

        public abstract void Print();
        public abstract void Animal_finder(Tag var);
        public abstract double Certainty(Tag var);
        
    }
   
}
