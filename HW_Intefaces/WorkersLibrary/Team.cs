using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartsLibrary;

namespace WorkersLibrary
{
    public class Team
    {
        IWorker teamLeader;
        IWorker worker;
        House house;

        public Team()
        {
            worker = new Worker();
            teamLeader = new TeamLeader();
            house = new House();
        }
        public void HomeConstruction()
        {
            teamLeader.WorkIsDone(house);
            worker.WorkIsDone(house);
        }
    }
}
