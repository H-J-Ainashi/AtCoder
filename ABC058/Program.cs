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
                    var args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                    var a = args[0];
                    var b = args[1];
                    var c = args[2];
                    Console.WriteLine((b - a == c - b ? "YES" : "NO"));
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
