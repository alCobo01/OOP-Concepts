using System;

namespace oopconcepts
{
    public class Program
    {
        public static void Main()
        {
            Door door = new Door();
            SlidingDoor slidingDoor = new SlidingDoor();

            door.Open();
            slidingDoor.Open();
        }
    }
}