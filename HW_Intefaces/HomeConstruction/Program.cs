using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkersLibrary;
using PartsLibrary;
using static System.Console;

namespace HomeConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team();
            team.HomeConstruction();
            ReadLine();
        }
    }
}
