using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 햄버거 만들기
 * https://school.programmers.co.kr/learn/courses/30/lessons/133502
 */

namespace cs_prj.lv1._20251106
{
    internal class _20251106
    {
        public _20251106()
        {
            int[][] ingredient = new int[][]
            {
                new int[] { 2, 1, 1, 2, 3, 1, 2, 3, 1 },
                new int[] { 1, 3, 2, 1, 2, 1, 3, 1, 2 }
            };

            int[] result = new int[] { 2, 0 };

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Equals(solution(ingredient[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        public int solution(int[] ingredient)
        {
            int answer = 0;
            Stack<int> stack = new Stack<int>();

            foreach (var item in ingredient)
            {
                stack.Push(item);

                if (stack.Count >= 4)
                {
                    if (stack.Peek() == 1)
                    {
                        var burger = stack.Take(4).Reverse().ToArray();
                        if (burger[0] == 1 && burger[1] == 2 && burger[2] == 3 && burger[3] == 1)
                        {
                            stack.Pop();
                            stack.Pop();
                            stack.Pop();
                            stack.Pop();
                            answer++;
                        }
                    }
                }
            }
            return answer;
        }
    }
}
