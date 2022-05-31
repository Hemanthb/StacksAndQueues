using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class LinkedListQueue
    {
        Node front = null;
        public void Enqueue(int data)
        {
            
            Node node = new Node(data);
            if(front == null)
            {
                front = node;
                Console.WriteLine("Enqueued Element is {0}", node.data);
            }
            else
            {
                Node rear = front;
                while(rear.next != null)
                {
                    rear = rear.next;
                }
                rear.next = node;
                Console.WriteLine("Enqueued Element is {0}", node.data);
            }
            
        }
        public void DisplayQueue()
        {
            if(this.front == null)
            {
                Console.WriteLine("Queue is Empty!!");
            }
            else
            {
                Console.WriteLine();
                Node temp = this.front;
                while(temp != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.next;
                }
            }
        }
    }
}
