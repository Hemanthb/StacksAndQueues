using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class LinkedListStack
    {
        Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        public void push(int data) 
        {
            Node node = new Node(data);
          
            if(this.top == null)
            {
                this.top = node;
            }
            else
            {
                node.next = this.top;
                this.top = node;
                
            }
            Console.WriteLine("Data {0} is pushed onto stack",data);
        } 
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
        }
    }
}
