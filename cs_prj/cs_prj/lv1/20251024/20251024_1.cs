using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 신고 결과 받기
 * https://school.programmers.co.kr/learn/courses/30/lessons/92334
 */

namespace cs_prj.lv1._20251024
{
    internal class _20251024_1
    {
        public _20251024_1()
        {
            string[][] id_list = new string[][]
            {
                new string[] {"muzi", "frodo", "apeach", "neo" },
                new string[] {"con", "ryan" }
            };

            string[][] report = new string[][]
            {
                new string[] {"muzi frodo","apeach frodo","frodo neo","muzi neo","apeach muzi" },
                new string[] {"ryan con", "ryan con", "ryan con", "ryan con" }
            };

            int[] k = new int[] { 2, 3 };

            int[][] result = new int[][]
            {
                new int[] { 2,1,1,0 },
                new int[] { 0,0 }
            };

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].SequenceEqual(solution(id_list[i], report[i], k[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        public int[] solution(string[] id_list, string[] report, int k)
        {
            // 중복제거
            report = report.Distinct().ToArray();

            // 초기화
            Dictionary<string, int> mail = id_list.ToDictionary(s => s, s => 0);
            Dictionary<string, List<string>> reportMap = id_list.ToDictionary(s => s, s => new List<string>());

            foreach (string item in report)
            {
                var fromTo = item.Split(' ');
                reportMap[fromTo[1]].Add(fromTo[0]);
            }
            // 정지 필터
            reportMap = reportMap.Where(p=>p.Value.Count >= k).ToDictionary(p => p.Key, p => p.Value);

            // mail count
            foreach (var item in reportMap)
            {
                foreach (var from in item.Value)
                {
                    mail[from]++;
                }
            }

            return mail.Values.ToArray();
        }
    }
}
