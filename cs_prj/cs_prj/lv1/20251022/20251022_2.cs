using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 숫자 문자열과 영단어
 * https://school.programmers.co.kr/learn/courses/30/lessons/81301
 */

namespace cs_prj.lv1._20251022
{
    internal class _20251022_2
    {
        public _20251022_2()
        {
            string[] s = new string[]
            {
                "one4seveneight",
                "23four5six7",
                "2three45sixseven",
                "123"
            };

            int[] result = new int[]
            {
                1478,
                234567,
                234567,
                123
            };

            for (int i = 0; i < result.Length; i++)
            {
                //if (result[i].SequenceEqual(solution(keymap[i], targets[i])))
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

            Dictionary<string, int> map = new Dictionary<string, int>
            {
                {"zero", 0 },
                {"one", 1 },
                {"two", 2 },
                {"three", 3 },
                {"four", 4 },
                {"five", 5 },
                {"six", 6 },
                {"seven", 7 },
                {"eight", 8 },
                {"nine", 9 },
            };

            foreach (var item in map.Keys)
            {
                if (s.Contains(item))
                {
                    s = s.Replace(item, map[item].ToString());
                }
            }
            answer = int.Parse(s);

            return answer;
        }
    }
}
