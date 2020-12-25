using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCore.LinkedList.DoubleLinkedList
{
    public class DbNode<T>
    {
        public T Item { get; set; }

        /// <summary>
        /// 上个Node
        /// </summary>
        public DbNode<T> Prev { get; set; }

        /// <summary>
        /// 下个Node
        /// </summary>
        public DbNode<T> Next { get; set; }



        public DbNode() { }


        public DbNode(T item)
        {
            this.Item = item;
        }


    }
}
