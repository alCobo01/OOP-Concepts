using System;

namespace oopconcepts
{
    public class SlidingDoor : Door
    {
        public override void Open() => Console.WriteLine("The sliding door is sliding.");


        public bool IsAutomatic { get; set; }

        public SlidingDoor(string material, string color, bool isAutomatic) : base(material, color)
        {
            IsAutomatic = isAutomatic;
        }

        public SlidingDoor() : base()
        {
            IsAutomatic = false;
        }


    }
}


