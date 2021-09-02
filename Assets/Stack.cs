using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    public class Stack<T>
    {
        List<T> contents = new List<T>();
        //constructor
        public Stack()
        {

        }
        public int Count
        {
            get { return contents.Count; }
        }
        public void Push(T item)
        {
            contents.Add(item);
        }
        public T Pop()
        {
            if(contents.Count == 0)
            {
                throw new InvalidOperationException("Can't pop from the stack");
            }
            else
            {
                //get the top of the stack, remove and return

                T item = contents[contents.Count - 1];
                contents.RemoveAt(contents.Count - 1);
                return item;
            }
        }
        public T Peek()
        {
            if(contents.Count == 0)
            {
                throw new InvalidOperationException("Can't peek the stack");
            }
            else
            {
                return contents[contents.Count - 1];
            }
        }
    }
}

