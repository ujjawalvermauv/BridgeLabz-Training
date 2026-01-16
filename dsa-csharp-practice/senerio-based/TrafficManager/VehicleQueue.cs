using System;

public class VehicleQueue
{
    private Vehicle front;
    private Vehicle rear;
    private int size;
    private int capacity;

    public VehicleQueue(int capacity)
    {
        this.capacity = capacity;
        front = null;
        rear = null;
        size = 0;
    }

    // Status checks
    public bool IsFull()
    {
        return size == capacity;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    // Add vehicle to queue
    public void Enqueue(Vehicle vehicle)
    {
        if (vehicle == null)
        {
            Console.WriteLine("Invalid vehicle!");
            return;
        }

        if (IsFull())
        {
            Console.WriteLine("Queue Overflow!");
            return;
        }

        vehicle.Next = null;

        if (rear == null)
        {
            front = rear = vehicle;
        }
        else
        {
            rear.Next = vehicle;
            rear = vehicle;
        }

        size++;
    }

    // Remove vehicle from queue
    public Vehicle Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue Underflow!");
            return null;
        }

        Vehicle temp = front;
        front = front.Next;
        size--;

        if (front == null)
        {
            rear = null;
        }

        temp.Next = null; // break link
        return temp;
    }

    // Optional: view front element
    public Vehicle Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return null;
        }
        return front;
    }
}
