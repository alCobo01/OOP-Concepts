using System;

namespace oopconcepts
{
    public class Door
    {
        public virtual void Open() => Console.WriteLine("The door opens.");

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
        
        public static void Open(int password) => Console.WriteLine($"The door opens with the password {password}.");
        public void Close() => Console.WriteLine("The door is closed");
    }
}


