using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace עמוד133
{
    class Program
    {
        public static bool IsSame(int Num, Stack<int> S)
        {
            Stack<int> Temp = S.CopyS();
            Stack<int> ReTemp =S.ReverseS();
            int TNum=Num;
            while (!Temp.IsEmpty())
	        {
                if (Temp.Top() == Num % 10 || ReTemp.Top() == Num % 10)
                {
                    Num = Num / 10;
                }
                else
                {
                    Num = TNum;
                }
                Temp.Pop();
                ReTemp.Pop();
                if (Num==0)
                {
                    return true;
                }
	        }
            return Num == 0;
        }
        public static bool IsSame1(int Num, Stack<int> S)
        {
            Stack<int> Temp = S.CopyS();
            int TNum = Num;
            while (!Temp.IsEmpty())
            {
                if (Temp.Top() == Num % 10)
                {
                    Num = Num / 10;
                }
                else
                {
                    Num = TNum;
                }
                Temp.Pop();
            }
            return Num == 0;
        }
        public static void Ex14()
        {
            Stack<int> S = new Stack<int>();
            S.Push(5);
            S.Push(8);
            S.Push(5);
            S.Push(1);
            S.Push(5);
            S.Push(3);
            S.Push(1);
            S.Push(5);
            S.Push(5);
            S.Push(8);
            Console.WriteLine(S);
            Console.WriteLine("IsSame:"+IsSame(158, S));
        }
        public static int PopMin(Stack<int> S)
        {
            int min = S.Top();
            Stack<int> temp = S.ReverseS();
            while (!S.IsEmpty())
            {
                if (S.Top()<min)
                {
                    min = S.Top();
                }
                S.Pop();
            }
            while (!temp.IsEmpty())
            {
                if (temp.Top()!=min)
                {
                    S.Push(temp.Top());
                }
                temp.Pop();
            }

            return min;
        }
        public static int RePopMin(Stack<int> S)
        {
            return RePopMin(S,S.Top(),1,new Stack<int>());
        }
        public static int RePopMin(Stack<int> S,int Min,int count,Stack<int> Temp)
        {
            if (count == 2 && Temp.IsEmpty())
            {
                return Min;
            }
            if (count == 1 && S.IsEmpty())
            {
                count = 2;
            }
            if (count == 1)
            {
                if (S.Top()<Min)
                {
                    Min = S.Top();
                }
                Temp.Push(S.Pop());
            }
            if (count==2)
            {
                if (Temp.Top()!=Min)
                {
                    S.Push(Temp.Top());
                }
                Temp.Pop();
            }
            return RePopMin(S, Min, count, Temp);
        }
        public static void SortS(Stack<int> S)
        {
            Stack<int> Temp = new Stack<int>();
            int len = S.StackLen();
            for (int i = 0;  i< len; i++)
            {
                Temp.Push(PopMin(S));
            }
            while (!Temp.IsEmpty())
            {
                S.Push(Temp.Pop());
            }
        }
        public static void Ex15()
        {
            Stack<int> S = new Stack<int>();
            S.Push(5);
            S.Push(9);
            S.Push(12);
            S.Push(7);
            S.Push(-45);
            S.Push(15);
            S.Push(-452);
            Console.WriteLine("S:"+S);
            Console.WriteLine("popmin:"+PopMin(S));
            Console.WriteLine("repopmin:"+RePopMin(S));
            Console.WriteLine("Now S:"+S);
            SortS(S);
            Console.WriteLine("Sorted S:"+S);
        }
        public static void Tranclate(string st)
        {
            Stack<char> S = new Stack<char>();
            string sol = "";
            while (st!="")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (st!="")
                    {
                        S.Push(st[0]);
                        st = st.Substring(1);
                    }
                }
                while (!S.IsEmpty())
                {
                    sol += S.Pop();
                }
            }
            Console.WriteLine("sol:"+sol);
        }
        public static void Ex16()
        {
            //hello my name is david
            //ollehn ym i emavad sdi
            Tranclate("ollehn ym i emavad sdi");
        }
        public static int MaxRezef(Stack<int> S)
        {
            Stack<int> Temp = S.ReverseS();
            int MaxRezef = 0;
            while (!Temp.IsEmpty())
            {
                
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
