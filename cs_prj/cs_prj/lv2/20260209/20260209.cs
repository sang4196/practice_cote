using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 다리를 지나는 트럭
 * https://school.programmers.co.kr/learn/courses/30/lessons/42583?language=csharp
 */
namespace cs_prj.lv2._20260209
{
    internal class _20260209
    {
        public _20260209()
        {
            int[] bridge_length = { 2, 100, 100 };
            int[] weight = { 10, 100, 100 };
            int[][] truck_weights = {
                new int[] {7,4,5,6},
                new int[] {10},
                new int[] {10,10,10,10,10,10,10,10,10,10}
            };
            int[] result = { 8, 101, 110 };

            for (int i = 0; i < bridge_length.Length; i++)
            {
                if (result[i] == solution(bridge_length[i], weight[i], truck_weights[i]))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int answer = 0;

            int min = 0;
            Queue<int> bridge = new Queue<int>();
            while (truck_weights.Length > 0 || bridge.Count > 0)
            {
                answer++;
                // 트럭 도착
                if (bridge.Count >= bridge_length)
                {
                    min -= bridge.Dequeue();
                }
                // 트럭 출발
                if (truck_weights.Length > 0 && min + truck_weights[0] <= weight)
                {
                    int truck = truck_weights[0];
                    truck_weights = truck_weights.Skip(1).ToArray();
                    min += truck;
                    bridge.Enqueue(truck);
                }
                else
                {
                    // Sum()사용하면 모든 원소를 순회. 느림.
                    //if (bridge.Sum() == 0) break;
                    if (min == 0) break;
                    answer--;
                    while (bridge.Count < bridge_length)
                    {
                        bridge.Enqueue(0); // 대기
                        answer++;
                    }
                }
            }

            return answer;
        }
    }
}