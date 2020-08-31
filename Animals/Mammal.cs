using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    abstract class Mammal : Animal
    {
        public bool HasHair { get; set; }

        public bool DrinksMilk { get; set; }

        public abstract bool Omnivore { get; }

        public bool Carnivore => !Omnivore;

        public override string Sound { get; }

        public override string Home { get; }

        public override void Sleep()
        {
            base.Sleep();
        }
    }

    class GrizzlyBear : Mammal
    {
        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("I also hybernate for a good chunk of the year as well.");
        }

        public override bool Omnivore => true;

        public override string Sound => "Roar";
        public override string Home => "Cave";
    }

    class BlueWhale : Mammal
    {
        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("I can sleep while moving or not moving.");
            Console.WriteLine("Sometimes I even sleep straight up and down.");
        }

        public override bool Omnivore => false;

        public override string Sound => "Groan";
        public override string Home => "Ocean";
    }

    class Lion : Mammal
    {
        public override void Sleep()
        {
            base.Sleep();
        }

        public override bool Omnivore => false;

        public override string Sound => "Roar";
        public override string Home => "Grassland";
    }
}
