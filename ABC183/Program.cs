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
                        Console.WriteLine(Math.Max(0, int.Parse(Console.ReadLine())));
                    }
                    break;
                case Questions.B:
                    {
                        var args = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
                        var s_x = args[0];
                        var g_x = args[2];
                        var s_y = args[1];
                        var g_y = args[3];

                        Console.WriteLine((double)(s_x * g_y + g_x * s_y) / (s_y + g_y));
                    }
                    break;
                case Questions.C:
                    {
                        var args = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
                        var n = args[0];
                        var k = args[1];

                        var map = new long[n][];
                        for (int i = 0; i < n; i++)
                            map[i] = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

                        var buf_b = new bool[10];
                        for (int i = 0; i < 10; i++)
                            buf_b[i] = false;

                        Console.WriteLine(Solve(0, 0, 0, 0));

                        long Solve(int depth, int idx, int before, long sum)
                        {
                            if (depth == n - 1)
                            {
                                // 最終階層
                                if (sum + map[before][idx] + map[idx][0] == k)
                                    return 1;
                                else
                                    return 0;
                            }
                            else
                            {
                                // その他階層
                                sum += map[before][idx];
                                var res = 0L;
                                buf_b[idx] = true;
                                for (int i = 0; i < n; i++)
                                    if (!buf_b[i])
                                        res += Solve(depth + 1, i, idx, sum);
                                buf_b[idx] = false;

                                return res;
                            }
                        }

                    }
                    break;
                case Questions.D:
                    {
                        var args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        var n = args[0];
                        var w = args[1];
                        const int end_t = 2 * 100000 + 1;
                        var sum_rt = new long[end_t];
                        
                        for (int i = 0; i < end_t; i++)
                            sum_rt[i] = 0;

                        for (int i = 0; i < n; i++)
                        {

                            args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                            sum_rt[args[0]] += args[2];
                            sum_rt[args[1]] -= args[2];

                        }

                        var now_buf = sum_rt[0];

                        for (int i = 1; i < end_t; i++)
                        {
                            now_buf += sum_rt[i];
                            if (now_buf > w)
                            {
                                Console.WriteLine("No");
                                return;
                            }
                        }

                        Console.WriteLine("Yes");

                    }
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
