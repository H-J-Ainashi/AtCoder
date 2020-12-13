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

            const Questions question = Questions.D;

            switch (question)
            {
                case Questions.A:
                    var args1 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                    var args2 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                    Console.WriteLine(args1[0] * args2[1] - args1[1] * args2[0]);

                    break;
                case Questions.B:

                    var args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                    var str = Console.ReadLine().Select(x => x == 'o').ToArray();
                    foreach (var res in str)
                        if (res)
                            args[1]++;
                        else if (args[1] != 0)
                            args[1]--;

                    Console.WriteLine(args[1]);

                    break;
                case Questions.C:

                    var st = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                    var ed = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                    var dif_x = st[0] - ed[0];
                    var dif_y = st[1] - ed[1];

                    // 零手
                    if (dif_x == 0 && dif_y == 0)
                    {

                        Console.WriteLine(0);

                    }
                    // 初手
                    else if (Math.Abs(dif_x) + Math.Abs(dif_y) <= 3 || Math.Abs(dif_x) == Math.Abs(dif_y))
                    {

                        Console.WriteLine(1);
                        return;

                    }
                    // 二手
                    else if ((Math.Abs(dif_x) + Math.Abs(dif_y)) % 2 == 0 ||
                        Math.Abs(Math.Abs(dif_x) - Math.Abs(dif_y)) <= 3 || 
                        Math.Abs(dif_x) + Math.Abs(dif_y) <= 6)
                    {

                        Console.WriteLine(2);
                        return;

                    }
                    // 三手
                    else
                    {

                        Console.WriteLine(3);
                        return;

                    }


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
