using System;
using System.IO;
using System.Collections.Generic;

public class FileHandler
{
    string path = "students.txt";

    public void Write(List<Student> students)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            foreach (var s in students)
                sw.WriteLine($"{s.Id},{s.Name},{s.Marks}");
        }
        Console.WriteLine("File created & data written.");
    }

    public void Append(Student s)
    {
        using (StreamWriter sw = new StreamWriter(path, true))
        {
            sw.WriteLine($"{s.Id},{s.Name},{s.Marks}");
        }
        Console.WriteLine("Record appended.");
    }

    public void Read()
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("File not found.");
            return;
        }

        Console.WriteLine("\nFile Data:");
        foreach (var line in File.ReadAllLines(path))
            Console.WriteLine(line);
    }

    public void Copy()
    {
        File.Copy(path, "backup.txt", true);
        Console.WriteLine("File copied.");
    }

    public void Delete()
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("File deleted.");
        }
    }
}