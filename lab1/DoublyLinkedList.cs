namespace lab1;

public class DoublyLinkedList<T>
{
    private Element<T>? head;
    private Element<T>? tail;
    
    public void AddToBeggining(T value)
    {
        if (head == null)
        {
            head = tail = new Element<T> { value = value, next = null, prev = null};
        }
        var toAdd = new Element<T> { value = value, prev = null };
        toAdd.next = head;  
        head.prev = toAdd;

        head = toAdd;
    }
    public void AssToEnd(T value)
    {
        if (head == null)
        {
            head = new Element<T> { value = value, next = null, prev = null};
        }
        else
        {
            var newElement = new Element<T> { value = value };
            
            var current = head!;

            while (current.next != null)
            {
                current = current.next;
            }
            
            current.next = newElement;
            newElement.prev = current;
            tail = newElement;
        }
    }

    public void ForwartTraversal()
    {
        Element<T> current = head;

        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }
    public void BackwardTraversal()
    {
        Element<T> current = tail;

        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.prev;
        }
    }

    public T? DeleteFromEnd()
    {
        if (head.next == null)
        {
            T data = head.value;
            head = null;
            return data;
        }
        
        var current = head;
        while (current.next != null)
        {
            if (current.next.next == null)
            {
                T data = current.next.value;
                current.next = null;
                return data;
            }

            current = current.next;
            
        }

        return default;
    }
}