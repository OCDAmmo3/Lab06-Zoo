using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    abstract class Fish : Animal
    {
        public bool HasGills { get; set; }

        public bool LivesInOcean { get; set; }

        public override string Sound { get; }

        public override string Home { get; }

        public override void Sleep()
        {
            base.Sleep();
        }
    }

    class ClownFish : Fish
    {
        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("I sleep in an anenome, and it is actively awake while I'm sleeping.");
        }

        public override string Name => "Clown Fish";

        public override bool Omnivore => true;

        public override string Sound => "Chirp";
        public override string Home => "Anemone";
    }

    class GreatWhiteShark : Fish
    {
        public override void Sleep()
        {
            Console.WriteLine("I don't really sleep like people do.");
            Console.WriteLine("Because I have to keep swimming at all times (or die)");
            Console.WriteLine("I just take naps often periodically through the day while I can drift forward.");
        }

        public override string Name => "Great White Shark";

        public override bool Omnivore => false;

        public override string Sound => "Silence";
        public override string Home => "Ocean";
    }
}
