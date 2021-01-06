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
                    {
                        var args = Console.ReadLine().Split(' ').ToArray();
                        var s = args.Select(x => x.Select(y => int.Parse(y.ToString())).Sum());
                        Console.WriteLine(s.Max());
                    }
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
