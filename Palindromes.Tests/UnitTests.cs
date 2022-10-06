using Palindromes.Service;
using Xunit;

namespace Palindromes.Tests
{
    public class UnitTests
    {
        private readonly PalindromeHelper palindromeHelper = new();

        // Solution 1

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void HandleEmptyOrWhiteSpaceOrNullString_FindThreeLongestUniquePalindromes1(string input)
        {
            Assert.Throws<ArgumentNullException>(() => palindromeHelper.FindThreeLongestUniquePalindromes1(input));
        }

        [Theory]
        [InlineData("sbqxaaxqbs")]
        [InlineData("sbqxa1axqbs")]
        public void CheckEntireStringIsPalindrome_FindThreeLongestUniquePalindromes1(string input)
        {
            Assert.True(palindromeHelper.FindThreeLongestUniquePalindromes1(input).First().Text == input);
        }

        [Theory]
        [InlineData("qqqrdhdfhddhd342243dhddhfdhdrqqqasd12223332221zxwsddferrariirarref")]
        public void CheckThreeResultsHaveBeenFound_FindThreeLongestUniquePalindromes1(string input)
        {
            Assert.True(palindromeHelper.FindThreeLongestUniquePalindromes1(input).Count() == 3);
        }

        [Theory]
        [InlineData("qqqrdhdfhddhd342243dhddhfdhdrqqqasd12223332221zxwsddferrariirarref")]
        public void CheckFirstLongestPalindrome_FindThreeLongestUniquePalindromes1(string input)
        {
            Assert.True(palindromeHelper.FindThreeLongestUniquePalindromes1(input).ToList()[0].Text == "qqqrdhdfhddhd342243dhddhfdhdrqqq");
        }

        [Theory]
        [InlineData("qqqrdhdfhddhd342243dhddhfdhdrqqqasd12223332221zxwsddferrariirarref")]
        public void CheckSecondLongestPalindrome_FindSecondLongestUniquePalindromes1(string input)
        {
            Assert.False(palindromeHelper.FindThreeLongestUniquePalindromes1(input).ToList()[1].Text == "ferrariirarref");
        }

        [Theory]
        [InlineData("qqqrdhdfhddhd342243dhddhfdhdrqqqasd12223332221zxwsddferrariirarref")]
        public void CheckThirdLongestPalindrome_FindThreeLongestUniquePalindromes1(string input)
        {
            Assert.False(palindromeHelper.FindThreeLongestUniquePalindromes1(input).ToList()[2].Text == "12223332221");
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void HandleEmptyOrWhiteSpaceOrNullString_FindThreeLongestUniquePalindromes2(string input)
        {
            Assert.Throws<ArgumentNullException>(() => palindromeHelper.FindThreeLongestUniquePalindromes2(input));
        }

        [Theory]
        [InlineData("sbqxaaxqbs")]
        [InlineData("sbqxa1axqbs")]
        public void CheckEntireStringIsPalindrome_FindThreeLongestUniquePalindromes2(string input)
        {
            Assert.True(palindromeHelper.FindThreeLongestUniquePalindromes2(input).First().Text == input);
        }

        [Theory]
        [InlineData("qqqrdhdfhddhd342243dhddhfdhdrqqqasd12223332221zxwsddferrariirarref")]
        public void CheckThreeResultsHaveBeenFound_FindThreeLongestUniquePalindromes2(string input)
        {
            Assert.True(palindromeHelper.FindThreeLongestUniquePalindromes2(input).Count() == 3);
        }

        [Theory]
        [InlineData("qqqrdhdfhddhd342243dhddhfdhdrqqqasd12223332221zxwsddferrariirarref")]
        public void CheckFirstLongestPalindrome_FindThreeLongestUniquePalindromes2(string input)
        {
            Assert.True(palindromeHelper.FindThreeLongestUniquePalindromes2(input).ToList()[0].Text == "qqqrdhdfhddhd342243dhddhfdhdrqqq");
        }

        [Theory]
        [InlineData("qqqrdhdfhddhd342243dhddhfdhdrqqqasd12223332221zxwsddferrariirarref")]
        public void CheckSecondLongestPalindrome_FindSecondLongestUniquePalindromes2(string input)
        {
            Assert.True(palindromeHelper.FindThreeLongestUniquePalindromes2(input).ToList()[1].Text == "ferrariirarref");
        }

        [Theory]
        [InlineData("qqqrdhdfhddhd342243dhddhfdhdrqqqasd12223332221zxwsddferrariirarref")]
        public void CheckThirdLongestPalindrome_FindThreeLongestUniquePalindromes2(string input)
        {
            Assert.True(palindromeHelper.FindThreeLongestUniquePalindromes2(input).ToList()[2].Text == "12223332221");
        }
    }
}