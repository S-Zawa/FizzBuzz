namespace FizzBuzz.Core
{
    public class NumberConverter
    {
        protected IReplaceRule[] Rules
        {
            get;
        }

        public NumberConverter(IReplaceRule[] rules)
        {
            Rules = rules;
        }

        public string ConvertToString(int number)
        {
            var carry = "";
            foreach (var rule in Rules)
            {
                if (rule.IsMatch(carry, number))
                {
                    carry = rule.Apply(carry, number);
                }
            }

            return carry;
        }
    }
}