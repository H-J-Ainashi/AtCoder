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
                    break;
                case Questions.B:
                    break;
                case Questions.C:
                    {
                        var args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        var circle_l = args[0];
                        var home_n = args[1];

                        args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                        var max = args[0] + (circle_l - args[home_n - 1]);
                        for (int i = 0; i + 1 < home_n; i++)
                            max = Math.Max(max, args[i + 1] - args[i]);

                        Console.WriteLine(circle_l - max);

                    }
                    break;
                case Questions.D:
                    {
                        var args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        var n = args[0];
                        var x = args[1];
                        var y = args[2];
                        var ans1 = new int[n];
                        var ans2 = new int[n];
                        var l = 0;
                        for (int i = 0; i < n; i++)
                        {
                            ans1[i] = 0;
                            ans2[i] = 0;
                        }

                        for (int i = (n - 1) - x; 0 < i; i--)
                            ans1[i] = ans1[i + 1] + 1;

                        for (int i = 1; x + i < y || y + i < n; i++)
                        {
                            if (x + i < y)
                                ans2[i]++;
                            if (y + i <= n)
                                ans2[i + 1]++;
                            l++;
                        }
                        ans2[1]++;

                        for (int i = 0; i < x; i++)
                            for (int j = 1; j + ((x - 1) - i) < n; j++)
                                ans1[j + ((x - 1) - i)] += ans2[j];

                        for (int i = 1; i < x; i++)
                            ans1[i] += (x - i);

                        for (int i = 1; i < n; i++)
                            Console.WriteLine(ans1[i]);

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
