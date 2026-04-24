using System;
using System.Collections.Generic;

public class StudentManager
{
    private List<Student> students = new List<Student>();

    // Indexer
    public Student this[int index]
    {
        get { return students[index]; }
    }

    public void AddStudent(Student s)
    {
        students.Add(s);
    }

    public List<Student> GetStudents()
    {
        return students;
    }

    //  Linear Search
    public int LinearSearch(int id)
    {
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == id)
                return i;
        }
        return -1;
    }

    //  Sort by ID
    public void SortById()
    {
        students.Sort((a, b) => a.Id.CompareTo(b.Id));
    }

    //  Binary Search 
    public int BinarySearch(int id)
    {
        int left = 0, right = students.Count - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (students[mid].Id == id)
                return mid;

            if (students[mid].Id < id)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    //  Bubble Sort (Marks)
    public void BubbleSort()
    {
        for (int i = 0; i < students.Count; i++)
        {
            for (int j = 0; j < students.Count - i - 1; j++)
            {
                if (students[j].Marks > students[j + 1].Marks)
                {
                    var temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }
    }

    //  Quick Sort (Marks)
    public void QuickSort(int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(low, high);
            QuickSort(low, pi - 1);
            QuickSort(pi + 1, high);
        }
    }

    private int Partition(int low, int high)
    {
        int pivot = students[high].Marks;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (students[j].Marks < pivot)
            {
                i++;
                var temp = students[i];
                students[i] = students[j];
                students[j] = temp;
            }
        }

        var temp2 = students[i + 1];
        students[i + 1] = students[high];
        students[high] = temp2;

        return i + 1;
    }

    public void Display()
    {
        Console.WriteLine("\nID\tName\tMarks");
        foreach (var s in students)
        {
            Console.WriteLine($"{s.Id}\t{s.Name}\t{s.Marks}");
        }
    }
}