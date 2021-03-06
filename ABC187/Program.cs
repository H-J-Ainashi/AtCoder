﻿using System;
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
                        var args = Console.ReadLine().Split(' ').ToArray();
                        var s = args.Select(x => x.Select(y => int.Parse(y.ToString())).Sum());
                        Console.WriteLine(s.Max());
                    }
                    break;
                case Questions.B:
                    {
                        var num = int.Parse(Console.ReadLine());
                        var x = new int[num][];
                        var ans = 0;
                        for (int i = 0; i < num; ++i)
                            x[i] = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                        for (int i = 0; i < num; ++i)
                            for (int j = i + 1; j < num; ++j)
                                if (Math.Abs(x[i][0] - x[j][0]) >= Math.Abs(x[i][1] - x[j][1]))
                                    ans++;

                        Console.WriteLine(ans);
                    }
                    break;
                case Questions.C:
                    {
                        var num = int.Parse(Console.ReadLine());
                        var dic = new Dictionary<string, int>();
                        for (int i = 0; i < num; ++i)
                        {
                            var str = Console.ReadLine();
                            var add = (str[0] == '!' ? 1 : 2);
                            var word = (str[0] == '!' ? str.Substring(1) : str);
                            if (dic.ContainsKey(word))
                                dic[word] = dic[word] | add;
                            else
                                dic[word] = add;
                        }

                        foreach (var item in dic)
                            if (item.Value == 3)
                            {
                                Console.WriteLine(item.Key);
                                return;
                            }
                        Console.WriteLine("satisfiable");
                    }
                    break;
                case Questions.D:
                    {

                        var num = int.Parse(Console.ReadLine());

                        var difference = 0L;
                        var point = new long[num];
                        for (int i = 0; i < num; ++i)
                        {
                            var args = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
                            difference -= args[0];
                            point[i] = args[0] + args[0] + args[1];
                        }

                        Array.Sort(point);
                        for (int i = 1; i <= num; ++i)
                        {
                            difference += point[num - i];
                            if (difference > 0)
                            {
                                Console.WriteLine(i);
                                return;
                            }
                        }


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
