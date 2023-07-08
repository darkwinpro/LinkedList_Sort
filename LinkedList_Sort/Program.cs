using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        LinkedList<Players> players = new LinkedList<Players>();
        int n = Convert.ToInt32(Console.ReadLine());

        while (n != 0)
        {
            
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                
                case 1 :
                    players.AddFirst(Input());
                    Sort(players);
                    break;
                
                case 2 :
                    RemovePlayer(players);
                    Sort(players);
                    break;
                
                default:
                    PrintInfo(players);
                    break;
                
            }
            
            n -= 1;
        }
        
    }

    public static void PrintInfo(LinkedList<Players> players)
    {
        var node = players.First;

        while (node != null)
        {
            Console.WriteLine(node.Value.Name);
            Console.WriteLine();
            node = node.Next;
        }
    }

    public static void RemovePlayer(LinkedList<Players> players)
    {
        LinkedListNode<Players> tempNode = new LinkedListNode<Players>(Input());
        var node = players.First;

        while (node != null)
        {
            if (string.Compare(node.Value.Name, tempNode.Value.Name ) == 0)
            {
                players.Remove(node);
                break;
            }

            node = node.Next;
        }
    }

    public static void Sort(LinkedList<Players> players)
    {
        var node = players.First;
        string temp = String.Empty;
        
        while (node != null)
        {
            if (node.Next != null && string.Compare(node.Value.Name, node.Next.Value.Name) > 0)
            {
                temp = node.Value.Name;
                node.Value.Name = node.Next.Value.Name;
                node.Next.Value.Name = temp;
            }

            node = node.Next;
        }
    }

    public static Players Input()
    {
        string tempPlayerName = Console.ReadLine();
        Players tempPlayer = new Players(tempPlayerName);
        return tempPlayer;
    }
}

public class Players
{
    public string Name;

    public Players(string name)
    {
        Name = name;
    }
}