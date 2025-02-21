using System;

class Program
{
    static void Main(string[] args)
    {
        var Assignment = new Assignment("tyler", "science");
        var summary =Assignment.GetSummary();
        Console.WriteLine(summary);

        var MathAssignment = new MathAssignment("tyboos", "math", "5.4", "45-50");
        var homeworkList = MathAssignment.getHomeworkList();
        Console.WriteLine(homeworkList);

        var WritingAssignment = new WritingAssignment("tyler", "english", "I am only slightly confused");
        var writingInformation = WritingAssignment.GetWritingInformation();
        Console.WriteLine(writingInformation);
    } 
}