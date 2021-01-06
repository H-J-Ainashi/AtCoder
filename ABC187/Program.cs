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

            const Questions question = Questions.C;

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
