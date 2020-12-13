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

            const Questions question = Questions.B;

            switch (question)
            {
                case Questions.A:

                    var args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                    var a = args[0];
                    var b = args[1];
                    var path = args[2];
                    var steer = args[3];

                    Console.WriteLine((Math.Abs(2 * b + 1 - 2 * a) >> 1) * Math.Min(2 * path, steer) + path);

                    break;
                case Questions.B:

                    var num = long.Parse(Console.ReadLine());
                    long l = 0, r = (long)2e9;

                    while (r - l > 1)
                    {
                        long m = (l + r) / 2;
                        if ((m * (m + 1)) / 2 <= num + 1) l = m;
                        else r = m;
                    }

                    Console.WriteLine(num - l + 1);

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
