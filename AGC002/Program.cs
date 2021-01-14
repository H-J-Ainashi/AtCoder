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

                        var args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        var num = args[0];
                        var que = args[1];

                        var num_ball = new int[num];
                        var ans = new bool[num];

                        for (int i = 0; i < num; ++i)
                        {
                            num_ball[i] = 1;
                            ans[i] = false;
                        }
                        ans[0] = true;

                        for (int i = 0; i < que; ++i)
                        {
                            var args_2 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                            var mov_from = args_2[0] - 1;
                            var mov_to = args_2[1] - 1;
                            
                            --num_ball[mov_from];
                            ++num_ball[mov_to];

                            if (ans[mov_from] == true)
                                ans[mov_to] = true;
                            if (num_ball[mov_from] == 0)
                                ans[mov_from] = false;
                            
                        }

                        Console.WriteLine(ans.Count(x => x));

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
