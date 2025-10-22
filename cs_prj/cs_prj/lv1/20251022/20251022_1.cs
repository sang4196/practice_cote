using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 둘만의 암호
 * https://school.programmers.co.kr/learn/courses/30/lessons/155652#
 */

namespace cs_prj.lv1._20251022

{
    internal class _20251022_1
    {
        public _20251022_1()
        {
            string[] s = new string[] { "aukks", "aukksx" };

            string[] skip = new string[] { "wbqd", "wbqdz" };

            int[] index = new int[] { 5, 5 };

            string[] result = new string[] { "happy", "hcppyf" };

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Equals(solution(s[i], skip[i], index[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        public string solution(string s, string skip, int index)
        {
            string answer = "";

            var skipSet = new HashSet<char>(skip);

            foreach (var item in s)
            {
                char c = item;
                int step = 0;

                while (step < index)
                {
                    c++;
                    if (c > 'z')
                    {
                        c = 'a';
                    }

                    if (!skipSet.Contains(c))
                    {
                        step++;
                    }
                }
                answer += c;
            }

            return answer;
        }
    }
}
