using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int darts, threads;
            int dartsInside = 0;

            Console.WriteLine("How many darts to throw: ");

            darts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many threads to run: ");

            threads = Convert.ToInt32(Console.ReadLine());

            List<Thread> threadList = new List<Thread>(threads);
            List<FindPiThread> findPiList = new List<FindPiThread>(threads);

            for(int i = 0; i < threads; i++)
            {
                FindPiThread findPiTest = new FindPiThread(darts);

                findPiList.Add(findPiTest);

                Thread threadTest = new Thread(new ThreadStart(findPiTest.throwDart));

                threadList.Add(threadTest);

                threadTest.Start();

                Thread.Sleep(16);
            }

            for(int i = 0; i < threadList.Count; i++)
            {
                threadList[i].Join();
            }

            for(int i = 0; i < findPiList.Count; i++)
            {
                dartsInside += findPiList[i].getLanded();
            }

            FindPiThread test = new FindPiThread(darts);

            test.throwDart();
            dartsInside = test.getLanded();

            double pi = 4 * ((double)dartsInside / (double)darts);

            Console.WriteLine("Pi: {0}", pi);

            Console.ReadKey();


        }
    }
}
