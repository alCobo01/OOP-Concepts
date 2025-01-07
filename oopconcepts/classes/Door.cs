using System;

namespace oopconcepts
{
    public class Door
    {
        //Attributes
        public string Material { get; set; }
        public string Color { get; set; }

        //Constructor with the highest logical load
        public Door(string material, string color)
        {
            Material = material;
            Color = color;
        }

        //Constructor with the lowest logical load
        public Door()
        {
            Material = "Wood";
            Color = "Brown";
        }

        //Methods
        public void Open() => Console.WriteLine("The door is open");
        public void Close() => Console.WriteLine("The door is closed");
    }
}


