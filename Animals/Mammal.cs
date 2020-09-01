using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Mammal : Animal
    {
        public bool HasHair { get; set; }

        public bool DrinksMilk { get; set; }

        public override string Sound { get; }

        public override string Home { get; }

        public override void Sleep()
        {
            base.Sleep();
        }
    }

    public class GrizzlyBear : Animal, IMammal
    {
        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("I also hybernate for a good chunk of the year as well.");
        }

        public bool HasHair => true;

        public string DrinksMilk => "45 oz per day";

        public override string Name => "Grizzly Bear";

        public override bool Omnivore => true;

        public override string Sound => "Roar";
        public override string Home => "Cave";
    }

    public class BlueWhale : Animal, IMammal
    {
        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("I can sleep while moving or not moving.");
            Console.WriteLine("Sometimes I even sleep straight up and down.");
        }

        public bool HasHair => true;

        public string DrinksMilk => "150 liters per day";

        public override string Name => "Blue Whale";

        public override bool Omnivore => false;

        public override string Sound => "Groan";
        public override string Home => "Ocean";
    }

    public class Lion : Animal, IMammal
    {
        public override void Sleep()
        {
            base.Sleep();
        }

        public bool HasHair => true;

        public string DrinksMilk => "200ml a day";

        public override string Name => "Lion";

        public override bool Omnivore => false;

        public override string Sound => "Roar";
        public override string Home => "Grassland";
    }
}
