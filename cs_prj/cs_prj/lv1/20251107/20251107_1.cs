using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
 * 체육복
 * https://school.programmers.co.kr/learn/courses/30/lessons/42862
 */

namespace cs_prj.lv1._20251107
{
    internal class _20251107_1
    {
        public _20251107_1()
        {
            int[] n = new int[] { 5, 5, 3 };
            int[][] lost = new int[][] {
                new int[] { 2,4 },
                new int[] { 2,4 },
                new int[] { 3 },
            };
            int[][] reserve = new int[][] {
                new int[] { 1,3,5 },
                new int[] { 3 },
                new int[] { 1 }
            };
            int[] result = new int[] { 5, 4, 2 };

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Equals(solution(n[i], lost[i], reserve[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        public int solution(int n, int[] lost, int[] reserve)
        {
            int[] student = new int[n];
            Array.Fill(student, 1);

            var realLost = lost.Except(reserve).ToArray();
            var reakReserve = reserve.Except(lost).ToArray();
            Array.Sort(realLost);
            Array.Sort(reakReserve);

            foreach (var i in realLost)
            {
                student[i - 1]--;
            }

            foreach (int i in reakReserve)
            {
                int idx = i - 1;

                if (idx > 0 && student[idx - 1] == 0)
                {
                    student[idx - 1]++;
                }
                else if (idx < n - 1 && student[idx + 1] == 0)
                {
                    student[idx + 1]++;
                }
            }
            return student.Count(s => s > 0);
        }
    }
}
