using System;

// Node of Circular Linked List
class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public int RemainingTime;
    public int CompletionTime;
    public int Priority;
    public ProcessNode Next;

    public ProcessNode(int id, int burst, int priority)
    {
        ProcessId = id;
        BurstTime = burst;
        RemainingTime = burst;
        Priority = priority;
        CompletionTime = 0;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private ProcessNode head;
    private int processCount;

    // Add process at end
    public void AddProcess(int id, int burst, int priority)
    {
        ProcessNode node = new ProcessNode(id, burst, priority);
        processCount++;

        if (head == null)
        {
            head = node;
            node.Next = head;
            return;
        }

        ProcessNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = node;
        node.Next = head;
    }

    // Execute Round Robin
    public void Execute(int timeQuantum)
    {
        if (head == null)
        {
            Console.WriteLine("No processes");
            return;
        }

        int currentTime = 0;
        int completed = 0;
        ProcessNode temp = head;

        while (completed < processCount)
        {
            if (temp.RemainingTime > 0)
            {
                Console.WriteLine("Executing Process " + temp.ProcessId + " (Remaining: " + temp.RemainingTime + ")");
                if (temp.RemainingTime > timeQuantum)
                {
                    temp.RemainingTime -= timeQuantum;
                    currentTime += timeQuantum;
                }
                else
                {
                    currentTime += temp.RemainingTime;
                    temp.RemainingTime = 0;
                    temp.CompletionTime = currentTime;
                    completed++;

                    Console.WriteLine("Process " + temp.ProcessId + " completed at time " + currentTime);
                }

                DisplayQueue();
            }
            temp = temp.Next;
        }

        CalculateTimes();
    }

    // Display circular queue
    public void DisplayQueue()
    {
        if (head == null) return;

        ProcessNode temp = head;
        Console.Write("Queue: ");

        do
        {
            Console.Write(
                "[P" + temp.ProcessId +
                " RT:" + temp.RemainingTime + "] "
            );
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine();
    }

    // Calculate WT and TAT
    public void CalculateTimes()
    {
        ProcessNode temp = head;
        double totalWT = 0;
        double totalTAT = 0;

        Console.WriteLine("\nPID  Burst  Priority  TAT  WT");

        do
        {
            int tat = temp.CompletionTime;
            int wt = tat - temp.BurstTime;

            totalTAT += tat;
            totalWT += wt;

            Console.WriteLine(temp.ProcessId + "     " + temp.BurstTime + "      " + temp.Priority + "       " + tat + "    " + wt);
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("\nAverage Turnaround Time: " + (totalTAT / processCount));
        Console.WriteLine("Average Waiting Time: " + (totalWT / processCount));
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler rr = new RoundRobinScheduler();

        rr.AddProcess(1, 5, 1);
        rr.AddProcess(2, 3, 2);
        rr.AddProcess(3, 8, 1);

        int timeQuantum = 2;
        Console.WriteLine("Time Quantum = " + timeQuantum);

        rr.Execute(timeQuantum);
    }
}
