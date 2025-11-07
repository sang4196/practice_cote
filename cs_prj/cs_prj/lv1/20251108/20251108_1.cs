using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_prj.lv1._20251108
{
    internal class _20251108_1
    {
        public _20251108_1()
        {
            string[] X = new string[]
            {
                "100",
                "100",
                "100",
                "12321",
                "5525",
            };

            string[] Y = new string[]
            {
                "2345",
                "203045",
                "123450",
                "42531",
                "1255",
            };

            string[] result = new string[] { "-1", "0", "10", "321", "552" };

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Equals(solution(X[i], Y[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        public string solution(string X, string Y)
        {
            string answer = "";
            char[] x = X.OrderBy(x => x).ToArray();
            char[] y = Y.OrderBy(y => y).ToArray();
            var xDic = new Dictionary<char, int>();
            var yDic = new Dictionary<char, int>();

            foreach (var c in x.Distinct())
            {
                xDic[c] = X.Count(ch => ch == c);
            }
            foreach (var c in y.Distinct())
            {
                yDic[c] = Y.Count(ch => ch == c);
            }

            for (char c = '9'; c >= '0'; c--)
            {
                if (xDic.ContainsKey(c) && yDic.ContainsKey(c))
                {
                    int count = Math.Min(xDic[c], yDic[c]);
                    answer += new string(c, count);
                }
            }

            if (string.IsNullOrEmpty(answer))
            {
                return "-1";
            }
            else if (answer.All(a => a == '0'))
            {
                return "0";
            }

            return answer;
        }
    }
}
