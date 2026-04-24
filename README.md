# CSharp_Smart_Student_Data_System

# 📘 Smart Student Data Processing System

## 📌 Problem Statement

This project is a console-based C# application designed to efficiently manage student data using searching, sorting, file handling, and OOP concepts.

The system allows users to:

* Add student records
* Search students by ID
* Sort students based on marks
* Perform file operations
* Compare algorithm performance

---

## 🚀 Features

### 🔍 Searching

* Linear Search (O(n))
* Binary Search (O(log n)) *(on sorted data)*

### 🔄 Sorting

* Bubble Sort (O(n²))
* Quick Sort (O(n log n))

### 📁 File Handling

* Create & Write file
* Append data
* Read file
* Copy file
* Delete file

### 🧠 OOP Concepts Used

* Properties
* Indexers
* Custom Attributes

---

## 🛠️ Technologies Used

* C#
* .NET Console Application

---

## 📂 Project Structure

```
SmartStudentDataSystem/
│── Program.cs
│── Student.cs
│── StudentManager.cs
│── FileHandler.cs
│── StudentAttribute.cs
```

---

## ▶️ How to Run the Code

1. Open Visual Studio
2. Create/Open Console App
3. Copy all code files
4. Build the project
5. Run using:

```
Ctrl + F5
```

---

## 📊 Sample Output

```
--- MENU ---
1. Add Student
2. Search Student
3. Sort Students
4. File Operations
5. Algorithm Comparison
6. Exit

Enter choice: 1
Enter ID: 101
Enter Name: Giridhar
Enter Marks: 85

Student added successfully!
```

### 🔍 Search Example

```
Enter choice: 2
Enter option: 1
Enter ID: 101

Found: ID=101, Name=Giridhar, Marks=85
```

### 🔄 Sorting Output

```
Sorted using Quick Sort:

ID         Name            Marks
----------------------------------------
102        Rahul           72
101        Giridhar        85
103        Sneha           95
```

---

## ⚠️ Exception Handling

* Prevents invalid input using `TryParse`
* Throws error if marks are negative
* Handles missing files safely

---

## 📈 Algorithm Comparison

| Algorithm     | Time Complexity | Space Complexity | Best Use Case  |
| ------------- | --------------- | ---------------- | -------------- |
| Linear Search | O(n)            | O(1)             | Small datasets |
| Binary Search | O(log n)        | O(1)             | Sorted data    |
| Bubble Sort   | O(n²)           | O(1)             | Small datasets |
| Quick Sort    | O(n log n)      | O(log n)         | Large datasets |

---

## 💡 Key Learnings

* Understanding searching & sorting algorithms
* File handling in C#
* Implementing OOP concepts
* Writing clean and user-friendly console applications

---

## 👩‍💻 Author

Giridhar Gopal
