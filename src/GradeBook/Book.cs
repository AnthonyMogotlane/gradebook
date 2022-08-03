namespace GradeBook;

public class Book
{
    List<double> grades;

    public Book() => grades = new List<double>();
    public void AddGrade(double grade)
    {
        grades.Add(grade);
    }

    public void ShowStatistics()
    {
        double res = 0.0;
        double highGrade = double.MinValue;
        double lowestGrade = double.MaxValue;

        foreach(double num in grades)
        {
            lowestGrade = Math.Min(num, lowestGrade);
            highGrade = Math.Max(num, highGrade);
            res += num;
        }

        double avg = res/grades.Count;

        Console.WriteLine($"The lowest grade is {lowestGrade}");
        Console.WriteLine($"The highest grade is {highGrade}");
        Console.WriteLine($"The lowest grade is {avg:N1}");
    }
}