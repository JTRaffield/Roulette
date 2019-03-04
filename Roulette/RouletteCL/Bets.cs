using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace RouletteCL
{
    public class Bets
    {
        int[] ColunmOne = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        int[] ColunmTwo = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        int[] ColunmThree = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };


        public void Zeros(Result result)
        {
            Bets bet = new Bets();
            Rolling Roll = new Rolling();
            if (result.Number == 37)
            {
                Console.WriteLine($"You won 0");
                Console.ReadLine();
                Roll.Wheel();
            }
            if (result.Number == 38)
            {
                Console.WriteLine($"You won 00");
                Console.ReadLine();
                Roll.Wheel();
            }
            else
            {
                bet.Number(result);
            }

        }

        public void Number(Result result)
        {
            Bets bet = new Bets();
            Console.WriteLine($"You won {result.Number}");

            bet.EvenOdds(result);
        }

        public void EvenOdds(Result result)
        {
            Bets bet = new Bets();
            if (result.Number % 2 == 0)
            {
                Console.WriteLine($"You won even");

            }
            else
            {
                Console.WriteLine($"You won odds");

            }

            bet.Color(result);
        }

        public void Color(Result result)
        {
            Bets bet = new Bets();
            Console.WriteLine($"You won {result.Color}");

            bet.LowsHighs(result);
        }

        public void LowsHighs(Result result)
        {
            Bets bet = new Bets();
            if (result.Number <= 18)
            {
                Console.WriteLine($"You won lows 1 - 18");

            }
            else
            {
                Console.WriteLine($"You won highs 19 - 36");

            }
            bet.Dozens(result);
        }

        public void Dozens(Result result)
        {
            Bets bet = new Bets();
            if (result.Number <= 12)
            {
                Console.WriteLine($"You won 1 - 12 dozens");

            }
            if (result.Number >= 13 && result.Number <= 24)

            {
                Console.WriteLine($"You won 13 - 24 dozens");

            }
            if (result.Number >= 25)
            {
                Console.WriteLine($"You won 25 - 36 dozens");

            }
            bet.Colunms(result);
        }

        public void Colunms(Result result)
        {
            Bets bet = new Bets();

            if (ColunmOne.Any(x => x.Equals(result.Number)))
            {
                Console.WriteLine($"You won first column (1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34)");
            }
            if (ColunmTwo.Any(x => x.Equals(result.Number)))
            {
                Console.WriteLine($"You won second column (2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35)");
            }
            if (ColunmThree.Any(x => x.Equals(result.Number)))
            {
                Console.WriteLine($"You won third column (3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36)");
            }

            bet.Streets(result);
        }

        public void Streets(Result result)
        {
            Bets bet = new Bets();
            for (int i = 0; i < ColunmOne.Length; i++)
            {
                if (result.Number == ColunmOne[i])
                {
                    Console.WriteLine($"You won street : {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]}");
                }
            }
            for (int i = 0; i < ColunmTwo.Length; i++)
            {
                if (result.Number == ColunmTwo[i])
                {
                    Console.WriteLine($"You won street : {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]}");
                }
            }
            for (int i = 0; i < ColunmThree.Length; i++)
            {
                if (result.Number == ColunmThree[i])
                {
                    Console.WriteLine($"You won street : {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]}");
                }
            }
            bet.Doubles(result);
        }

        public void Doubles(Result result)
        {
            Bets bet = new Bets();

            for (int i = 0; i < ColunmOne.Length; i++)
            {
                if (result.Number == ColunmOne[i])
                {
                    if (result.Number == 1)
                    {
                        Console.WriteLine($"You won double rows : {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]}, {ColunmOne[i] + 3}, {ColunmTwo[i] + 3}, {ColunmThree[i] + 3}");
                    }
                    else if (result.Number == 34)
                    {
                        Console.WriteLine($"You won double rows : {ColunmOne[i] - 3}, {ColunmTwo[i] - 3}, {ColunmThree[i] - 3} {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]} ");
                    }
                    else
                    {
                        Console.WriteLine($"You won double rows : {ColunmOne[i] - 3}, {ColunmTwo[i] - 3}, {ColunmThree[i] - 3} {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]} and {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]}, {ColunmOne[i] + 3}, {ColunmTwo[i] + 3}, {ColunmThree[i] + 3}");
                    }

                }
            }
            for (int i = 0; i < ColunmTwo.Length; i++)
            {
                if (result.Number == ColunmTwo[i])
                {
                    if (result.Number == 2)
                    {
                        Console.WriteLine($"You won double rows : {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]}, {ColunmOne[i] + 3}, {ColunmTwo[i] + 3}, {ColunmThree[i] + 3}");
                    }
                    else if (result.Number == 35)
                    {
                        Console.WriteLine($"You won double rows : {ColunmOne[i] - 3}, {ColunmTwo[i] - 3}, {ColunmThree[i] - 3} {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]} ");
                    }
                    else
                    {
                        Console.WriteLine($"You won double rows : {ColunmOne[i] - 3}, {ColunmTwo[i] - 3}, {ColunmThree[i] - 3} {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]} and {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]}, {ColunmOne[i] + 3}, {ColunmTwo[i] + 3}, {ColunmThree[i] + 3}");
                    }
                }
            }
            for (int i = 0; i < ColunmThree.Length; i++)
            {
                if (result.Number == ColunmThree[i])
                {
                    if (result.Number == 3)
                    {
                        Console.WriteLine($"You won double rows : {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]}, {ColunmOne[i] + 3}, {ColunmTwo[i] + 3}, {ColunmThree[i] + 3}");
                    }
                    else if (result.Number == 36)
                    {
                        Console.WriteLine($"You won double rows : {ColunmOne[i] - 3}, {ColunmTwo[i] - 3}, {ColunmThree[i] - 3} {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]} ");
                    }
                    else
                    {
                        Console.WriteLine($"You won double rows : {ColunmOne[i] - 3}, {ColunmTwo[i] - 3}, {ColunmThree[i] - 3} {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]} and {ColunmOne[i]}, {ColunmTwo[i]}, {ColunmThree[i]}, {ColunmOne[i] + 3}, {ColunmTwo[i] + 3}, {ColunmThree[i] + 3}");
                    }
                }
            }
            bet.Split(result);
        }

        public void Split(Result result)
        {
            Bets bet = new Bets();
            for (int i = 0; i < ColunmOne.Length; i++)
            {
                if (result.Number == ColunmOne[i])
                {
                    if (result.Number == 1)
                    {
                        Console.WriteLine($"You won splits : {ColunmOne[i]}, {ColunmOne[i] + 1} and {ColunmOne[i]}, {ColunmOne[i] + 3}");
                    }
                    else if (result.Number == 34)
                    {
                        Console.WriteLine($"You won splits : {ColunmOne[i]}, {ColunmOne[i] - 3} and {ColunmOne[i]}, {ColunmOne[i] + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"You won splits : {ColunmOne[i]}, {ColunmOne[i] - 3} and {ColunmOne[i]}, {ColunmOne[i] + 1} and {ColunmOne[i]}, {ColunmOne[i] + 3}  ");
                    }


                }
            }
            for (int i = 0; i < ColunmTwo.Length; i++)
            {
                if (result.Number == ColunmTwo[i])
                {
                    if (result.Number == 2)
                    {
                        Console.WriteLine($"You won splits : {ColunmTwo[i]}, {ColunmTwo[i] - 1} and {ColunmTwo[i]}, {ColunmTwo[i] + 1} and {ColunmTwo[i]}, {ColunmTwo[i] + 3}  ");
                    }
                    else if (result.Number == 35)
                    {
                        Console.WriteLine($"You won splits : {ColunmTwo[i]}, {ColunmTwo[i] - 1} and {ColunmTwo[i]}, {ColunmTwo[i] - 3} and {ColunmTwo[i]}, {ColunmTwo[i] + 1}  ");
                    }
                    else
                    {
                        Console.WriteLine($"You won splits : {ColunmTwo[i]}, {ColunmTwo[i] - 3} and {ColunmTwo[i]}, {ColunmTwo[i] - 1} and {ColunmTwo[i]}, {ColunmTwo[i] + 1} and {ColunmTwo[i] + 3}  ");
                    }

                }
            }
            for (int i = 0; i < ColunmThree.Length; i++)
            {
                if (result.Number == ColunmThree[i])
                {
                    if (result.Number == 3)
                    {
                        Console.WriteLine($"You won splits : {ColunmThree[i]}, {ColunmThree[i] - 1} and {ColunmThree[i]}, {ColunmThree[i] + 3}");
                    }
                    else if (result.Number == 36)

                        Console.WriteLine($"You won splits : {ColunmThree[i]}, {ColunmThree[i] - 3} and {ColunmThree[i]}, {ColunmThree[i] - 1}");

                    else
                    {
                        Console.WriteLine($"You won splits : {ColunmThree[i]}, {ColunmThree[i] - 3} and {ColunmThree[i]}, {ColunmThree[i] - 1} and {ColunmThree[i]}, {ColunmOne[i] + 3}  ");
                    }
                }
            }
            bet.Corner(result);
        }

        public void Corner(Result result)
        {
            for (int i = 0; i < ColunmOne.Length; i++)
            {
                if (result.Number == ColunmOne[i])
                {
                    if (result.Number == 1)
                    {
                        Console.WriteLine($"You won corner : {ColunmOne[i]}, {ColunmOne[i] + 1}, {ColunmOne[i] + 3}, {ColunmOne[i] + 4}");
                    }
                    else if (result.Number == 34)
                    {
                        Console.WriteLine($"You won corner : {ColunmOne[i]}, {ColunmOne[i] - 3}, {ColunmOne[i] - 2}, {ColunmOne[i] + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"You won corner : {ColunmOne[i] - 3}, {ColunmOne[i] - 2}, {ColunmOne[i]}, {ColunmOne[i] + 1} and {ColunmOne[i]}, {ColunmOne[i] + 1}, {ColunmOne[i] + 3}, {ColunmOne[i] + 4}");
                    }

                }

            }
            for (int i = 0; i < ColunmTwo.Length; i++)
            {
                if (result.Number == ColunmTwo[i])
                {
                    if (result.Number == 2)
                    {
                        Console.WriteLine($"You won corner : {ColunmTwo[i] - 1}, {ColunmTwo[i]}, {ColunmTwo[i] + 2}, {ColunmTwo[i] + 3} and {ColunmTwo[i]}, {ColunmTwo[i] + 1}, {ColunmTwo[i] + 3}, {ColunmTwo[i] + 4} ");
                    }
                    else if (result.Number == 35)
                    {
                        Console.WriteLine($"You won corner : {ColunmTwo[i] - 4}, {ColunmTwo[i] - 3}, {ColunmTwo[i] - 1}, {ColunmTwo[i]} and {ColunmTwo[i] - 3}, {ColunmTwo[i] - 2}, {ColunmTwo[i]}, {ColunmTwo[i] + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"You won corner : {ColunmTwo[i] - 4}, {ColunmTwo[i] - 3}, {ColunmTwo[i] - 1}, {ColunmTwo[i]} and {ColunmTwo[i] - 3}, {ColunmTwo[i] - 2}, {ColunmTwo[i]}, {ColunmTwo[i] + 1} and {ColunmTwo[i] - 1}, {ColunmTwo[i]}, {ColunmTwo[i] + 2}, {ColunmTwo[i] + 3} and {ColunmTwo[i]}, {ColunmTwo[i] + 1}, {ColunmTwo[i] + 3}, {ColunmTwo[i] + 4}");
                    }
                }
            }
            for (int i = 0; i < ColunmThree.Length; i++)
            {
                if (result.Number == ColunmThree[i])
                {
                    if (result.Number == 3)
                    {
                        Console.WriteLine($"You won corner : {ColunmThree[i] - 1}, {ColunmThree[i]}, {ColunmThree[i] + 2}, {ColunmThree[i] + 3}");
                    }
                    else if (result.Number == 36)
                    {
                        Console.WriteLine($"You won corner : {ColunmThree[i] - 3}, {ColunmThree[i] - 2}, {ColunmThree[i] - 1}, {ColunmThree[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"You won corner : {ColunmThree[i] - 4}, {ColunmThree[i] - 3}, {ColunmThree[i] - 1}, {ColunmThree[i]} and {ColunmThree[i] - 1}, {ColunmThree[i]}, {ColunmThree[i] + 2}, {ColunmThree[i] + 3}");
                    }
                }
            }
        }
    }
}
