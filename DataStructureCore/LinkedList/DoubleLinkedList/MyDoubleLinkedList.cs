using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCore.LinkedList.DoubleLinkedList
{
    public class MyDoubleLinkedList<T>
    {
        private int count;
        private DbNode<T> head;//当前链表头结点

        /// <summary>
        /// 当前链表节点个数
        /// </summary>
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.getNodeByIndex(index).Item;
            }
            set
            {
                this.getNodeByIndex(index).Item = value;
            }
        }

        public MyDoubleLinkedList()
        {
            this.count = 0;
            this.head = null;
        }

        // Method01:根据索引获取节点
        private DbNode<T> getNodeByIndex(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出范围");
            }
            DbNode<T> tempNode = this.head;

            for (int i = 0; i < index; i++)
            {
                tempNode = tempNode.Next;
            }
            return tempNode;
        }

        /// <summary>
        ///  设置节点为前后关系
        /// </summary>
        /// <param name="prevNode">前节点</param>
        /// <param name="afterNode">后节点</param>
        private void setNode(DbNode<T> prevNode, DbNode<T> afterNode)
        {
            prevNode.Next = afterNode;


            if (afterNode != null)
            {
                afterNode.Prev = prevNode;
            }
        }
        // Method02:在尾节点后插入新节点
        public void AddAfter(T value)
        {
            DbNode<T> newNode = new DbNode<T>(value);

            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {

                DbNode<T> lastNode = this.getNodeByIndex(this.count - 1);
                setNode(lastNode, newNode);
            }
            this.count++;
        }
        // Method03:在尾节点前插入新节点
        public void AddBefore(T value)
        {
            DbNode<T> newNode = new DbNode<T>(value);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                DbNode<T> lastNode = this.getNodeByIndex(this.count - 1);
                DbNode<T> prevNode = lastNode.Prev;

                setNode(prevNode, newNode);
                setNode(newNode, lastNode);

            }
            this.count++;

        }
        // Method04:在指定位置后插入新节点
        public void InsertAfter(int index, T value)
        {
            DbNode<T> tempNode;

            if (index == 0)
            {
                if (this.head == null)
                {
                    tempNode = new DbNode<T>(value);
                    this.head = tempNode;
                }
                else
                {
                    tempNode = new DbNode<T>(value);
                    setNode(tempNode, this.head);

                    this.head = tempNode;

                }
            }
            else
            {
                DbNode<T> prevNode = this.getNodeByIndex(index); // 获得插入位置的节点
                DbNode<T> nextNode = prevNode.Next; // 获取插入位置的后继节点
                tempNode = new DbNode<T>(value);
                setNode(prevNode, tempNode);
                if (nextNode != null)
                {
                    setNode(tempNode, nextNode);
                }

            }

            this.count++;
        }
        // Method05:在指定位置前插入新节点
        public void InsertBefore(int index, T value)
        {
            DbNode<T> tempNode;
            if (index == 0)
            {
                if (this.head == null)
                {
                    tempNode = new DbNode<T>(value);
                    this.head = tempNode;
                }
                else
                {
                    tempNode = new DbNode<T>(value);
                    setNode(tempNode, this.head);
                    this.head = tempNode;
                }
            }
            else
            {
                DbNode<T> nextNode = this.getNodeByIndex(index); // 获得插入位置的节点
                DbNode<T> prevNode = nextNode.Prev; // 获取插入位置的前驱节点
                tempNode = new DbNode<T>(value);
                setNode(prevNode, tempNode);
                setNode(tempNode, nextNode);

            }
            this.count++;
        }
        // Method06:移除指定位置的节点
        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                this.head = this.head.Next;
            }
            else
            {
                DbNode<T> prevNode = this.getNodeByIndex(index - 1);
                if (prevNode.Next == null)
                {
                    throw new ArgumentOutOfRangeException("index", "索引超出范围");
                }
                DbNode<T> deleteNode = prevNode.Next;
                DbNode<T> nextNode = deleteNode.Next;
                setNode(prevNode, nextNode);

                deleteNode = null;
            }

            this.count--;
        }


    }
}
