using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

/*
 * 덧칠하기
 * https://school.programmers.co.kr/learn/courses/30/lessons/161989
 */

namespace cs_prj.lv1._20251020
{
    internal class _20251020_1
    {
        public _20251020_1()
        {
            int[] n = new int[] { 8, 5, 4 };

            int[] m = new int[] { 4, 4, 1 };

            int[][] section = new int[][]
            {
                new int[] { 2, 3, 6},
                new int[] { 1, 3},
                new int[] { 1, 2, 3, 4},
            };

            int[] result = new int[] {2, 1, 4 };

            for (int i = 0; i < result.Length; i++)
            {
                //if (result[i].SequenceEqual(solution(n[i], m[i], section[i])))
                if (result[i].Equals(solution(n[i], m[i], section[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        public int solution(int n, int m, int[] section)
        {
            int answer = 0;
            int painted = 0;

            foreach (int pos in section)
            {
                if (pos > painted)
                {
                    painted = pos + m - 1;
                    answer++;
                }
            }

            return answer;
        }
    }
}
