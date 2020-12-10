using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * This will be the player in the high score list
 */
namespace tile_match
{
    class player
    {
        public string Name { get; set; }//auto implemented variable for the players name
        public double Score { get; set; }//auto implemented variable for the players name
        //constructor with 2 parameters
        public player(string name, double score)
        {
            Name = name;
            Score = score;
        }
    }
}
