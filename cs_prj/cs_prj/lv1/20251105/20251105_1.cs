using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 로또의 최고 순위와 최저 순위
 * https://school.programmers.co.kr/learn/courses/30/lessons/77484
 */

namespace cs_prj.lv1._20251105
{
    internal class _20251105_1
    {
        public _20251105_1()
        {
            int[][] lottos = new int[][] {
                new int[] {44, 1, 0, 0, 31, 25 },
                new int[] {0, 0, 0, 0, 0, 0},
                new int[] {45, 4, 35, 20, 3, 9 },
            };

            int[][] win_nums = new int[][] {
                new int[] {31, 10, 45, 1, 6, 19 },
                new int[] {38, 19, 20, 40, 15, 25 },
                new int[] {20, 9, 3, 45, 4, 35 },
            };

            int[][] result = new int[][] {
                new int[] {3, 5 },
                new int[] {1, 6 },
                new int[] {1,1 }
            };

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].SequenceEqual(solution(lottos[i], win_nums[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int extraCount = lottos.Count(p => p == 0);
            int matchCount = lottos.Count(p => win_nums.Contains(p) && p != 0);

            return new int[] {GetRank(matchCount + extraCount), GetRank(matchCount)};
        }

        public int GetRank(int match)
        {
            return match < 2 ? 6 : 7 - match;
        }
    }
}
