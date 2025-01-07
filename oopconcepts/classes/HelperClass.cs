using System;
using System.Diagnostics;

namespace oopconcepts
{
    public class HelperMethods
    {
        public static bool IsMadeOfWood(Door door)
        {
            return door.Material == "Wood";
        }

        public static bool IsAutomatic(SlidingDoor door)
        {
            return door.IsAutomatic;
        }
    }
}
