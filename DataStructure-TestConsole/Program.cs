﻿using DataStructureCore.LinkedList.DoubleLinkedList;
using DataStructureCore.LinkedList.SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySingleLinkedListTest();
            MyDoubleLinkedListTest();
        }

        static void MyDoubleLinkedListTest()
        {
            MyDoubleLinkedList<int> linkedList = new MyDoubleLinkedList<int>();
            // Test1:顺序插入4个节点
            linkedList.AddAfter(0);
            linkedList.AddAfter(1);
            linkedList.AddAfter(2);
            linkedList.AddAfter(3);

            Console.WriteLine("The nodes in the DoubleLinkedList:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.Write(linkedList[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            // Test2.1:在尾节点之前插入2个节点
            linkedList.AddBefore(10);
            linkedList.AddBefore(20);
            Console.WriteLine("After add 10 and 20:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.Write(linkedList[i] + " ");
            }
            Console.WriteLine();
            // Test2.2:在索引为2(即第3个节点)的位置之后插入单个节点
            linkedList.InsertAfter(2, 50);
            Console.WriteLine("After add 50:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.Write(linkedList[i] + " ");
            }
            Console.WriteLine();
            // Test2.3:在索引为2(即第3个节点)的位置之前插入单个节点
            linkedList.InsertBefore(2, 40);
            Console.WriteLine("After add 40:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.Write(linkedList[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            // Test3.1:移除索引为7(即最后一个节点)的位置的节点
            linkedList.RemoveAt(7);
            Console.WriteLine("After remove an node in index of 7:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.Write(linkedList[i] + " ");
            }
            Console.WriteLine();
            // Test3.2:移除索引为0(即第一个节点)的位置的节点的值
            linkedList.RemoveAt(0);
            Console.WriteLine("After remove an node in index of 0:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.Write(linkedList[i] + " ");
            }
            Console.WriteLine();
            // Test3.3:移除索引为2(即第3个节点)的位置的节点
            linkedList.RemoveAt(2);
            Console.WriteLine("After remove an node in index of 2:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.Write(linkedList[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            // Test4:修改索引为2(即第3个节点)的位置的节点的值
            linkedList[2] = 9;
            Console.WriteLine("After update the value of node in index of 2:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.Write(linkedList[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
        }
        static void MySingleLinkedListTest()
        {
            MySingleLinkedList<int> linkedList = new MySingleLinkedList<int>();
            // Test1:顺序插入4个节点
            linkedList.Add(0);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            Console.WriteLine("The nodes in the linkedList:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }
            Console.WriteLine("----------------------------");

            // Test2.1:在索引为0(即第1个节点)的位置插入单个节点
            linkedList.Insert(0, 10);
            Console.WriteLine("After insert 10 in index of 0:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }
            // Test2.2:在索引为2(即第3个节点)的位置插入单个节点
            linkedList.Insert(2, 20);
            Console.WriteLine("After insert 20 in index of 2:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }
            // Test2.3:在索引为5（即最后一个节点）的位置插入单个节点
            linkedList.Insert(5, 30);
            Console.WriteLine("After insert 30 in index of 5:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }
            Console.WriteLine("----------------------------");

            // Test3.1:移除索引为5（即最后一个节点）的节点
            linkedList.RemoveAt(5);
            Console.WriteLine("After remove an node in index of 5:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }
            // Test3.2:移除索引为0（即第一个节点）的节点
            linkedList.RemoveAt(0);
            Console.WriteLine("After remove an node in index of 0:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }
            // Test3.3:移除索引为2（即第三个节点）的节点
            linkedList.RemoveAt(2);
            Console.WriteLine("After remove an node in index of 2:");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }
            Console.WriteLine("----------------------------");
        }
    }
}
