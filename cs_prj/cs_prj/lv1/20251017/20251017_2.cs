using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 덧칠하기
 * https://school.programmers.co.kr/learn/courses/30/lessons/161989
 */

namespace cs_prj.lv1._20251017
{
    internal class _20251017_2
    {
        public _20251017_2()
        {
            int[] n = new int[] { 8, 5, 4 };

            int[] m = new int[] { 4, 4, 1 };

            int[][] section = new int[][]
            {
                new int[] { 2, 3, 6},
                new int[] { 1, 3},
                new int[] { 1, 2, 3, 4},
            };

            int[] result = new int[] {1, 2, 4 };

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

            int [] result = new int[n];
            Array.Fill(result, 1);

            return answer;
        }
    }
}
