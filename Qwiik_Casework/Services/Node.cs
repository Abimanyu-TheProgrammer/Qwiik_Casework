using System;
namespace Qwiik_Casework.Services
{
	public class Node
	{

		public int value { get; set; }
		public Node next { get; set; }

		public Node(int value)
		{
			this.value = value;
		}
	}
}

