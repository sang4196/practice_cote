using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 성격 유형 검사하기 
 * https://school.programmers.co.kr/learn/courses/30/lessons/118666
 */

namespace cs_prj.lv1._20251110
{
    internal class _20251110_1
    {
        public _20251110_1()
        {
            string[][] survey = new string[][] {
                new string[] { "AN", "CF", "MJ", "RT", "NA" },
                new string[] { "TR", "RT", "TR" }
            };
            int[][] choices = new int[][] {
                new int[] { 5, 3, 2, 7, 5 },
                new int[] { 7, 1, 3 }
            };
            string[] result = new string[] { "TCMA", "RCJA" };

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Equals(solution(survey[i], choices[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        public string solution(string[] survey, int[] choices)
        {
            string answer = "";

            Dictionary<char, int> typeScores = new Dictionary<char, int>
            {
                {'R', 0}, {'T', 0},
                {'C', 0}, {'F', 0},
                {'J', 0}, {'M', 0},
                {'A', 0}, {'N', 0}
            };

            for (int i = 0; i < survey.Length; i++)
            {
                char firstType = survey[i][0];
                char secondType = survey[i][1];
                int choice = choices[i];
                if (choice < 4)
                {
                    typeScores[firstType] += 4 - choice;
                }
                else if (choice > 4)
                {
                    typeScores[secondType] += choice - 4;
                }
            }

            answer += typeScores['R'] >= typeScores['T'] ? 'R' : 'T';
            answer += typeScores['C'] >= typeScores['F'] ? 'C' : 'F';
            answer += typeScores['J'] >= typeScores['M'] ? 'J' : 'M';
            answer += typeScores['A'] >= typeScores['N'] ? 'A' : 'N';

            return answer;
        }
    }
}
