using System;
namespace Qwiik_Casework.Services
{
	public class QueueService : IQueueService
	{
        public string runQueue()
        {
            Queue queue = new Queue();

            queue.Add(1);
            queue.Add(2);
            queue.Remove();

            return string.Format("In front of the Queue: %s", queue.Peek());
        }
    }
}

