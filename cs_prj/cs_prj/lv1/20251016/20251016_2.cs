using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_prj.lv1._20251016
{
    public class _20251016_2
    {
        public _20251016_2()
        {
            string[][] wallpaper = new string[][]
            {
                new string[] { ".#...", "..#..", "...#." },
                new string[] { "..........", ".....#....", "......##..", "...##.....", "....#....." },
                new string[] { ".##...##.", "#..#.#..#", "#...#...#", ".#.....#.", "..#...#..", "...#.#...", "....#...." },
                new string[] { "..", "#." },
            };

            int[][] result = new int[][] {
                new int[] { 0, 1, 3, 4 },
                new int[] { 1, 3, 5, 8 },
                new int[] {0, 0, 7, 9 },
                new int[] {1, 0, 2, 1 },
            };

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].SequenceEqual(solution(wallpaper[i])))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
        public int[] solution(string[] wallpaper)
        {
            int[] answer = new int[] { };

            int startRow = 0, startCol = 0;
            int endRow = 0, endCol = 0;

            for (int r = 0; r<)

            return answer;
        }
    }
}
