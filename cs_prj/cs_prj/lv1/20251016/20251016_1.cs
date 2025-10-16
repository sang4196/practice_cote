using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 공원 산책
// https://school.programmers.co.kr/learn/courses/30/lessons/172928?language=csharp

namespace cs_prj.lv1._20251016
{
    public class _20251016_1
    {
        public _20251016_1()
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
                if (result[i].SequenceEqual(solution(park[i], routes[i])))
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
            // find start position
            int rowY = park.Length;
            int colX = park[0].Length;
            int currentRow = 0, currentCol = 0;
            for (int r = 0; r < rowY; r++)
            {
                for (int c = 0; c < colX; c++)
                {
                    if (park[r][c].Equals('S'))
                    {
                        currentRow = r;
                        currentCol = c;
                        goto findPos;
                    }
                }
            }
            findPos:

            foreach (string route in routes)
            {
                var parts = route.Split(' ');
                string wayType = parts[0];
                int stepCount = int.Parse(parts[1]);
                int step = (wayType.Equals("N") || wayType.Equals("W")) ? -1 : 1;
                int stepRow = 0, stepCol = 0;
                switch (wayType)
                {
                    case "N":
                        stepRow--;
                        break;
                    case "S":
                        stepRow++;
                        break;
                    case "W":
                        stepCol--;
                        break;
                    case "E":
                        stepCol++;
                        break;
                }
                bool isCol = (wayType.Equals("E") || wayType.Equals("W"));

                bool canGo = true;
                int moveRow = currentRow; // row
                int moveCol = currentCol; // col
                for (int i = 0; i < stepCount; i++)
                {
                    moveRow += stepRow;
                    moveCol += stepCol;
                    if (moveRow < 0 || moveCol < 0 || 
                        moveRow >= rowY || moveCol >= colX ||
                        park[moveRow][moveCol].Equals('X'))
                    {
                        canGo = false;
                        break;
                    }
                }
                if (canGo)
                {
                    currentRow = moveRow;
                    currentCol = moveCol;
                }
            }
            return new int[] { currentRow, currentCol};
        }
    }
}
