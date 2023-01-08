namespace FizzBuzz // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var value = Console.ReadLine();
            Console.WriteLine(FizzBuzz(value));
        }

        public static string FizzBuzz(string value)
        {
            var number = 0;

            try
            {
                number = int.Parse(value);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{value}'");
                return "";
            }

            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}