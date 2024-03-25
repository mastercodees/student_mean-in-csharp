using System;

class Student
{
    public int[] marks = new int[10];

    public void inputMarks()
    {
        Console.WriteLine("Enter Marks of student");
        for (int i = 0;i < marks.Length;i++)
        {
            marks[i]= Convert.ToInt32(Console.ReadLine());
        }
    }

    public int Mean()
    {
        int sum = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            sum += marks[i];
        }

        Console.WriteLine("The Mean Score is:");
        return sum / marks.Length;
    }
}

class Program
{
    public static void Main()
    {
        Student student = new Student();
        student.inputMarks();
        Console.WriteLine(student.Mean());
        
    }  
}
