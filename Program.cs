using System;

class Program
{
    static void Main()
    {
        StudentManager manager = new StudentManager();
        FileHandler file = new FileHandler();

        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Sort Students");
            Console.WriteLine("4. File Operations");
            Console.WriteLine("5. Algorithm Comparison");
            Console.WriteLine("6. Exit");

            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    try
                    {
                        Console.Write("Enter ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Marks: ");
                        int marks = int.Parse(Console.ReadLine());

                        if (marks < 0)
                            throw new Exception("Marks cannot be negative");

                        manager.AddStudent(new Student { Id = id, Name = name, Marks = marks });
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                    break;

                case 2:
                    Console.WriteLine("1. Linear Search 2. Binary Search");
                    Console.Write("Enter choice: ");
                    int opt = int.Parse(Console.ReadLine());

                    Console.Write("Enter ID: ");
                    int sid = int.Parse(Console.ReadLine());

                    if (opt == 1)
                    {
                        int res = manager.LinearSearch(sid);
                        Console.WriteLine(res != -1 ? "Found at index " + res : "Not Found");
                    }
                    else
                    {
                        manager.SortById(); 
                        int res = manager.BinarySearch(sid);
                        Console.WriteLine(res != -1 ? "Found at index " + res : "Not Found");
                    }
                    break;

                case 3:
                    if (manager.GetStudents().Count == 0)
                    {
                        Console.WriteLine("No students available to sort!");
                        break;
                    }

                    Console.WriteLine("1. Bubble Sort  2. Quick Sort");
                    Console.Write("Enter option: ");

                    if (!int.TryParse(Console.ReadLine(), out int sort))
                    {
                        Console.WriteLine("Invalid input!");
                        break;
                    }

                    if (sort == 1)
                    {
                        manager.BubbleSort();
                        Console.WriteLine("\nSorted using Bubble Sort:\n");
                    }
                    else if (sort == 2)
                    {
                        manager.QuickSort(0, manager.GetStudents().Count - 1);
                        Console.WriteLine("\nSorted using Quick Sort:\n");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option!");
                        break;
                    }

                    Console.WriteLine("{0,-10} {1,-15} {2,-10}", "ID", "Name", "Marks");
                    Console.WriteLine(new string('-', 40));

                    foreach (var s in manager.GetStudents())
                    {
                        Console.WriteLine("{0,-10} {1,-15} {2,-10}", s.Id, s.Name, s.Marks);
                    }

                    break;

                case 4:
                    Console.WriteLine("1.Write 2.Append 3.Read 4.Copy 5.Delete");
                    Console.Write("Enter choice: ");
                    int f = int.Parse(Console.ReadLine());

                    if (f == 1)
                        file.Write(manager.GetStudents());

                    else if (f == 2)
                    {
                        Console.Write("Enter ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Marks: ");
                        int marks = int.Parse(Console.ReadLine());

                        file.Append(new Student { Id = id, Name = name, Marks = marks });
                    }
                    else if (f == 3)
                        file.Read();
                    else if (f == 4)
                        file.Copy();
                    else if (f == 5)
                        file.Delete();

                    break;

                case 5:
                    Console.WriteLine("\nAlgorithm Comparison:\n");

                    Console.WriteLine(
                        "Algorithm".PadRight(20) +
                        "Time".PadRight(15) +
                        "Space".PadRight(10) +
                        "Best Use"
                    );

                    Console.WriteLine(new string('-', 60));

                    Console.WriteLine(
                        "Linear Search".PadRight(20) +
                        "O(n)".PadRight(15) +
                        "O(1)".PadRight(10) +
                        "Small data"
                    );

                    Console.WriteLine(
                        "Binary Search".PadRight(20) +
                        "O(log n)".PadRight(15) +
                        "O(1)".PadRight(10) +
                        "Sorted data"
                    );

                    Console.WriteLine(
                        "Bubble Sort".PadRight(20) +
                        "O(n^2)".PadRight(15) +
                        "O(1)".PadRight(10) +
                        "Small data"
                    );

                    Console.WriteLine(
                        "Quick Sort".PadRight(20) +
                        "O(n log n)".PadRight(15) +
                        "O(log n)".PadRight(10) +
                        "Large data"
                    );

                    break;

                case 6:
                    return;
            }
        }
    }
}