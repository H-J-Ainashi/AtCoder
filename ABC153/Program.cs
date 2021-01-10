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
                    {
                        var args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        Console.WriteLine((args[0] - 1) / args[1] + 1);
                    }
                    break;
                case Questions.B:
                    {
                        var args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        var enamy = args[0];
                        var num = args[1];
                        Console.WriteLine((Console.ReadLine().Split(' ').Select(x => long.Parse(x)).Sum() >= enamy ? "Yes" : "No"));
                    }
                    break;
                case Questions.C:
                    {
                        var args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        var enamy_n = args[0];
                        var killer_n = args[1];
                        var ans = 0L;
                        var enamies = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
                        Array.Sort(enamies);

                        for (int i = 0, l = enamy_n - killer_n; i < l; ++i)
                            ans += enamies[i];

                        Console.WriteLine(ans);
                    }
                    break;
                case Questions.D:
                    {
                        var num = long.Parse(Console.ReadLine());
                        var ans = 0;
                        for (; num != 0; ++ans, num >>= 1) ;
                        Console.WriteLine((1L << ans) - 1);
                    }
                    break;
                case Questions.E:
                    {
                        var args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        var enamy = args[0];
                        var num = args[1];
                        var magic = new int[num][];
                        var ans = int.MaxValue;

                        for (int i = 0; i < num; ++i)
                            magic[i] = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        
                        var length = enamy + magic.Select(x => x[1]).Max() + 5;
                        var minimum = new int[length];
                        
                        minimum[0] = 0;
                        for (int i = 1; i < length; ++i)
                            minimum[i] = -1;

                        for (int i = 0; i < enamy; ++i)
                            if (minimum[i] != -1)
                                for (int j = 0; j < num; ++j)
                                {
                                    var res = magic[j][1] + minimum[i];
                                    var k = magic[j][0] + i;
                                    if ((minimum[k] == -1) || (minimum[k] > res))
                                        minimum[k] = res;
                                }
                        for (int i = enamy; i < length; ++i)
                            if ((minimum[i] != -1) && (ans > minimum[i]))
                                ans = minimum[i];

                        Console.WriteLine(ans);

                    }
                    break;
                case Questions.F:
                    break;
                default:
                    break;
            }

        }
    }
}
