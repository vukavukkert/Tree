using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tree
{
    public class Node<T>
    {
        public T Data { get; set; }
        public int Key { get; set; }
        public Node<T>? Next_Left { get; set; }
        public Node<T>? Next_Right { get; set; }
        public Node(T data, int key, T Next_Left = default, T Next_Right = default)
        {
            Data = data;
            Key = key;
        }
    }
}