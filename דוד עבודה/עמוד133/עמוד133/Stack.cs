using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace עמוד133
{
    public class Stack<T>
    {
        private Node<T> first;

        public Stack()
        {
            this.first = null;
        }

        public bool IsEmpty()
        {
            return this.first == null;

        }

        public void Push(T x)
        {
            this.first = new Node<T>(x, this.first);
        }

        public T Pop()
        {
            T x = this.first.GetValue();
            this.first = this.first.GetNext();

            return x;
        }

        public T Top()
        {
            return this.first.GetValue();
        }
        public Stack<T> CopyS()
        {
            Stack<T> sol = new Stack<T>();
            Stack<T> temp = new Stack<T>();
            while (this.first != null)
            {
                temp.Push(this.first.GetValue());
                this.first = this.first.GetNext();
            }
            while (!temp.IsEmpty())
            {
                this.first = new Node<T>(temp.Top(), this.first);
                sol.Push(temp.Pop());
            }
            return sol;
        }
        public Stack<T> ReverseS()
        {
            Stack<T> temp = CopyS();
            Stack<T> sol = new Stack<T>();
            while (!temp.IsEmpty())
            {
                sol.Push(temp.Pop());
            }
            return sol;
        }
        public int StackLen()
        {
            int count = 0;
            Node<T> temp = this.first;
            while (temp!=null)
            {
                count++;
                temp = temp.GetNext();
            }
            return count;
        }
        public override string ToString()
        {
            string str = "[";

            Node<T> pos = this.first;
            while (pos != null)
            {
                str = str + pos.GetValue().ToString();
                if (pos.GetNext() != null)
                    str = str += ",";
                pos = pos.GetNext();
            }
            str = str + "]";
            return str;
        }

    }
}
