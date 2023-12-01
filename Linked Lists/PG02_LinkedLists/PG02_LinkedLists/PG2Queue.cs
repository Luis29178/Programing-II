using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG02_LinkedLists
{
    public class PG2Queue<T> 
    {
        public int Count { get; private set; }
        Node<T> _head = new Node<T>();
        Node<T> _tail = new Node<T>();

        public void Enqueue(T data)
        {
            Node<T> node = new Node<T> { Data = data };
            
            if (Count == 0)
            {
                _head =  node;
                _tail = node;
                Count++;
                return;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
                Count++;
            }

        }

        public T Dequeue()
        {
            Node<T> node = new Node<T>();
            
            if(Count == 0)
            {
                throw new InvalidOperationException("Queue is Empty.");
            }
            node = _head;
            _head = _head.Next;
            if(_head == null)
            {
                _tail = null;
            }
            Count--;

            return node.Data;  
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("Queue is empty.");
            return _head.Data;
        }

        public void Reverse()
        {
            PG2Stack<T> RList = new PG2Stack<T>();
            
            while(Count != 0)
            {
               RList.Push(_head.Data);
                Dequeue();
            }
            while (RList.Count != 0)
            {
               Enqueue(RList.Peek());
                RList.Pop();
            }
            
            
           
        }


    }
}
