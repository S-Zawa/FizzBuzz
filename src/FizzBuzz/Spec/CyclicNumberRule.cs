using FizzBuzz.Core;

namespace FizzBuzz.Spec
{
    public class CyclicNumberRule : IReplaceRule
    {
        public int Base { get; }

        public string Replacement { get; }

        public CyclicNumberRule(int @base, string replacement)
        {
            Base = @base;
            Replacement = replacement;
        }

        public string Apply(string carry, int number)
        {
            return carry += Replacement;
        }

        public bool IsMatch(string carry, int number)
        {
            return number % Base == 0;
        }
    }
}