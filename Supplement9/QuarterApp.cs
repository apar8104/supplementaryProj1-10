namespace Supplement9;
public class QuarterApp
{
    private List<Quarter> quarters = new();

    /// <summary>
    /// Runs the console loop, allowing users to add quarters or quit. 
    /// </summary>
    public void Run()
    {
        while (true)
        {
            Console.Write("Enter a quarter value (or 'q' to quit): ");
            var input = Console.ReadLine();

            if (input.ToLower() == "q") break;

            if(float.TryParse(input, out float value))
            {
                try
                {
                    AddQuarter(value);
                    Console.WriteLine(GetQuartersDisplay());
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number or 'q' to quit.");
            }
        }
    }

    /// <summary>
    /// Adds a quarter to the list. Throws exception if out of range. 
    /// </summary>
    /// <param name="value">The float value representing the quarter. </param>
    public void AddQuarter(float value)
    {
        quarters.Add(new Quarter(value));
    }
    public string GetQuartersDisplay()
    {
        var groupedQuarters = quarters.GroupBy(q => q.GetQuarter())
        .OrderBy(g => g.Key)
        .Select(g => $"{g.Key * 0.25} - {(g.Key + 1) * 0.25}: {g.Count()} quarters");

        return string.Join("\n", groupedQuarters);
    }
}

class Program
{
    static void Main()
    {
        new QuarterApp().Run();
    }
}