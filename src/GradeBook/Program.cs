using GradeBook;

internal class Program
{
    private static void Main(string[] args)
    {

        Book book = new Book();
        book.AddGrade(8.9);

        // List<double> grades = new List<double>() {12.5, 39.03, 87.74, 88.83};
        // double sum = 0;
        // foreach(double grade in grades)
        // {
        //     sum += grade;
        // }
        // sum /= grades.Count;
        // Console.WriteLine($"The average is {sum:N1}");

        string hexString = "10";
        string[] hexArray = hexString.Split("");
        foreach(var s in hexArray)
        {
          Console.WriteLine(s);
        }
         Console.WriteLine(hexArray.GetType());
    }
}