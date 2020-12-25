using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCore.LinkedList.SingleLinkedList
{
    public class Node<T>
    {
        public T Item { get; set; }

        public Node<T> Next { get; set; }

        public Node() { }

        public Node(T value)
        {
            this.Item = value;
        }

    }
}
