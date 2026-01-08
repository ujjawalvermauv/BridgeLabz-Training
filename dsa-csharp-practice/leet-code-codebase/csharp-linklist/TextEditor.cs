using System;

class StateNode
{
    public string Text;
    public StateNode Prev;
    public StateNode Next;

    public StateNode(string text)
    {
        Text = text;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private StateNode head;
    private StateNode tail;
    private StateNode current;
    private int count = 0;
    private const int MAX = 10;

    // Add new state
    public void AddState(string text)
    {
        StateNode node = new StateNode(text);

        if (head == null)
        {
            head = tail = current = node;
            count = 1;
            return;
        }

        // Remove redo states
        if (current.Next != null)
        {
            current.Next.Prev = null;
            current.Next = null;
            tail = current;
        }

        tail.Next = node;
        node.Prev = tail;
        tail = node;
        current = node;
        count++;

        // Limit history
        if (count > MAX)
        {
            head = head.Next;
            head.Prev = null;
            count--;
        }
    }

    // Undo
    public void Undo()
    {
        if (current != null && current.Prev != null)
            current = current.Prev;
        else
            Console.WriteLine("No Undo Available");
    }

    // Redo
    public void Redo()
    {
        if (current != null && current.Next != null)
            current = current.Next;
        else
            Console.WriteLine("No Redo Available");
    }

    // Display current text
    public void Display()
    {
        if (current != null)
            Console.WriteLine("Current Text: " + current.Text);
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        editor.AddState("H");
        editor.AddState("He");
        editor.AddState("Hel");
        editor.AddState("Hell");
        editor.AddState("Hello");

        editor.Display();

        editor.Undo();
        editor.Display();

        editor.Undo();
        editor.Display();

        editor.Redo();
        editor.Display();
    }
}
