using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCore.LinkedList.SingleLinkedList
{
    public class MySingleLinkedList<T>
    {
        private Node<T> head;
        private int count;


        public int Count { get { return count; } }
        // 索引器
        public T this[int index]
        {
            get
            {
                return this.GetNodeByIndex(index).Item;
            }
            set
            {
                this.GetNodeByIndex(index).Item = value;
            }
        }

        public MySingleLinkedList()
        {
            this.count = 0;
            this.head = null;
        }
        private Node<T> GetNodeByIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出范围");
            }
            if (this.head == null)
            {
                return null;
            }
            Node<T> tempNode = this.head;
            for (int i = 0; i < index; i++)
            {
                tempNode = tempNode.Next;
            }

            return tempNode;
        }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> prevNode = this.GetNodeByIndex(this.count - 1);
                prevNode.Next = newNode;

            }
            this.count++;
        }

        public void Insert(int index, T value)
        {
            Node<T> newNode = null;
            if (index < 0 || index > this.count)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出范围");
            }
            else if (index == 0)
            {
                if (this.head == null)
                {
                    newNode = new Node<T>(value);
                    this.head = newNode;
                }
                else
                {
                    newNode = new Node<T>(value);
                    newNode.Next = this.head;//原头节点设置为新头结点->Next
                    this.head = newNode;//把头节点设为现在这个
                }

            }
            else
            {
                Node<T> prevNode = GetNodeByIndex(index - 1);
                newNode = new Node<T>(value);
                newNode.Next = prevNode.Next;//把现在node->next设置为prevNode->next
                prevNode.Next = newNode;//把prevNode->next设置为现在node
            }

            this.count++;

        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                this.head = this.head.Next;
            }
            else
            {
                Node<T> prevNode = GetNodeByIndex(index - 1);//获取需要删除的前节点
                if (prevNode.Next == null)
                {
                    throw new ArgumentOutOfRangeException("index", "索引超出范围");
                }

                Node<T> deleteNode = prevNode.Next;
                prevNode.Next = deleteNode.Next;//前节点的Next设置为删除后节点的->Next
                deleteNode = null;
            }

            this.count--;
        }






    }
}
