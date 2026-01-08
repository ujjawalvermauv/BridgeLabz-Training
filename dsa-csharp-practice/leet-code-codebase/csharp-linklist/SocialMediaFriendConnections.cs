using System;
using System.Collections.Generic;

// Node representing a User
class UserNode
{
    public int UserId;
    public string Name;
    public int Age;
    public List<int> Friends;   // Stores Friend IDs
    public UserNode Next;

    public UserNode(int id, string name, int age)
    {
        UserId = id;
        Name = name;
        Age = age;
        Friends = new List<int>();
        Next = null;
    }
}

class SocialMedia
{
    private UserNode head;

    // Add new user
    public void AddUser(int id, string name, int age)
    {
        UserNode node = new UserNode(id, name, age);
        node.Next = head;
        head = node;
    }

    // Find user by ID
    private UserNode FindUserById(int id)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserId == id)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    // Add friend connection (two-way)
    public void AddFriend(int id1, int id2)
    {
        UserNode user1 = FindUserById(id1);
        UserNode user2 = FindUserById(id2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("User not found");
            return;
        }

        if (!user1.Friends.Contains(id2))
            user1.Friends.Add(id2);

        if (!user2.Friends.Contains(id1))
            user2.Friends.Add(id1);
    }

    // Remove friend connection
    public void RemoveFriend(int id1, int id2)
    {
        UserNode user1 = FindUserById(id1);
        UserNode user2 = FindUserById(id2);

        if (user1 == null || user2 == null)
            return;

        user1.Friends.Remove(id2);
        user2.Friends.Remove(id1);
    }

    // Display friends of a user
    public void DisplayFriends(int id)
    {
        UserNode user = FindUserById(id);
        if (user == null)
        {
            Console.WriteLine("User not found");
            return;
        }

        Console.WriteLine("Friends of " + user.Name + ":");
        foreach (int fid in user.Friends)
        {
            UserNode f = FindUserById(fid);
            if (f != null)
                Console.WriteLine(f.UserId + " " + f.Name);
        }
    }

    // Find mutual friends
    public void MutualFriends(int id1, int id2)
    {
        UserNode user1 = FindUserById(id1);
        UserNode user2 = FindUserById(id2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("User not found");
            return;
        }

        Console.WriteLine("Mutual Friends:");
        foreach (int f in user1.Friends)
        {
            if (user2.Friends.Contains(f))
            {
                UserNode u = FindUserById(f);
                if (u != null)
                    Console.WriteLine(u.UserId + " " + u.Name);
            }
        }
    }

    // Search user by Name
    public void SearchByName(string name)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.Name == name)
            {
                Console.WriteLine("Found: ID " + temp.UserId + ", Name " + temp.Name + ", Age " + temp.Age);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("User not found");
    }

    // Count friends of each user
    public void CountFriends()
    {
        UserNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Name + " has " + temp.Friends.Count + " friends");
            temp = temp.Next;
        }
    }

    // Display all users
    public void DisplayUsers()
    {
        UserNode temp = head;
        while (temp != null)
        {
            Console.WriteLine("ID: " + temp.UserId + ", Name: " + temp.Name + ", Age: " + temp.Age);
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMedia sm = new SocialMedia();

        sm.AddUser(1, "Aman", 20);
        sm.AddUser(2, "Riya", 19);
        sm.AddUser(3, "Karan", 21);
        sm.AddUser(4, "Neha", 20);

        sm.AddFriend(1, 2);
        sm.AddFriend(1, 3);
        sm.AddFriend(2, 3);
        sm.AddFriend(3, 4);

        Console.WriteLine("All Users:");
        sm.DisplayUsers();

        Console.WriteLine();
        sm.DisplayFriends(1);

        Console.WriteLine();
        sm.MutualFriends(1, 2);

        Console.WriteLine();
        sm.SearchByName("Neha");

        Console.WriteLine();
        sm.CountFriends();

        Console.WriteLine("\nRemoving friend connection between 1 and 3");
        sm.RemoveFriend(1, 3);

        Console.WriteLine();
        sm.DisplayFriends(1);
    }
}
