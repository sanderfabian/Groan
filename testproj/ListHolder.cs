using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanderVictorAssgt
{//Sander Fabian C3418982 & Victor Chua Jia Zhi C3418248
    public static class ListHolder // static to make it accessible to all forms
    {
        
        public class TableContent // creating a object class
        {
            public int key { get; set; }
            public string activePlayer { get; set; }
            public int die1 { get; set; }
            public int die2 { get; set; }
            public int runScore { get; set; }
            public int cumScore { get; set; }
            public string comments { get; set; }
        }
    }
}
