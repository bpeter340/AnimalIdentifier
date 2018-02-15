using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class TagReader
    {
        bool found_dog = false;
        bool found_cat = false;
        string hold = " ";

        public void animal_finder(Tag var) {
            
            //Figures if image tags return cats, dogs, or both  

                if (var.name == "dog")
                    found_dog = true;
                else if (var.name == "dogs")
                    found_dog = true;
                else if (var.name == "cat")
                    found_cat = true;
                else if (var.name == "cats")
                    found_cat = true;
                else
                    hold = "Prediction: You talked about neither a cat nor a dog.";
           
            }
        public void animal_found()
        {
            //Decision making if-else statements
            if (found_dog == found_cat && found_dog == true)
                Console.WriteLine("This picture has both a cat and a dog!");
            else if (found_dog)
                Console.WriteLine("This picture has a dog.");
            else if (found_cat)
                Console.WriteLine("This picture has a cat.");
            else
                Console.WriteLine(hold);
        }

    }
}
