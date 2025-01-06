using System;

namespace oopconcepts
{
    public class Room
    {
        public Wall[] Walls { get; set; }

        public Room(Wall[] walls)
        {
            Walls = walls;
        }
    }
}
