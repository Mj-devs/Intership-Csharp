using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro___Day_1
{
    
        public class GoodGames 
       { 
        public string gamename;
        public string Gamename
        {
            get
            {
                return gamename;
            }
            set
            {
                gamename = value;
            }
        }
        public GoodGames(string gamename)
        {
            this.gamename = gamename;
        }

        public void Genre()
        {
            Console.WriteLine("Shooter");
        }
      }
    }

