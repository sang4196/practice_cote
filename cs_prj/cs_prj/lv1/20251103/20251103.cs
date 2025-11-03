using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 문자열 나누기
 * https://school.programmers.co.kr/learn/courses/30/lessons/140108
 */

namespace cs_prj.lv1._20251103
{
    internal class _20251103
    {
        public _20251103()
        {
            string[] s = new string[] {
                "banana",
                "abracadabra",
                "aaabbaccccabba"
            };

            int[] result = new int[] { 3, 6, 3 };

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Equals(solution(s[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        public int solution(string s)
        {
            int answer = 0;

            char? standard = null;
            int matchCount = 0;

            foreach (char c in s)
            {
                if (standard == null)
                {
                    standard = c;
                }

                if (c.Equals(standard))
                {
                    matchCount++;
                }
                else
                {
                    matchCount--;
                }

                if (matchCount == 0)
                {
                    standard = null;
                    answer++;
                    matchCount = 0;
                }
            }

            if (matchCount > 0)
            {
                answer++;
            }

            return answer;
        }
    }
}
