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

            const Questions question = Questions.E;

            switch (question)
            {
                case Questions.A:
                    break;
                case Questions.B:
                    break;
                case Questions.C:
                    break;
                case Questions.D:
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
