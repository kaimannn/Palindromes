namespace Palindromes.Service
{
    public class PalindromeHelper
    {
        public IEnumerable<PalindromeInfo> FindThreeLongestUniquePalindromes1(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input));

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
                .Select(p => new PalindromeInfo { Text = p, StartIndex = input.IndexOf(p), Length = p.Length });
        }

        public IEnumerable<PalindromeInfo> FindThreeLongestUniquePalindromes2(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input));

            var palindromes = new HashSet<string>();
            for (int i = 0; i < input.Length; i++)
            {
                var oddPalindrome = GetPalindromeExpandingFromMiddle(input, i, i);
                var evenpalindrome = GetPalindromeExpandingFromMiddle(input, i, i + 1);

                if (oddPalindrome != null)
                    palindromes.Add(oddPalindrome);
                else if (evenpalindrome != null)
                    palindromes.Add(evenpalindrome);
            }

            return palindromes.OrderByDescending(p => p.Length).Take(3)
                .Select(p => new PalindromeInfo { Text = p, StartIndex = input.IndexOf(p), Length = p.Length });
        }

        private string GetPalindromeExpandingFromMiddle(string input, int i, int j)
        {
            bool isEven = i == j;

            while (i >= 0 && j < input.Length && input[i] == input[j])
            {
                i--;
                j++;
            }

            int length = j - i - 1;

            if ((length == 0 && !isEven) || (length == 1 && isEven))
                return null;

            int startIndex = i + 1;

            return input.Substring(startIndex, length);
        }

        public class PalindromeInfo
        {
            public string Text { get; set; }
            public int StartIndex { get; set; }
            public int Length { get; set; }

            public override string ToString() => $"Text: {Text}, Index: {StartIndex}, Length: {Length}";
        }
    }
}