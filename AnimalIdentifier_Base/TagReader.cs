using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    public class TagReader
    {
        //Variable Declarations had to be public to be used through the rest of the program
        public Dogs check_Dog = new Dogs();
        public Cats check_Cat = new Cats();
        public Birds check_Bird = new Birds();
        
        
        public SearchResult animal_Found()
        {
            SearchResult results = new SearchResult();
            //Decision making if-else statements
            //next few lines check for a combination of dogs, cats, and birds
            //if (check_Dog.Is_found == check_Cat.Is_found && check_Dog.Is_found == true)
            //{
            //    if (check_Bird.Is_found == check_Dog.Is_found)
            //        Console.WriteLine("This picture has a dog, a cat, and a bird!");
            //    else
            //        Console.WriteLine("This picture has both a cat and a dog!");
            //}
            //else if (check_Bird.Is_found == check_Cat.Is_found && check_Bird.Is_found == true)
            //    Console.WriteLine("This picture has both a cat and a bird!");
            //else if (check_Bird.Is_found == check_Dog.Is_found && check_Bird.Is_found == true)
            //    Console.WriteLine("This picture has both a dog and a bird!");

            ////Checks for singular uses of dogs, cats, and birds. Output handled by child classes of Animal
            //else if (check_Dog.Is_found)
            //    check_Dog.Print();
            //else if (check_Cat.Is_found)
            //    check_Cat.Print();
            //else if (check_Bird.Is_found)
            //    check_Bird.Print();
            //else
            //    Console.WriteLine("This picture does not contain a dog, cat, or bird.");

            results.FoundDog = check_Dog.Is_found;

            return results;
        }
        // Funtion set up for use of Polymorphic variable. Var is the polymorphic variable parameter
         public void Polymorphic(Animals var, Tag place_holder)
        {
            var.Animal_finder(place_holder);
        }
    }
}
