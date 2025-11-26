using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using LinkedList.List;

namespace LinkedList.FileIO;
public class FileIOManager
{
    public void Serialize(LinkedListNode list, string filename)
    {
        try
        {
            var json = JsonSerializer.Serialize(list);
            File.WriteAllText(filename, json);
            Console.WriteLine("List saved to file");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public LinkedListNode Deserialize(string filename)
    {
        try
        {
            var json = File.ReadAllText(filename);
            LinkedListNode? list = JsonSerializer.Deserialize<LinkedListNode>(json);
            Console.WriteLine("List read from file");

            return list ?? new LinkedListNode(); // avoid null warnings
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return new LinkedListNode();
        }
    }
}
