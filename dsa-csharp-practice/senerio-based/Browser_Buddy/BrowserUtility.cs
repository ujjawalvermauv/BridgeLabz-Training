using System;
using System.Collections.Generic;

public class BrowserUtility : IBrowserManager
{
    private HistoryNode start;
    private HistoryNode active;
    private Stack<HistoryNode> recentlyClosed;

    public BrowserUtility()
    {
        start = null;
        active = null;
        recentlyClosed = new Stack<HistoryNode>();
    }

    // Open a new webpage
    public void Visit(string url)
    {
        HistoryNode page = new HistoryNode(url);

        if (start == null)
        {
            start = page;
            active = page;
        }
        else
        {
            // Clear forward navigation
            if (active.Next != null)
                active.Next = null;

            page.Prev = active;
            active.Next = page;
            active = page;
        }

        Console.WriteLine("Opened page -> " + active.ToString());
    }

    // Navigate backward
    public void Back()
    {
        if (active == null || active.Prev == null)
        {
            Console.WriteLine("Cannot move backward.");
            return;
        }

        active = active.Prev;
        Console.WriteLine("Moved back to -> " + active.ToString());
    }

    // Navigate forward
    public void Forward()
    {
        if (active == null || active.Next == null)
        {
            Console.WriteLine("Cannot move forward.");
            return;
        }

        active = active.Next;
        Console.WriteLine("Moved forward to -> " + active.ToString());
    }

    // Show complete browsing history
    public void DisplayHistory()
    {
        if (start == null)
        {
            Console.WriteLine("History is empty.");
            return;
        }

        Console.WriteLine("\nComplete History:");
        HistoryNode pointer = start;

        while (pointer != null)
        {
            if (pointer == active)
                Console.Write("{" + pointer + "} ");
            else
                Console.Write(pointer + " ");

            pointer = pointer.Next;
        }
        Console.WriteLine();
    }

    // Close the current tab
    public void CloseTab()
    {
        if (start == null)
        {
            Console.WriteLine("Nothing to close.");
            return;
        }

        recentlyClosed.Push(start);
        start = null;
        active = null;
        Console.WriteLine("Current tab closed successfully.");
    }

    // Restore last closed tab
    public void RestoreTab()
    {
        if (recentlyClosed.Count == 0)
        {
            Console.WriteLine("No tabs available to restore.");
            return;
        }
        start = recentlyClosed.Pop();
        active = start;
        // Move to most recent page
        while (active.Next != null)
            active = active.Next;

        Console.WriteLine("Tab restored. Active page -> " + active.ToString());
    }
}
