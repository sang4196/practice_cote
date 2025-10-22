using cs_prj.lv1._20251020;
using cs_prj.lv1._20251021;
using cs_prj.lv1._20251022;
using System;
using System.Globalization;



var solution = new _20251022_2();

//public class Solution
//{
//    public int FindBox(int n, int w, int num)
//    {
//        int answer = 1; // 자기 자신 포함

//        int rows = (n + w - 1) / w;

//        // num의 행, 열 계산
//        int row = (num - 1) / w;
//        int col = (num - 1) % w;

//        // 짝수 행은 왼→오, 홀수 행은 오→왼S
//        if (row % 2 == 1)
//        {
//            col = w - 1 - col;
//        }

//        // 아래쪽 행들 중 같은 열에 박스가 있는 개수 세기
//        for (int r = row + 1; r < rows; r++)
//        {
//            int index = r % 2 == 0
//                ? r * w + col + 1
//                : (r + 1) * w - col;

//            if (index <= n)
//                answer++;
//        }

//        return answer;
//    }

//    public int yu(int[] schedules, int[,] timelogs, int startday)
//    {
//        int answer = 0;

//        for (int e = 0; e < schedules.Length; e++)
//        {
//            int setup_hour = schedules[e] / 100;
//            int setup_minute = schedules[e] % 100 + 10;
//            if (setup_minute >= 60)
//            {
//                setup_hour += 1;
//                setup_minute -= 60;
//            }

//            bool perfect = true;
//            for (int w = 0; w < timelogs.GetLength(1); w++)
//            {
//                int today = startday + w;
//                if (today % 7 == 0 || today % 7 == 6) { continue; }

//                int real_hour = timelogs[e, w] / 100;
//                int real_minute = timelogs[e, w] % 100;

//                if ((real_hour > setup_hour) ||
//                    (real_hour == setup_hour && real_minute > setup_minute))
//                {
//                    perfect = false;
//                    break;
//                }
//            }
//            if (perfect) { answer++; }
//        }

//        return answer;
//    }

//    public string pccpNo1(string video_len, string pos, string op_start, string op_end, string[] commands)
//    {
//        string answer = "";

//        int pos_min = int.Parse(pos.Split(':')[0]);
//        int pos_sec = int.Parse(pos.Split(':')[1]);

//        CheckOp(ref pos_min, ref pos_sec, op_start, op_end);

//        for (int i = 0; i < commands.Length; i++)
//        {
//            switch (commands[i])
//            {
//                case "prev":
//                    pos_sec -= 10;
//                    break;
//                case "next":
//                    pos_sec += 10;
//                    break;
//            }
//            CheckOp(ref pos_min, ref pos_sec, op_start, op_end);
//            CheckStart(ref pos_min, ref pos_sec);
//            CheckEnd(ref pos_min, ref pos_sec, video_len);
//            CalcTime(ref pos_min, ref pos_sec);
//        }
//        answer = $"{pos_min.ToString().PadLeft(2, '0')}:{pos_sec.ToString().PadLeft(2, '0')}";
//        return answer;
//    }

//    public void CalcTime(ref int pos_min, ref int pos_sec)
//    {
//        if (pos_sec >= 60)
//        {
//            pos_min += pos_sec / 60;
//            pos_sec = pos_sec % 60;
//        }
//        else if (pos_sec < 0)
//        {
//            pos_min += pos_sec / 60;
//            pos_sec = pos_sec % 60;
//            if (pos_min < 0)
//            {
//                pos_min = 0;
//            }
//            if (pos_sec < 0)
//            {
//                if (pos_min > 0)
//                {
//                    pos_min -= 1;
//                    pos_sec += 60;
//                }
//                else
//                {
//                    pos_min = pos_sec = 0;
//                }
//            }

//        }
//    }

//    public void CheckStart(ref int pos_min, ref int pos_sec)
//    {
//        int check_min = pos_min;
//        int check_sec = pos_sec;
//        CalcTime(ref check_min, ref check_sec);

//        if (check_min > 0) return;
//        if (check_min == 0 && check_sec > 0) return;

