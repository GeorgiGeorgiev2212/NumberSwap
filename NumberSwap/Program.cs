internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input the 1st number:");
        int firstNumber = int.Parse(Console.ReadLine()); // Fixed variable name

        Console.WriteLine("Input the 2nd number:");
        int secondNumber = int.Parse(Console.ReadLine()); // Fixed variable name

        Console.WriteLine($"First Number: {secondNumber}"); // Corrected string interpolation
        Console.WriteLine($"Second Number: {firstNumber}"); // Corrected string interpolation
    }
}
