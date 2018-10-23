using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//For Test: Wizards, Orthagonality, Pride and Predijuce Chapter, Databases in WPF, software development life cycle(waterfall), structual/behavior patt
//UMLS, Creational???

namespace ThreadTest
{
    class FindPiThread
    {
        public FindPiThread(int darts)
        {
            dartsToThrow = darts;
            dartsLanded = 0;
        
            throws = new Random();
        }

        public int getLanded()
        {
            return dartsLanded;
        }

        public void throwDart()
        {
            double x = throws.NextDouble();
            double y = throws.NextDouble();

            for (int i = 0; i < dartsToThrow; i++)
            {
                if (1 <= ((x * x) + (y * y)))
                {
                    dartsLanded += 1;
                }
            }
            
        }

        private int dartsToThrow;
        private int dartsLanded;
        private Random throws;
    }
}
