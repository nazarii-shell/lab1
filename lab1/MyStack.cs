namespace lab1;

public class MyStack<T>
{
    private Node<T>? head;

    public void PrintAllNodes()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }

    public void ToBeggining(T value)
    {
        var toAdd = new Node<T> { data = value, next = null };
        toAdd.next = head;  
        head = toAdd;
    }


    public void Push(T data)
    {
        if (head == null)
        {
            head = new Node<T> { data = data, next = null };
        }
        else
        {
            Node<T> toAdd = new Node<T> { data = data };

            Node<T> current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = toAdd;
        }
    }

    public T? Pop()
    {
        if (head.next == null)
        {
            T data = head.data;
            head = null;
            return data;
        }
        
        var current = head;
        while (current.next != null)
        {
            if (current.next.next == null)
            {
                T data = current.next.data;
                current.next = null;
                return data;
            }

            current = current.next;
        }

        return default;
    }

    public Boolean IsEmpty()
    {
        return head == null;
    }
    
    
}