using System;

public class Student
{
    // PROPERTIES
    public string Name { get; private set; }
    public double Mark1 { get; private set; }
    public double Mark2 { get; private set; }
    public double Mark3 { get; private set; }

    // CONSTRUCTOR - validation happens here at the door
    public Student(string name, double mark1, double mark2, double mark3)
    {
        // Validate name
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Student name cannot be empty.");

        if (name.Any(char.IsDigit))
            throw new ArgumentException("Student name cannot contain numbers.");
        
        if (name.Length < 2)
           throw new ArgumentException("Student name must be at least 2 characters.");

        // Validate marks - must be between 0 and 100
        if (mark1 < 0 || mark1 > 100)
            throw new ArgumentException("Mark 1 must be between 0 and 100.");

        if (mark2 < 0 || mark2 > 100)
            throw new ArgumentException("Mark 2 must be between 0 and 100.");

        if (mark3 < 0 || mark3 > 100)
            throw new ArgumentException("Mark 3 must be between 0 and 100.");

        Name = name;
        Mark1 = mark1;
        Mark2 = mark2;
        Mark3 = mark3;
    }

    // METHOD - calculate average of 3 marks
    public double CalculateAverage()
    {
        return (Mark1 + Mark2 + Mark3) / 3;
    }

    // METHOD - assign grade based on average
    public string GetGrade()
    {
        double average = CalculateAverage();

        if (average >= 80) return "A";
        else if (average >= 70) return "B";
        else if (average >= 60) return "C";
        else if (average >= 50) return "D";
        else return "F";
    }
}

