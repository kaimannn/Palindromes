using System.Collections;

namespace Palindromes
{
    public class MainClass
    {
        static void Main()
        {
            //string input = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";
            string input = "sqrrqzxqrrrq";
            var palindromHelper = new PalindromHelper();
            Console.WriteLine(palindromHelper.FindThreeLongestUniquePalindromes(input));
        }
    }

    public class PalindromHelper
    {
        public string FindThreeLongestUniquePalindromes(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || input.Length == 1)
                return "The input string is not valid.";

            var palindromes = new Hashtable();
            for (int i = 0; i < input.Length; i++)
            {
                var oddPalindrome = GetPalindromeExpandingFromMiddle(input, i, i);
                var evenpalindrome = GetPalindromeExpandingFromMiddle(input, i, i + 1);

                if (oddPalindrome != null && evenpalindrome != null)
                {
                    if (oddPalindrome.Length > evenpalindrome.Length)
                    {
                        if (!palindromes.ContainsKey(oddPalindrome.Text))
                            palindromes.Add(oddPalindrome.Text, oddPalindrome);
                    }
                    else
                    {
                        if (!palindromes.ContainsKey(evenpalindrome.Text))
                            palindromes.Add(evenpalindrome.Text, evenpalindrome);
                    }

                    continue;
                }

                if (oddPalindrome != null && !palindromes.ContainsKey(oddPalindrome.Text))
                    palindromes.Add(oddPalindrome.Text, oddPalindrome);
                else if (evenpalindrome != null && !palindromes.ContainsKey(evenpalindrome.Text))
                    palindromes.Add(evenpalindrome.Text, evenpalindrome);
            }

            return string.Join("\r\n", palindromes.Values.Cast<PalindromeInfo>()
                .OrderByDescending(p => p.Length)
                .Select(p => $"Text: {p.Text}, Index: {p.StartIndex}, Length: {p.Length}")
                .Take(3));
        }

        private PalindromeInfo GetPalindromeExpandingFromMiddle(string input, int i, int j)
        {
            while (i >= 0 && j < input.Length && input[i] == input[j])
            {
                i--;
                j++;
            }

            int length = j - i - 1;
            int startIndex = i + 1;

            if (length <= 1)
                return null;

            return new PalindromeInfo
            {
                StartIndex = startIndex,
                Length = length,
                Text = input.Substring(startIndex, length)
            };
        }

        public class PalindromeInfo
        {
            public string Text { get; set; }
            public int StartIndex { get; set; }
            public int Length { get; set; }
        }
    }
}