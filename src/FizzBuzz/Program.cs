using FizzBuzz.Core;
using FizzBuzz.Spec;

namespace FizzBuzz // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var number = 0;
            try
            {
                number = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
                return;
            }

            var fizzBuzz = new NumberConverter(new IReplaceRule[]
            {
                new CyclicNumberRule(3, "Fizz"),
                new CyclicNumberRule(5, "Buzz"),
                new PassThroughRule()
            });
            var result = fizzBuzz.ConvertToString(number);

            Console.WriteLine(result);
        }
    }
}