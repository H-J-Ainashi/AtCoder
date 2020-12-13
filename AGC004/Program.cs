using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtCoder
{

    class Program
    {
        enum Questions
        {
            A, B, C, D, E, F
        }

        static void Main()
        {

            const Questions question = Questions.A;

            switch (question)
            {
                case Questions.A:
                    var args = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
                    foreach (var arg in args)
                        if(arg % 2 == 0)
                        {

                            Console.WriteLine(0);
                            return;

                        }
                    Console.WriteLine(Math.Min(args[0] * args[1], Math.Min(args[1] * args[2], args[2] * args[0])));

                    break;
                case Questions.B:
                    break;
                case Questions.C:
                    break;
                case Questions.D:
                    break;
                case Questions.E:
                    break;
                case Questions.F:
                    break;
                default:
                    break;
            }

        }
    }
}
