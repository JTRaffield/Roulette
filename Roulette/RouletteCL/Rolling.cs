using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteCL
{
//Names should be a little more desriptive of what is happening. (e.g. RollingWheel table1/ Bets placedBets)
    public class Result
    {
        public string Color { get; set; }
        public int Number { get; set; }
    }
    public class Rolling
    {

        public Result Wheel()

        {
//Work on separation of responsibility. The Rolling class could work like a constructor and hold the Properties, then you would not need
//to initialize the same things twice. (In the Program.cs and this file)
            Rolling Wheel = new Rolling();
            Bets bet = new Bets();
            Result result = new Result();
            string Input = "0";
            while (Input != "N")
            {
                Console.Clear();
                Console.WriteLine($"Welcome to roulette! Press any button to roll the wheel!");
                Console.ReadLine();
                Console.WriteLine($"Rolling the wheel!");
                Console.WriteLine($"");

                int[] AllNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38 };
                int[] Red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
                int[] Black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

                Random rand = new Random();
                var Number = rand.Next(1, AllNumbers.Length);
                if(Red.Any(x => x.Equals(Number)))
                {
                    result.Color = "Red";
                    result.Number = Number;
                }
                else
                {

                    result.Color = "Black";
                    result.Number = Number;
                }

                if (result.Number == 37)
                {
                    Console.WriteLine($"You landed on 0");
                    Console.ReadLine();
                }
                //else if
                if (result.Number == 38)
                {
                    Console.WriteLine($"You landed on 00");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"You landed on {result.Color} {result.Number}");
                    Console.ReadLine();
                    bet.Zeros(result);

                    Console.WriteLine($"would you like to roll agian?");
                    Console.WriteLine($"Y/N");
                    Input = Console.ReadLine();
                }

                if (Input == "Y")
                {
                    //Look for a way to make this selection code into a loop. Here It only goes through twice and thats it
                    Wheel.Wheel();
                }
                //else if or else
                if (Input == "N")
                {
                    Console.WriteLine($"Thanks for playing!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                return result;
            }

            return result;
        }
    }
}
