using System;

namespace oopconcepts
{
    public class SlidingDoor : Door
    {
        public bool IsAutomatic { get; set; }

        public SlidingDoor(string material, string color, bool isAutomatic) : base(material, color)
        {
            IsAutomatic = isAutomatic;
        }
    }
}