//        pos_min = 0;
//        pos_sec = 0;
//    }

//    public void CheckEnd(ref int pos_min, ref int pos_sec, string video_len)
//    {
//        int check_min = pos_min;
//        int check_sec = pos_sec;
//        CalcTime(ref check_min, ref check_sec);
//        int videos_min = int.Parse(video_len.Split(':')[0]);
//        int videos_sec = int.Parse(video_len.Split(':')[1]);

//        if (check_min < videos_min) return;
//        if (check_min == videos_min && check_sec < videos_sec) return;

//        pos_min = videos_min;
//        pos_sec = videos_sec;
//    }

//    public void CheckOp(ref int pos_min, ref int pos_sec, string op_start, string op_end)
//    {
//        int check_min = pos_min;
//        int check_sec = pos_sec;
//        CalcTime(ref check_min, ref check_sec);
//        int op_start_min = int.Parse(op_start.Split(':')[0]);
//        int op_start_sec = int.Parse(op_start.Split(":")[1]);
//        int op_end_min = int.Parse(op_end.Split(':')[0]);
//        int op_end_sec = int.Parse(op_end.Split(":")[1]);

//        if (check_min < op_start_min) return;
//        if (check_min == op_start_min && check_sec < op_start_sec) return;
//        if (check_min > op_end_min) return;
//        if (check_min == op_end_min && check_sec > op_end_sec) return;

//        pos_min = op_end_min;
//        pos_sec = op_end_sec;
//    }
//    private int seonmul(string[] friends, string[] gifts)
//    {
//        int answer = 0;

//        for (int i = 0; i < friends.Length; i++)
//        {

//        }

//        return answer;
//    }

//    public static void Main(string[] args)
//    {
//        Solution sol = new Solution();

//        //// box
//        //int totalCount = 22;
//        //int columnW = 6;
//        //int getNum = 11;
//        //Console.WriteLine(sol.FindBox(totalCount, columnW, getNum)); 

//        //// 유연근무제
//        //int[] schedules = new int[] { 730, 855, 700, 720 };
//        //int[,] timelogs = new int[,] {
//        //    { 710, 700, 650, 735, 700, 931, 912 },
//        //    { 908, 901, 805, 815, 800, 831, 835 },
//        //    { 705, 701, 702, 705, 710, 710, 711 },
//        //    { 707, 731, 859, 913, 934, 931, 905 }
//        //};
//        //int startday = 1;
//        //Console.WriteLine(sol.yu(schedules, timelogs, startday));

//        //// PCCP 동영상 재생기
//        //string[] video_len = new string[] { "34:33", "10:55", "07:22" };
//        //string[] pos = new string[] { "13:00", "00:05", "04:05" };
//        //string[] op_start = new string[] { "00:55", "00:15", "00:15" };
//        //string[] op_end = new string[] { "02:55", "06:55", "04:07" };
//        //string[][] commands = new string[][] {
//        //    new string[] { "next", "prev" },
//        //    new string[] { "prev", "next", "next" },
//        //    new string[] { "next" }
//        //};
//        //int idx = 1;
//        //Console.WriteLine(sol.pccpNo1(video_len[idx], pos[idx], op_start[idx], op_end[idx], commands[idx]));

//        // 가장 많이 받은 선물
//        //string[][] friends = new string[][] {
//        //    new string[] { "muzi", "ryan", "frodo", "neo" },
//        //    new string[] { "joy", "brad", "alessandro", "conan", "david" },
//        //    new string[] { "a", "b", "c" },
//        //};
//        //string[][] gifts = new string[][]
//        //{
//        //    new string[] {"muzi frodo", "muzi frodo", "ryan muzi", "ryan muzi", "ryan muzi", "frodo muzi", "frodo ryan", "neo muzi" },
//        //    new string[] {"alessandro brad", "alessandro joy", "alessandro conan", "david alessandro", "alessandro david" },
//        //    new string[] {"a b", "b a", "c a", "a c", "a c", "c a" },
//        //};
//        //int idx = 0;
//        //Console.WriteLine(sol.seonmul(friends[idx], gifts[idx]));

//    }
//}