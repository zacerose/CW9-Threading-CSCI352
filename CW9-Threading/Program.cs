// Name: Zachary Rose
// Date: 3/2/2023
// Class: CSCI352
// Description: Uses threads and the Monte Carlo method to estimate pi using a random number generator. User inputs number of throws and threads to use. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CW9_Threading
{
    class FindPiThread
    {
        int dartsToThrow;
        int dartsHit;
        Random random;

        public FindPiThread(int dartsToThrow)
        {
            this.dartsToThrow = dartsToThrow;
            dartsHit = 0;
            random = new Random();
        }
        public int getDartsHit()
        {
            return dartsHit;
        }
        public void throwDarts()
        {
            double x, y;
            for (int i = 0; i < dartsToThrow; i++)
            {
                x = random.NextDouble();
                y = random.NextDouble();
                if (Math.Sqrt(x*x + y*y) <= 1)
                {
                    dartsHit++;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int throws, threads;
            Console.WriteLine("How many throws should each thread make: ");
            throws = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many threads should be used: ");
            threads = Int32.Parse(Console.ReadLine());

            List<Thread> threadList = new List<Thread>();
            List<FindPiThread> piThreads = new List<FindPiThread>();

            for (int i = 0; i < threads; i++)
            {
                FindPiThread piThread = new FindPiThread(throws);
                piThreads.Add(piThread);
                Thread thread = new Thread(new ThreadStart(piThread.throwDarts));
                threadList.Add(thread);

                thread.Start();
                Thread.Sleep(16);
            }
            foreach (Thread thread in threadList)
            {
                thread.Join();
            }
            int totalHits = 0;
            foreach (FindPiThread piThread in piThreads)
            {
                totalHits += piThread.getDartsHit(); 
            }

            Console.WriteLine("Estimation of pi: " + (double)4 * totalHits / throws / threads);
            Console.ReadKey();
        }
    }
}
