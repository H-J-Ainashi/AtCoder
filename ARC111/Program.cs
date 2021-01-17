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
                    {
                        var args = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
                        var n = args[0];
                        var m = args[1];
                        var m2 = m * m;
                        var ans = 1L;

                        for (long mod_m2 = 10; n != 0; n >>= 1)
                        {
                            if ((n & 1) != 0)
                            {
                                ans *= mod_m2;
                                ans %= m2;
                            }
                            mod_m2 *= mod_m2;
                            mod_m2 %= m2;
                        }

                        Console.WriteLine((ans / m) % m);

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
