using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        public static void Main(string[] args)
        {
            GrizzlyBear bear = new GrizzlyBear();
            Console.WriteLine($"{bear.Name}s like to {bear.Sound} while they aren't laying in their {bear.Home}. They are {bear.Diet}s.");
            bear.Sleep();

            Console.WriteLine("");

            Lion lion = new Lion();
            Console.WriteLine($"{lion.Name}s also like to {lion.Sound}, whether they're laying in their {lion.Home} or not. They are {lion.Diet}s.");
            lion.Sleep();

            Console.WriteLine("");

            BlueWhale whale = new BlueWhale();
            Console.WriteLine($"While also a mammal, a {whale.Name} actually lives in the {whale.Home} and makes a {whale.Sound} noise to talk. They are {whale.Diet}s.");
            whale.Sleep();

            Console.WriteLine("");

            ClownFish clown = new ClownFish();
            Console.WriteLine($"Then there's fish. A {clown.Name} surprisingly makes a small {clown.Sound} noise to talk. They live in {clown.Home}s. They are {clown.Diet}s.");
            clown.Sleep();

            Console.WriteLine("");

            GreatWhiteShark shark = new GreatWhiteShark();
            Console.WriteLine($"Our final animal is the {shark.Name}. Their sound? {shark.Sound}. They live like whales, just in the {shark.Home}. They are, of course, {shark.Diet}s.");
            shark.Sleep();
        }

        public abstract string Name { get; }

        public abstract bool Omnivore { get; }

        public string Diet => Omnivore ? "Omnivore" : "Carnivore";

        public virtual void Sleep()
        {
            Console.WriteLine("I sleep at night like the average human.");
        }

        public abstract string Sound { get; }

        public abstract string Home { get; }
    }
}
