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
                    break;
                case Questions.B:
                    break;
                case Questions.C:
                    {
                        var num = int.Parse(Console.ReadLine());
                        var arr = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

                        var l = new long[num];
                        var r = new long[num];

                        l[0] = arr[0];
                        r[num - 1] = arr[num - 1];

                        for (int i = 1; i < num; ++i)
                            l[i] = GetGcd(l[i - 1], arr[i]);

                        for (int i = num - 2; 0 <= i; --i)
                            r[i] = GetGcd(r[i + 1], arr[i]);

                        var ans = r[1];
                        for (int i = 1, f = num - 1; i < f; ++i)
                            ans = Math.Max(ans, GetGcd(l[i - 1], r[i + 1]));
                        ans = Math.Max(ans, l[num - 2]);

                        Console.WriteLine(ans);

                        long GetGcd(long l, long r)
                            => __GetGcd(Math.Min(l, r), Math.Max(l, r));

                        long __GetGcd(long small, long large)
                            => (large % small == 0 ? small : __GetGcd(large % small, small));

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
