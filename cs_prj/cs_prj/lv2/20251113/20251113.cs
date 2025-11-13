using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 소수 찾기
 * https://school.programmers.co.kr/learn/courses/30/lessons/42839
 */

namespace cs_prj.lv2._20251113
{
    internal class _20251113
    {
        public _20251113()
        {
            string[] strings = new string[] { "17", "011" };
            int[] result = new int[] { 3, 2 };
            for (int i = 0; i < strings.Length; i++)
            {
                if (result[i] == solution(strings[i]))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
        HashSet<int> numberSet = new HashSet<int>();

        public int solution(string numbers)
        {
            int answer = 0;

            char[] chars = numbers.ToCharArray();
            Array.Sort(chars);
            Array.Reverse(chars);

            int max = int.Parse(new string(chars));
            bool[] isPrime = new bool[max + 1];
            isPrime[0] = isPrime[1] = true; // 0과 1은 소수가 아님
            HashSet<int> primeSet = new HashSet<int>();

            // 에라토스테네스의 체
            for (int i = 2; i * i <= max; i++)
            {
                if (!isPrime[i])
                {
                    for (int j = i * i; j <= max; j += i)
                    {
                        isPrime[j] = true;
                    }
                }
            }
            // 소수 집합 생성
            for (int i = 2; i <= max; i++)
            {
                if (!isPrime[i])
                {
                    primeSet.Add(i);
                }
            }
            // 모든 조합 생성 및 소수 판별
            numberSet = new HashSet<int>();
            GenerateNumbers("", numbers);
            foreach (var num in numberSet)
            {
                if (primeSet.Contains(num))
                {
                    answer++;
                }
            }

            return answer;
        }
        void GenerateNumbers(string current, string remaining)
        {
            if (current.Length > 0)
            {
                int num = int.Parse(current);
                numberSet.Add(num);
            }
            for (int i = 0; i < remaining.Length; i++)
            {
                GenerateNumbers(current + remaining[i], remaining.Substring(0, i) + remaining.Substring(i + 1));
            }
        }
    }
}
