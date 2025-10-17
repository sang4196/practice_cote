using System;
using System.Collections.Generic;

/*
 * 바탕화면 정리
 * https://school.programmers.co.kr/learn/courses/30/lessons/161990
 */

namespace cs_prj.lv1._20251017
{
    public class _20251017_1
    {
        public _20251017_1()
        {
            string[][] wallpaper = new string[][]
            {
                new string[] { ".#...", "..#..", "...#." },
                new string[] { "..........", ".....#....", "......##..", "...##.....", "....#....." },
                new string[] { ".##...##.", "#..#.#..#", "#...#...#", ".#.....#.", "..#...#..", "...#.#...", "....#...." },
                new string[] { "..", "#." },
                new string[] { ".....", "....#" },
            };

            int[][] result = new int[][] {
                new int[] { 0, 1, 3, 4 },
                new int[] { 1, 3, 5, 8 },
                new int[] {0, 0, 7, 9 },
                new int[] {1, 0, 2, 1 },
                new int[] {1, 4, 2, 5},
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
            List<int> row = new List<int>();
            List<int> col = new List<int>();

            for (int r = 0; r < wallpaper.Length; r++)
            {
                for (int c = 0; c < wallpaper[r].Length; c++)
                {
                    if ((wallpaper[r][c].Equals('#')))
                    {
                        row.Add(r);
                        col.Add(c);
                    }
                }
            }

            return new int[] { row.Min(), col.Min(), row.Max() + 1, col.Max() + 1};
        }
    }
}
