namespace FizzBuzz.Core
{
    public interface IReplaceRule
    {
        public bool IsMatch(string carry, int number);

        public string Apply(string carry, int number);
    }
}