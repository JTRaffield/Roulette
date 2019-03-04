using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteCL;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {

            Rolling Wheel = new Rolling();
            Result result =  Wheel.Wheel();
            Bets bets = new Bets();
            bets.Number(result);

            Console.ReadLine();

            /*string[] Red = { "1", "3", "5", "7", "9", "12", "14", "16", "18", "19", "21", "23", "25", "27", "30", "32", "34", "36" };
            string[] Black = { "2", "4", "6", "8", "10", "11", "13", "15", "17", "20", "22", "24", "26", "28", "29", "31", "33", "35" };
            string[] Green = { "0", "00" };*/

            /*int[] Red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] Black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] Green = { 0, 00 };*/
        }
    }
}
