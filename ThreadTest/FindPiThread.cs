using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
            

            for (int i = 0; i < dartsToThrow; i++)
            {
                double x = throws.NextDouble();
                double y = throws.NextDouble();

                if (((x * x) + (y * y)) <= 1)
                {
                    //Console.WriteLine("x: {0}", x[i]);
                    //Console.WriteLine("y: {0}", y[i]);
                    dartsLanded ++;
                }
            }
            
        }

        private int dartsToThrow;
        private int dartsLanded;
        private Random throws;
    }
}
