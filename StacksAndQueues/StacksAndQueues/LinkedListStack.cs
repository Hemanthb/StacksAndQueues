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
        public void peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack Is Empty!!");
            }
            else
            {
                Console.WriteLine("Top element of stack is"+this.top.data);
            }
        }
        public void pop()
        {
            peek();
            if(this.top == null)
            {
                Console.WriteLine("Stack is Empty and Nothing to Pop!!");
                return;
            }
            Console.WriteLine("Element to be Popped is - " + this.top.data);
            this.top = this.top.next;   
        }

        public void IsEmpty()
        {
            while(this.top != null)
            {
                pop();
            }
            Console.WriteLine("\n Stack Is Emptied \n");
        }
    }
}
