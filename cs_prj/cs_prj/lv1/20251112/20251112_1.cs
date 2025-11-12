using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 개인정보 수집 유효기간
 * https://school.programmers.co.kr/learn/courses/30/lessons/150370?language=csharp
 */

namespace cs_prj.lv1._20251112
{
    internal class _20251112_1
    {
        public _20251112_1()
        {
            string[] today = new string[] { "2022.05.19", "2020.01.01" };

            string[][] terms = new string[][] {
                new string[] { "A 6", "B 12", "C 3" },
                new string[] { "Z 3", "D 5" }
            };
            string[][] privacies = new string[][] {
                new string[] { "2021.05.02 A", "2021.07.01 B", "2022.02.19 C", "2022.02.20 C" },
                new string[] { "2019.01.01 Z", "2019.11.15 D", "2019.08.02 D", "2019.07.01 D" }
            };
            int[][] result = new int[][] {
                new int[] { 1, 3 },
                new int[] { 1, 4 }
            };
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].SequenceEqual(solution(today[i], terms[i], privacies[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
        public int[] solution(string today, string[] terms, string[] privacies)
        {
            int[] answer = new int[] { };
            DateTime todayDate = DateTime.ParseExact(today, "yyyy.MM.dd", CultureInfo.InvariantCulture);
            var termsDict = new Dictionary<string, int>();
            foreach (var term in terms)
            {
                var parts = term.Split(' ');
                termsDict[parts[0]] = int.Parse(parts[1]);
            }

            for (int i = 0; i < privacies.Length; i++)
            {
                var parts = privacies[i].Split(" ");
                DateTime startDate = DateTime.ParseExact(parts[0], "yyyy.MM.dd", CultureInfo.InvariantCulture);
                var type = parts[1];

                DateTime expiryDate = startDate.AddMonths(termsDict[type]).AddDays(-1);
                if (expiryDate < todayDate)
                {
                    answer = answer.Append(i + 1).ToArray();
                }
            }
            return answer;
        }
    }
}
