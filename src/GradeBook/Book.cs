namespace GradeBook;

public class Book
{
    List<double> grades;

    public Book() => grades = new List<double>();
    public void AddGrade(double grade)
    {
        Console.WriteLine(grade);
    }
}