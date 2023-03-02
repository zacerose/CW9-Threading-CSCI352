using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW9_Threading
{
    class FindPiThread
    {
        int dartsToThrow;
        int dartsHit;
        Random random;

        FindPiThread(int dartsToThrow)
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

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
