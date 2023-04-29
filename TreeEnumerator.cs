using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Tree
{
	public class TreeEnumerator : IEnumerator<Node>
	{
		public Queue<Node> queue;
		public TreeEnumerator(Node root)
		{
			queue = new Queue<Node>();
			queue.Enqueue(root);
		}
		public Node Current => queue.Peek();
		object IEnumerator.Current => Current;
		public bool MoveNext()
		{
			if (queue.Count == 0)
			{
				return false;
			}

			var node = queue.Dequeue();

			if (node.Next_Left != null)
			{
				queue.Enqueue(node.Next_Left);
			}

			if (node.Next_Right != null)
			{
				queue.Enqueue(node.Next_Right);
			}

			return true;
		}
		public void Reset()
		{

		}
		public void Dispose()
		{

		}
		
	}
}