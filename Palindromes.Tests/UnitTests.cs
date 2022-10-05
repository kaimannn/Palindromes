using Palindromes.Service;
using Xunit;

namespace Palindromes.Tests
{
    public class UnitTests
    {
        private readonly PalindromeHelper palindromeHelper = new();

        [Fact]
        public void FindThreeLongestUniquePalindromes1_HandleEmptyString()
        {
            Assert.Throws<ArgumentNullException>(() => palindromeHelper.FindThreeLongestUniquePalindromes1(""));
        }

        [Fact]
        public void FindThreeLongestUniquePalindromes1_HandleWhiteSpaceString()
        {
            Assert.Throws<ArgumentNullException>(() => palindromeHelper.FindThreeLongestUniquePalindromes1(" "));
        }

        [Fact]
        public void FindThreeLongestUniquePalindromes1_HandleNullString()
        {
            Assert.Throws<ArgumentNullException>(() => palindromeHelper.FindThreeLongestUniquePalindromes1(null));
        }

        [Fact]
        public void FindThreeLongestUniquePalindromes1_DoNotCountSubPalindromes()
        {
            Assert.True(palindromeHelper.FindThreeLongestUniquePalindromes1("sqrrqz").Count() == 2); // {qrrqz,rr}
        }

        [Fact]
        public void FindThreeLongestUniquePalindromes2_HandleEmptyString()
        {
            Assert.Throws<ArgumentNullException>(() => palindromeHelper.FindThreeLongestUniquePalindromes2(""));
        }

        [Fact]
        public void FindThreeLongestUniquePalindromes2_HandleWhiteSpaceString()
        {
            Assert.Throws<ArgumentNullException>(() => palindromeHelper.FindThreeLongestUniquePalindromes2(" "));
        }

        [Fact]
        public void FindThreeLongestUniquePalindromes2_HandleNullString()
        {
            Assert.Throws<ArgumentNullException>(() => palindromeHelper.FindThreeLongestUniquePalindromes2(null));
        }

        [Fact]
        public void FindThreeLongestUniquePalindromes2_CountSubPalindromes()
        {
            Assert.True(palindromeHelper.FindThreeLongestUniquePalindromes2("sqrrqz").Count() == 1); // {qrrqz}
        }
    }
}