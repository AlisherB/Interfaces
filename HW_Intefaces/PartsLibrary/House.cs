using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLibrary
{
    public class House
    {
        private static int countWalls = 4;
        private static int countWindows = 4;
        private IPart basement;
        private IPart door;
        private IPart roof;
        private IPart[] windows = new Windows[countWindows];
        private IPart[] walls = new Walls[countWalls];
        public House()
        {
            roof = new Roof();
            basement = new Basement();
            door = new Door();
            for (int i = 0; i < countWalls; i++)
            {
                walls[i] = new Walls();
            }
            for (int i = 0; i < countWindows; i++)
            {
                windows[i] = new Windows();
            }
        }
        public int GetCountWalls()
        {
            return countWalls;
        }
        public int GetCountWindows()
        {
            return countWindows;
        }
        public IPart GetBasement()
        {
            return basement;
        }
        public IPart GetDoor()
        {
            return door;
        }
        public IPart GetRoof()
        {
            return roof;
        }
    }
}
