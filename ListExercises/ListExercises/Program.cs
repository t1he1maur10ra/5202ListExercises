using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 1*/
            List<string> animals = new List<string>();
            animals.Add("Horse");
            animals.Add("Cow");
            animals.Add("Sheep");
            animals.Add("Duck");
            animals.Add("Chicken");

            Console.WriteLine("...Farm Animals...");
            foreach(string s in animals)
                Console.WriteLine(s);

            Console.WriteLine("Press ENTER to coninue...");
            Console.ReadLine();

            /*Ex 2*/
            List<string> names = new List<string>();
            bool loop = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter a name: ");
                names.Add(Console.ReadLine());

                Console.WriteLine("Would you like to add anther name (y/n): ");
                string result = Console.ReadLine().ToLower();

                if (result == "n")
                    loop = false;


            } while (loop);


            Console.WriteLine("...Names...");
            foreach (string s in names)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
