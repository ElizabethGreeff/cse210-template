using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Gwyneth Paltrow", "The study of iron man");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("7.3", "8-19", "Gwyneth Paltrow", "The study of iron man");
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Why we need Iron Man", "Gwyneth Paltrow", "The study of iron man");
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}