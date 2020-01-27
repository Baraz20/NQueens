using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace תרגיל_בגרות_תשעח
{
    class Program
    {
        public static int LastAndRemove(Stack<int> S)
        {
            Stack<int> Temp = new Stack<int>();
            while (!S.IsEmpty())
                Temp.Push(S.Pop());
            int NUM=Temp.Pop();
            while (!Temp.IsEmpty())
                S.Push(Temp.Pop());
            return NUM;
        }
        public static Stack<TwoItems> StackTwoItems(Stack<int> S)
        {
            Stack<int> temp = S.CopyS();
            Stack<TwoItems> sol = new Stack<TwoItems>();
            while (!temp.IsEmpty())
            {
                sol.Push(new TwoItems(temp.Pop(), LastAndRemove(temp)));
            }
            return sol;
        }
        static void Main(string[] args)
        {
            Stack<int> S = new Stack<int>();
            S.Push(9);
            S.Push(4);
            S.Push(7);
            S.Push(5);
            S.Push(5);
            S.Push(32);
            S.Push(6);
            S.Push(1);
            Console.WriteLine("S:"+S);
            Console.WriteLine("TwoItems:"+StackTwoItems(S));
        }
    }
}
