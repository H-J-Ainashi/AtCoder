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
            int[] args;

            switch (question)
            {
                case Questions.A:
                    args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                    if (args[0] == 2 || args[1] == 2)
                        Console.WriteLine("No");
                    else
                        Console.WriteLine("Yes");
                    break;
                case Questions.B:
                    {

                        var n = int.Parse(Console.ReadLine());
                        string[] str = new string[n];
                        var ans = true;
                        for (int i = 0; i < n; ++i)
                        {
                            str[i] = Console.ReadLine();
                            if (ans)
                                if (i > 0)
                                    if (str[i][0] != str[i - 1][str[i - 1].Length - 1])
                                        ans = false;
                                    else
                                        for (int j = 0; j < i; ++j)
                                            if (str[j] == str[i])
                                                ans = false;
                        }
                        Console.WriteLine((ans ? "Yes" : "No"));
                        return;
                    }
                    break;
                case Questions.C:
                    {

                        args = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        int n = args[0], x = args[1];
                        var data = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
                        data.Add(x);
                        data.Sort();

                        var ans = data[1] - data[0];
                        for (int i = 2; i <= n; ++i)
                            ans = Gcd(ans, data[i] - data[i - 1]);

                        Console.WriteLine(ans);

                        int Gcd(int a, int b)
                        {
                            if (a <= b)
                                return (b % a == 0 ? a : Gcd(b % a, a));
                            else
                                return Gcd(b, a);
                        }
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
