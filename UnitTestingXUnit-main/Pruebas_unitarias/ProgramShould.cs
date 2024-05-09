using Xunit;
using Microsoft.Extensions.Logging.Abstractions;
using StringManipulation;
using Microsoft.Extensions.Logging;

namespace Pruebas_unitarias.Tests
{
    public class ProgramShould
    {
        private readonly StringOperations _stringOperations;
        private readonly ILogger<StringOperations> _logger;

        public ProgramShould()
        {
            _logger = new NullLogger<StringOperations>();
            _stringOperations = new StringOperations(_logger);
        }

        [Fact]
        public void ConcatenateStringsCorrectly()
        {
            string result = _stringOperations.ConcatenateStrings("Hola", "Mundo");
            Assert.Equal("Hola Mundo", result);
        }

        [Fact]
        public void ReverseStringCorrectly()
        {
            string result = _stringOperations.ReverseString("Hola");
            Assert.Equal("aloH", result);
        }

        [Fact]
        public void GetStringLengthCorrectly()
        {
            int length = _stringOperations.GetStringLength("Hola");
            Assert.Equal(4, length);
        }

        [Fact]
        public void RemoveWhitespaceCorrectly()
        {
            string result = _stringOperations.RemoveWhitespace("H o l a");
            Assert.Equal("Hola", result);
        }

        [Fact]
        public void TruncateStringCorrectly()
        {
            string result = _stringOperations.TruncateString("Hola Mundo", 4);
            Assert.Equal("Hola", result);
        }

        [Fact]
        public void IsPalindromeCorrectly()
        {
            bool isPalindrome = _stringOperations.IsPalindrome("anilina");
            Assert.True(isPalindrome);
        }

        [Fact]
        public void CountOccurrencesCorrectly()
        {
            int count = _stringOperations.CountOccurrences("Hola Mundo", 'o');
            Assert.Equal(2, count);
        }

        [Fact]
        public void PluralizeCorrectly()
        {
            string result = _stringOperations.Pluralize("manzana");
            Assert.Equal("manzanas", result);
        }

        [Fact]
        public void QuantityInWordsCorrectly()
        {
            string result = _stringOperations.QuantintyInWords("manzana", 5);
            Assert.Equal("cinco manzanas", result);
        }

        [Fact]
        public void FromRomanToNumberCorrectly()
        {
            int number = _stringOperations.FromRomanToNumber("V");
            Assert.Equal(5, number);
        }

    }
}
