using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
	class CustomQueue<T> : IEnumerable<T>
	{
		private Node<T> root;

		public CustomQueue(Node<T> root)
		{
			this.root = root;
		}
		public CustomQueue()
		{
			this.root = null;
		}

		public Node<T> Root
		{
			get { return this.root; }
			set { this.root = value; }
		}


		public void Enqueue(Node<T> node)
		{
			if (this.root == null)
			{ 
				this.root = node;

			}
			else
			{
				node.next = this.root;
				this.root = node;

			}
		}

		public Node<T> Dequeue()
		{
			if (this.root == null)
			{
				return null;
			}
			else
			{
				Node<T> curr = this.root;
				Node<T> previous = null;
				while (curr.next != null)
				{
					previous = curr;
					curr = curr.next;
				}
				if(previous != null)
				{
					previous.next = null;
				}
				else
				{

					this.root = null;
				}
				return curr;
			}
			
		}

		public override string ToString()
		{
			if (this.root == null)
				return "Null";
			string res = "";
			Node<T> curr = this.root;
			do
			{
				res = res + curr.data.ToString() +" ";
				curr = curr.next;
			}while(curr!=null);
			return res;
		}
		
		public IEnumerator<T> GetEnumerator() {
			Node<T> curr = root;
			while( curr != null)
			{
				yield return curr.data;
				curr = curr.next;
			}
		}

		// For IEnumerable
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

	}
}
