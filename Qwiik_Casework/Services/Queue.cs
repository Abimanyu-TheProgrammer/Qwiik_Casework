using System;
namespace Qwiik_Casework.Services
{
	public class Queue
	{
		private Node head;
		private Node tail;

		public Queue()
		{
			head = null;
			tail = null;
		}

		public void Add(int i)
		{
			Node newNode = new Node(i);
			if (head is null)
			{
				head = newNode;
				tail = newNode;
            }

			tail.next = newNode;
			tail = newNode;
		}

		public int Remove()
		{
			int val = -1;
			if(head is not null)
			{
				val = head.value;
                head = head.next;
            }
			return val;
		}

		public int Peek()
		{
			if(head is not null)
			{
				return head.value;
			}
			return -1;
		}

	}
}

