using System;

namespace oopconcepts
{
    public class Program
    {
        public static void Main()
        {
            Door metalicDoor = new Door("Metal", "Gray");
            SlidingDoor woodenSlidingDoor = new SlidingDoor("Wood", "Brown", true);

            Console.WriteLine($"Is door 1 made of wood? {HelperMethods.IsMadeOfWood(metalicDoor)}");
            Console.WriteLine($"Is door 2 made of wood? {HelperMethods.IsMadeOfWood(woodenSlidingDoor)}");
        }
    }
}