using System.Text.RegularExpressions;
using ValidationProject.Configuration;

namespace ValidationProject.Validators
{
    /// <summary>
    /// Class that contains string validation methods.
    /// </summary>
    public class StringValidator
    {
        private readonly string _regexRule;

        /// <summary>
        /// Constructor for <see cref="StringValidator"/>.
        /// </summary>
        /// <param name="maxStringLength">The maximum string length used in validation.</param>
        public StringValidator(int maxStringLength)
        {
            _regexRule = Constants.REGEX_TEMPLATE.Replace(Constants.MAX_LENGTH_INFIX, maxStringLength.ToString());
        }

        /// <summary>
        /// Determines whether specified string value is valid.
        /// </summary>
        /// <param name="inputValue">Value of string to match.</param>
        /// <returns>True if the value is valid, False otherwise.</returns>
        public bool IsValid(string inputValue)
        {
            return Regex.IsMatch(inputValue, _regexRule);
        }
    }
}
