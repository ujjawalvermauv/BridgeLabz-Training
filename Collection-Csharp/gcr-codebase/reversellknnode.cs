using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class LinkedList
{
    public Node head;
    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (head == null){
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
            
        }
        temp.next=newNode;
    }

    public void ReverseFirstN(int n)
    {
        Node prev = null;
        Node curr = head;
        Node next = null;

        int count = 0;
        while (curr != null && count < n)
        {
            next=curr.next;
            curr.next=prev;
            prev=curr;
            curr=next;
            count++;
        }

        head.next = curr;
        head = prev;
    }

    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + "> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        LinkedList list=new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Display();
        list.ReverseFirstN(7);
        list.Display();
    }
}
