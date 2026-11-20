

namespace OnlineLearningPlatform;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Learning Platform");
        Console.WriteLine("========================");

        using (AppDbContext context = new AppDbContext())
        {
         
        }

        Console.WriteLine("Program Finished.");
    }
}
