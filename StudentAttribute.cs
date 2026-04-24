using System;

[AttributeUsage(AttributeTargets.Class)]
public class StudentInfoAttribute : Attribute
{
    public string Info { get; set; }

    public StudentInfoAttribute(string info)
    {
        Info = info;
    }
}