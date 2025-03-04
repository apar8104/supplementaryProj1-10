namespace Supplement9;
public class QuarterApp
{
    private List<Quarter> quarters = new();
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
    public void AddQuarter(float value)
    {
        throw new NotImplementedException();
    }
    public string GetQuartersDisplay()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        new QuarterApp().Run();
    }
}