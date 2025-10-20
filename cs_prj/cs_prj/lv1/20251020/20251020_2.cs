using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_prj.lv1._20251020
{
    internal class _20251020_2
    {
        public _20251020_2()
        {
            string[][] keymap = new string[][]
            {
                new string[] { "ABACD", "BCEFD" },
                new string[] { "AA" },
                new string[] { "AGZ", "BSSS" },
            };

            string[][] targets = new string[][]
            {
                new string[] { "ABCD","AABB" },
                new string[] { "B" },
                new string[] { "ASA","BGZ" },
            };

            int[][] result = new int[][]
            {
                new int[] { 9, 4},
                new int[] { -1},
                new int[] { 4, 6},
            };

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].SequenceEqual(solution(keymap[i], targets[i])))
                //if (result[i].Equals(solution(keymap[i], targets[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        public int[] solution(string[] keymap, string[] targets)
        {
            int[] answer = new int[keymap.Length];

            var minDict = new Dictionary<char, int>();
            foreach (var key in keymap)
            {
                for (int i = 0; i < key.Length; i++)
                {
                    int press = i + 1;
                    char k = key[i];
                    if (!minDict.ContainsKey(k) || press < minDict[k])
                    {
                        minDict[k] = press;
                    }
                }
            }

            for (int i = 0; i < targets.Length; i++)
            {
                int pressCount = 0;
                bool isPossible = true;

                foreach (var c in targets[i])
                {
                    if (!minDict.TryGetValue(c, out int press))
                    {
                        isPossible = false;
                        break;
                    }
                    pressCount += press;
                }
                answer[i] = isPossible ? pressCount : -1;

            }

            return answer;
        }
    }
}
