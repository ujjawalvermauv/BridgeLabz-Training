using System;

class TaskNode
{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public TaskNode Next;

    public TaskNode(int id, string name, int priority)
    {
        TaskId = id;
        TaskName = name;
        Priority = priority;
        Next = null;
    }
}

class TaskScheduler
{
    private TaskNode head;

    // Add task at end
    public void AddTask(int id, string name, int priority)
    {
        TaskNode node = new TaskNode(id, name, priority);

        if (head == null)
        {
            head = node;
            node.Next = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = node;
        node.Next = head;
    }

    // Remove task by Task ID
    public void RemoveTask(int id)
    {
        if (head == null) return;

        TaskNode curr = head;
        TaskNode prev = null;

        do
        {
            if (curr.TaskId == id)
            {
                if (prev != null)
                {
                    prev.Next = curr.Next;
                }
                else
                {
                    TaskNode last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                return;
            }

            prev = curr;
            curr = curr.Next;

        } while (curr != head);
    }

    // Display all tasks
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No Tasks");
            return;
        }

        TaskNode temp = head;
        do
        {
            Console.WriteLine("TaskId: " + temp.TaskId + ", Name: " + temp.TaskName + ", Priority: " + temp.Priority);
            temp = temp.Next;
        } while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddTask(1, "Coding", 1);
        scheduler.AddTask(2, "Testing", 2);
        scheduler.AddTask(3, "Debugging", 1);

        Console.WriteLine("All Tasks:");
        scheduler.Display();

        Console.WriteLine("Removing Task ID 2");
        scheduler.RemoveTask(2);

        Console.WriteLine("After Removal:");
        scheduler.Display();
    }
}
