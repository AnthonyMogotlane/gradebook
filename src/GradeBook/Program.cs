using GradeBook;

internal class Program
{
    private static void Main(string[] args)
    {

        Book book = new Book();
        book.AddGrade(8.9);
        book.AddGrade(12.9);
        book.AddGrade(7.5);
        book.AddGrade(5);

        book.ShowStatistics();
    }
}