StacksAndQueues.LinkedListStack stack = new StacksAndQueues.LinkedListStack();
StacksAndQueues.LinkedListQueue queue = new StacksAndQueues.LinkedListQueue();

//Stack Push and Pop

stack.push(70);
stack.push(30);
stack.push(56);
stack.Display();
stack.peek();
stack.pop();
stack.Display();
stack.IsEmpty();

//Enqueue and Dequeue

queue.Enqueue(56);
queue.Enqueue(30);
queue.Enqueue(70);
queue.DisplayQueue();
queue.Dequeue();
Console.WriteLine("\nQueue After Dequeuing is");
queue.DisplayQueue();
