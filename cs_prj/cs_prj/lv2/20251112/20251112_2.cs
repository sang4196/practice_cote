using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


/*
 * 2개 이하로 다른 비트
 * https://school.programmers.co.kr/learn/courses/30/lessons/77885
 */

namespace cs_prj.lv2._20251112
{
    internal class _20251112_2
    {
        public _20251112_2()
        {
            long[] numbers = new long[] { 2, 7 };
            long[] result = new long[] { 3, 11 };

            if (result.SequenceEqual(solution(numbers)))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        public long[] solution(long[] numbers)
        {
            List<long> results = new List<long>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    results.Add(number + 1);
                    continue;
                }
                // 홀수일 때: 가장 낮은 자리의 0을 찾아서 바꾸는 방식
                long bit = 1;
                while ((number & bit) != 0)
                {
                    bit <<= 1;
                }
                results.Add(number + bit - (bit >> 1));

            }

            return results.ToArray();
        }
    }
}
