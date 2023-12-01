using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG02_LinkedLists
{
    public class PG2Stack<T> 
    {

        private Node<T> _head;
        public int Count { get; private set; }


        public void Push(T data)
        {
            Node<T> node = new Node<T> { Data = data };
            node.Next = _head;
            _head = node;
            Count++;
        }


        public T Pop()
        {

            Node<T> node = _head;
            
            if (Count != 0)
            {

                _head = node.Next;
                Count--;

            }
            else throw new InvalidOperationException("List is Empty.");

            return node.Data;

        }


        public T Peek()
        {
            
            if (Count != 0)
            {
                return _head.Data;
            }
            else throw new InvalidOperationException("List is Empty.");

            
        }


        public void Reverse()
        {
            PG2Stack<T> RList = new PG2Stack<T> { _head = null };
            Node<T> cnode = new Node<T>();
            cnode = _head;
            Node<T> pnode = new Node<T>();
            pnode = null;
            Node<T> nnode = new Node<T>();
            nnode = null;
            while (cnode != null)
            {
                nnode = cnode.Next;
                cnode.Next = pnode;
                pnode = cnode;
                cnode = nnode;
            }
            _head = pnode;
             
            
         
        }

    }
}
