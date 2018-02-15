/*Barthelemy Peter
  2-13-2018
  Image Reader
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Program
    {

        static void Main()
        {
            TagReader find = new TagReader();

            // Get the path and filename to process from the user.
            Console.WriteLine("Analyze an image:");
            Console.Write("Enter the path to an image you wish to analzye: ");
            string imageFilePath = Console.ReadLine();

            ImageTagger animalImageTagger = new ImageTagger();
            List<Tag> tags = animalImageTagger.GetTagsForImage(imageFilePath);
            Console.WriteLine("What is going on here");
            foreach (Tag tag in tags)
            {
                find.animal_finder(tag);
                Console.WriteLine(tag.name);
            }

            find.animal_found();


            Console.WriteLine("Press Any Key to Continue.");
            Console.ReadLine();
        }
    }
}
