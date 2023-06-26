using System.Text.RegularExpressions;
using ValidationProject.Validators;
using Xunit;

namespace ValidationProject.Test
{

    /// <summary>
    /// Tests for <see cref="StringValidator"/>
    /// </summary>
    public class StringValidatorTest
    {
        private const int MAX_LENGTH = 10;
        private const string VALID_STRING = "Hello1!";

        private readonly StringValidator _sut;

        /// <summary>
        /// Setup
        /// </summary>
        public StringValidatorTest()
        {
            _sut = new StringValidator(MAX_LENGTH);
        }

        /// <summary>
        /// IsValid method returns true if a string value passes the validation
        /// </summary>
        [Theory]
        [InlineData("Hello1!")]
        [InlineData("8eHllo.")]
        [InlineData(".H21e4lMo!")]
        public void IsValid_SuccessfulFlow_ReturnsTrue(string testValue)
        {
            // Arrange / Act
            var result = _sut.IsValid(testValue);

            // Assert
            Assert.True(result);
        }

        /// <summary>
        /// IsValid method returns false if a string value has whitespaces
        /// </summary>
        [Theory]
        [InlineData(" Hello1!")]
        [InlineData("Hel lo1!")]
        [InlineData("Hello  1!")]
        [InlineData("Hello1! ")]
        public void IsValid_WhiteSpaceVerification_ReturnsFalse(string testValue)
        {
            // Arrange / Act
            var result = _sut.IsValid(testValue);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// IsValid method returns false if a string value is missing uppercase chars
        /// </summary>
        [Fact]
        public void IsValid_MissingUppercase_ReturnsFalse()
        {
            // Arrange
            var testValue = VALID_STRING.ToLower();

            // Act
            var result = _sut.IsValid(testValue);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// IsValid method returns false if a string value is missing lowercase chars
        /// </summary>
        [Fact]
        public void IsValid_MissingLowercase_ReturnsFalse()
        {
            // Arrange
            var testValue = VALID_STRING.ToUpper();

            // Act
            var result = _sut.IsValid(testValue);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// IsValid method returns false if a string value is missing digits
        /// </summary>
        [Fact]
        public void IsValid_MissingDigit_ReturnsFalse()
        {
            // Arrange
            var testValue = "Hello!";

            // Act
            var result = _sut.IsValid(testValue);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// IsValid method returns false if a string value is missing special symbol
        /// </summary>
        [Fact]
        public void IsValid_MissingSpecialSymbol_ReturnsFalse()
        {
            // Arrange
            var testValue = "Hello1";

            // Act
            var result = _sut.IsValid(testValue);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// IsValid method returns false if a string value is too short
        /// </summary>
        [Fact]
        public void IsValid_TooShortInput_ReturnsFalse()
        {
            // Arrange
            var testValue = "H";

            // Act
            var result = _sut.IsValid(testValue);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// IsValid method returns false if a string value is too long
        /// </summary>
        [Fact]
        public void IsValid_TooLongInput_ReturnsFalse()
        {
            // Arrange
            var testValue = "Hello1!Hello1!Hello1!Hello1!";

            // Act
            var result = _sut.IsValid(testValue);

            // Assert
            Assert.False(result);
        }
    }
}