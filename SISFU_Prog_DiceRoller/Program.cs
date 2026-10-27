using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISFU_Prog_DiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Dice[] d = new Dice[] { };
            int side = 0;
            int temp = 0;
            int total = 0;

            while (true)
            {
                d = new Dice[] { };
                side = 0;
                temp = 0;
                total = 0;


                while (d.Length <= 0)
                {
                    Console.WriteLine("How many dice would you like to roll? ");
                    d = new Dice[int.Parse(Console.ReadLine())];
                }

                while (side <= 0)
                {
                    Console.WriteLine("How many side die would you like to roll?\n\t[1] 4\n\t[2] 6\n\t[3] 8\n\t[4] 12\n\t[5] 20");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            side = 4;
                            break;
                        case 2:
                            side = 6;
                            break;
                        case 3:
                            side = 8;
                            break;
                        case 4:
                            side = 12;
                            break;
                        case 5:
                            side = 20;
                            break;
                        default:
                            side = -1;
                            break;
                    }
                }

                Console.WriteLine($"Rolling {d.Length}d{side}...");

                for (int x = 0; x < d.Length; x++)
                {
                    if (x != 0)
                        Console.Write(" + ");
                    d[x] = new Dice(side, rnd);
                    temp = d[x].Roll();
                    Console.Write(temp);
                    total += temp;
                }
                Console.WriteLine($" = {total}");

                Console.WriteLine("Type in 'q' to quit otherwise the program resets...");
                if (Console.ReadLine().ToLower() == "q")
                    break;
            }
        }
    }
}
