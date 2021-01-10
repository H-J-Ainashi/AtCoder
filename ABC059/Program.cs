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
                    break;
                case Questions.B:
                    {
                        var str_a = Console.ReadLine();
                        var str_b = Console.ReadLine();

                        if (str_a.Length != str_b.Length)
                            if (str_a.Length > str_b.Length)
                                Console.WriteLine("GREATER");
                            else
                                Console.WriteLine("LESS");
                        else
                            for (int i = 0, l = str_a.Length; i < l; ++i)
                                if (str_a[i] > str_b[i])
                                {
                                    Console.WriteLine("GREATER");
                                    break;
                                }
                                else if (str_a[i] < str_b[i])
                                {
                                    Console.WriteLine("LESS");
                                    break;
                                }
                                else if (i + 1 == l)
                                    Console.WriteLine("EQUAL");

                    }
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
