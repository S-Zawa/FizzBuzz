using FizzBuzz.Core;

namespace FizzBuzz.Spec
{
    public class PassThroughRule : IReplaceRule
    {
        public string Apply(string carry, int number)
        {
            return number.ToString();
        }

        public bool IsMatch(string carry, int number)
        {
            return carry == "";
        }
    }
}