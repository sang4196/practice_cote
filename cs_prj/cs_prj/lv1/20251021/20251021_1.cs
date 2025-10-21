using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 카드 뭉치
 * https://school.programmers.co.kr/learn/courses/30/lessons/159994#
 */

namespace cs_prj.lv1._20251021
{
    internal class _20251021_1
    {
        public _20251021_1()
        {
            string[][] cards1 = new string[][]
            {
                new string[] { "i", "drink", "water" },
                new string[] { "i", "water", "drink" },
                new string[] { "i", "hate", "drink" },
            };

            string[][] cards2 = new string[][]
            {
                new string[] { "want", "to" },
                new string[] { "want", "to" },
                new string[] { "i", "want", "to", "drink", "water" },
            };

            string[][] goal = new string[][]
            {
                new string[] { "i", "want", "to", "drink", "water" },
                new string[] { "i", "want", "to", "drink", "water" },
                new string[] { "i", "want", "to", "drink", "water" },
            };

            string[] result = new string[]
            {
                "Yes",
                "No",
                "Yes"
            };

            for (int i = 0; i < result.Length; i++)
            {
                //if (result[i].SequenceEqual(solution(keymap[i], targets[i])))
                if (result[i].Equals(solution2(cards1[i], cards2[i], goal[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        /*
         * card1 = ["i", "hate", "drink"]
         * card2 = ["i", "want", "to", "drink", "water"]
         * goal = ["i", "want", "to", "drink", "water"]
         * yes여야 하지 않나..
         */
        public string solution(string[] cards1, string[] cards2, string[] goal)
        {
            Queue<string> q1 = new Queue<string>(cards1);
            Queue<string> q2 = new Queue<string>(cards2);

            foreach (var word in goal)
            {
                if (q1.Count > 0 && q1.Peek() == word)
                {
                    q1.Dequeue(); // cards1에서 꺼냄
                }
                else if (q2.Count > 0 && q2.Peek() == word)
                {
                    q2.Dequeue(); // cards2에서 꺼냄
                }
                else
                {
                    return "No"; // 둘 다 안 맞으면 실패
                }
            }
            return "Yes"; // 끝까지 만들 수 있으면 성공
        }

        public string solution2(string[] cards1, string[] cards2, string[] goal)
        {
            string answer = "Yes";

            List<Queue<string>> queue = new List<Queue<string>>();
            queue.Add(new Queue<string>(cards1));
            queue.Add(new Queue<string>(cards2));

            for (int g = 0; g < goal.Length; g++)
            {
                var item = goal[g];

                string word;
                int matchCount = 0;
                int matchIdx = -1;
                for (int i = 0; i < queue.Count; i++)
                {
                    if (!queue[i].TryPeek(out word))
                    {
                        continue;
                    }
                    if (item.Equals(word))
                    {
                        matchCount++;
                        matchIdx = i;
                    }
                }

                switch (matchCount)
                {
                    case 0:
                        return "No";
                    case 1:
                        queue[matchIdx].Dequeue();
                        break;
                    case 2: // 두 개의 큐에 같은 문자가 있을때
                        // 마지막 item이면 종료
                        if (g + 1 == goal.Length)
                        {
                            return "Yes";
                        }
                        // 큐의 2번째 값과 nextItem비교
                        string nextItem = goal[g + 1];
                        bool isMatch = false;
                        for (int i = 0; i < queue.Count; i++)
                        {
                            if (queue[i].Count > 1)
                            {
                                if (queue[i].ElementAt(1).Equals(nextItem))
                                {
                                    isMatch = true;
                                    queue[i].Dequeue();
                                    break;
                                }
                            }
                        }
                        if (!isMatch)
                            return "No";
                        break;
                }
            }

            return answer;
        }


    }
}
