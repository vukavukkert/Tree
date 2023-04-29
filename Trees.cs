using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tree
{
	public class Trees
	{
		public Node? root;
		int count;

		public void Add(string data, int key)
		{
			Node node = new Node(data, key);
			if (root == null)
			{
				// Если рут пуст тогда элемент становится рутом
				root = node;
			}
			else
			{
				if (root.Key > node.Key)
				{
					Node? temp = root.Next_Left;
					if (root.Next_Left == null)
					{
						root.Next_Left = node;
					}
					if (temp != null)
					{
						Trees tree = new Trees();
						tree.root = temp;
						tree.Add(node.Data, node.Key);
					}
				}
				else
				{
					Node? temp = root.Next_Right;
					if (root.Next_Right == null)
					{
						root.Next_Right = node;
					}
					if (temp != null)
					{
						Trees tree = new Trees();
						tree.root = temp;
						tree.Add(node.Data, node.Key);
					}
				}
			}
		}

		public Node? Search(int key)
		{
			// Если дерево пустое то вернуть "Ничего не найдено"
			// Иначе, сравнить ключ с рутом, если меньше сравнить ключ с левым нодом


			if (root == null) Console.WriteLine("Дерево пустое");
			if (root != null)
			{
				var temp = root;
				while (temp != null)
				{
					if (key == temp.Key)
					{
						return temp;
					}
					else if (key < temp.Key)
					{
						temp = temp.Next_Left;
					}
					else
					{
						temp = temp.Next_Right;
					}
				}

			}
			return null;
		}
		public IEnumerable<Node> Searching(int key)
		{
			foreach (var node in this)
			{
				if (node.Key == key)
				{
					yield return node;
					yield break;
				}
			}
			Console.WriteLine("not found");
			yield break;
		}
		public IEnumerator<Node> GetEnumerator()
		{
			return new TreeEnumerator(root);
		}
		
	}
}