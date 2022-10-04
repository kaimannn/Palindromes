using System.Collections;

namespace Palindromes
{
    public class MainClass
    {
        static void Main()
        {
            string input = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";

            if (string.IsNullOrWhiteSpace(input) || input.Length == 1)
                Console.WriteLine("The input string is not valid.");

            //string input = "sqrrqzxqrrrq";
            var s = string.Join("\r\n", PalindromHelper.FindThreeLongestUniquePalindromes2(input));
            Console.WriteLine(s);
        }
    }

    public class PalindromHelper
    {
        public static IEnumerable<PalindromeInfo2> FindThreeLongestUniquePalindromes2(string input)
        {
            var palindromes = new HashSet<string>();
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                int position = i;
                while (true)
                {
                    position = input.IndexOf(c, position + 1);
                    if (position == -1)
                        break;

                    string text = input.Substring(i, position - i + 1);
                    if (text == new string(text.Reverse().ToArray()))
                        palindromes.Add(text);
                }
            }

            return palindromes.OrderByDescending(p => p.Length).Take(3)
                .Select(p => new PalindromeInfo2 { Text = p, StartIndex = input.IndexOf(p), Length = p.Length });
        }

        public class PalindromeInfo2
        {
            public override string ToString()
            {
                return $"Text: {Text}, Index: {StartIndex}, Length: {Length}";
            }
            public string Text { get; set; }
            public int StartIndex { get; set; }
            public int Length { get; set; }
        }

        public static string FindThreeLongestUniquePalindromes(string input)
        {
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

        private static PalindromeInfo GetPalindromeExpandingFromMiddle(string input, int i, int j)
        {
            while (i >= 0 && j < input.Length && input[i] == input[j])
            {
                i--;
                j++;
            }

            int length = j - i - 1;
            if (length <= 1)
                return null;

            int startIndex = i + 1;

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