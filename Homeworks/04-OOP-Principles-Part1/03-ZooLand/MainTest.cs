using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand
{
    class MainTest
    {
        static void Main()
        {
            Frog kermitt = new Frog("Frog", 2, "male", 3, "Kermitt");
            Dog doggy = new Dog("Dog", 4, "male", 9, "Doggy");
            Dog doggytta = new Dog("Dog", 3,  "female", 8, "Doggytta");
            Cat stefka = new Cat("Cat", 2, "female", 2, "Stefka");
            Cat stefko = new Cat("Cat", 3,"male", 1, "Stefko");
            Kitten minka = new Kitten("Kitten cat", 3, "male", 1, "Minka");
            Tomcat monko = new Tomcat("Tomcat", 3, "female", 3, "Monko");

            Animal[] someAnimals = { kermitt, doggy, doggytta, stefka, stefko, minka, monko };
            ISound[] someSounds = { kermitt, doggy, doggytta, stefka, stefko, minka, monko };

            // test gender
            foreach (var animal in someAnimals)
            {
                Console.WriteLine("{0}-{1}-{2}", animal.AnimalName, animal.Name, animal.Gender);
            }
            //test Isound
            foreach (var animal in someSounds)
            {
                Console.WriteLine("{0}-{1}", animal.ToString(), animal.ProvideSound());
            }

            double averageAge = Average.GetAverage(someAnimals);
            Console.WriteLine("The average age is {0:0.00} years", averageAge);
        }
    }
}
