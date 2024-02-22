using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public static int numofAnimal = 0;
        public animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
            numofAnimal++;
        }
        public virtual void speak()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }
        protected animalstat anistat = new animalstat();
        public void setStat(double weight, double age, double height, string ownername, int id)
        {
            anistat.Weight = weight;
            anistat.Age = age;
            anistat.Height = height;
            anistat.Ownername = ownername;
            anistat.ID = id;
        }
        public void getStat()
        {
            Console.WriteLine($"{Name} is {anistat.Weight}kg and {anistat.Height}cm and is {anistat.Age} years old");
            Console.WriteLine($"The owner is {anistat.Ownername} and {Name} id is {anistat.ID}");

        }
        public void ishealthy()
        {
            if (anistat.isHealthy)
            {
                Console.WriteLine($"{Name} is healthy");
            }
            else if (!anistat.isHealthy)
            {
                Console.WriteLine($"{Name} isnot healthy");
            }
        }

    }
}