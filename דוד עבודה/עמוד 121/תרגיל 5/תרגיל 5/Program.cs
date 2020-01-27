using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace תרגיל_5
{
    class Program
    {
        public static bool memujan(Stack<int> S)
        {
            int F;
            Stack<int> Temp = S.CopyS();
            F = Temp.Top();
            Temp.Pop();
            while (!Temp.IsEmpty())
            {
                if (F>Temp.Top())
                {
                    return false;
                }
                F = Temp.Top();
                Temp.Pop();
            }
            return true;
        }
        public static Stack<int> circel( Stack<int> S)
        {
            Stack<int> temp = S.ReverseS();
            int save = temp.Pop();
            temp = temp.ReverseS();
            temp.Push(save);
            return temp;
        }
        public static string Back(Stack<string> S)
        { 
            Stack<string> temp=S.CopyS();
            temp.Pop();
            if (temp.Top()!=null)
            {
                return temp.Top();
            }
            return "";
        }
        public static string Back(Stack<string> S, int X)
        {
            Stack<string> temp = S.CopyS();
            for (int i = 0; i < X; i++)
            {
                if (temp.Top()==null)
                {
                    return "";
                }
                temp.Pop();
            }
            return temp.Top();
        }
        public static bool IsExist(int num, Stack<int> S)
        {
            Stack<int> temp = S.CopyS();
            while (!temp.IsEmpty())
            {
                if (temp.Pop()==num)
                {
                    return true;
                }
            }
            return false;
        }
        public static int LenS(Stack<int> S)
        {
            int count = 0;
            Stack<int> temp = S.CopyS();
            while (!temp.IsEmpty())
            {
                count++;
                temp.Pop();
            }
            return count;
        }
        public static bool IsSame(Stack<int> S1, Stack<int> S2)
        {
            if (LenS(S1)!=LenS(S2))
            {
                return false;
            }
            Stack<int> temp = S1.CopyS();
            while (!temp.IsEmpty())
            {
                if (!IsExist(temp.Pop(),S2))
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Stack<int> S = new Stack<int>();
            S.Push(89);
            S.Push(56);
            S.Push(45);
            S.Push(23);
            S.Push(2);
            Console.WriteLine("S:"+S);
            Console.WriteLine("Ex5:"+memujan(S));
            Console.WriteLine("Ex6:"+circel(S));
            Stack<string> path = new Stack<string>();
            path.Push("www.google.com");
            path.Push("www.bentaihaven.com");
            path.Push("www.cornhub.com");
            path.Push("www.youtube.com");
            path.Push("www.real-waifu.com");
            Console.WriteLine("path:"+path.Top());
            Console.WriteLine("back:"+Back(path));
            Console.WriteLine("back3:"+Back(path,3));
            Stack<int> S2 = new Stack<int>();
            S2.Push(23);
            S2.Push(89);
            S2.Push(45);
            S2.Push(2);
            S2.Push(56);
            Console.WriteLine("S2:"+S2+" IsSame:"+IsSame(S,S2));

        }
    }
}
