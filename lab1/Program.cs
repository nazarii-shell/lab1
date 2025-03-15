using lab1;

// var stack = new MyStack<int>();
//
// stack.Push(5);
// stack.Push(4);
// stack.Push(3);
// stack.Push(2);
// stack.Push(1);
//
// stack.PrintAllNodes();
//
// stack.Pop();
// stack.Pop();
//
// Console.WriteLine("After pop: \n");
//
//
// stack.PrintAllNodes();
//
// var doublyLinkedList = new DoublyLinkedList<int>();
//
// doublyLinkedList.ToBeggining(1);
// doublyLinkedList.ToBeggining(2);
// doublyLinkedList.ToBeggining(3);
// doublyLinkedList.ToBeggining(4);
// doublyLinkedList.ToBeggining(5);
//
// doublyLinkedList.Push(11);
// doublyLinkedList.Push(12);
// doublyLinkedList.Push(13);
//
// Console.WriteLine("Forward");
// doublyLinkedList.ForwartTraversal();
// Console.WriteLine("Backward");
// doublyLinkedList.BackwardTraversal();
//
// Console.WriteLine("Pop");
// doublyLinkedList.Pop();
// doublyLinkedList.Pop();
// doublyLinkedList.ForwartTraversal();

// 9
// 7
// 5
// 3
// 1
// 2
// 4
// 6
// 8


var stack = new MyStack<int>();

stack.Push(5);
stack.Push(4);
stack.Push(3);
stack.Push(2);
stack.Push(1);

var linkedList = new DoublyLinkedList<int>();

while (!stack.IsEmpty())
{
    var element = stack.Pop();
    if (element % 2 == 0)
    {
        linkedList.AddToBeggining(element);
    }
    else
    {
        linkedList.AssToEnd(element);
    }
}


linkedList.ForwartTraversal();