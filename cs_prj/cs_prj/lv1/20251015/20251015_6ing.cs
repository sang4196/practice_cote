using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_prj.lv1._20251015
{
    public class _20251015_6
    {
        public _20251015_6()
        {
            string[][] park = new string[][] { 
                new string[] { "SOO", "OOO", "OOO" },
                new string[] { "SOO","OXX","OOO" },
                new string[] { "OSO","OOO","OXO","OOO" },
            };
            string[][] routes = new string[][] { 
                new string[] { "E 2", "S 2", "W 1" },
                new string[] { "E 2","S 2","W 1" },
                new string[] { "E 2","S 3","W 1" },
            };
            int[][] result = new int[][] {
                new int[] { 2,1 },
                new int[] { 0,1 },
                new int[] { 0,0 },
            };

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == solution(park[i], routes[i]))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        public int[] solution(string[] park, string[] routes)
        {
            int[] answer = new int[] { };



            return answer;
        }
    }
}
