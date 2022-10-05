using Palindromes.Service;
using System.Diagnostics;

namespace Palindromes
{
    public class MainClass
    {
        static void Main()
        {
            //string input = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";
            string input = "sqrrqzxqrxrq";
            //string input = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";
            Console.WriteLine($"input string length: {input.Length}{Environment.NewLine}");

            string output;
            var palindromeHelper = new PalindromeHelper();
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            output = string.Join(Environment.NewLine, palindromeHelper.FindThreeLongestUniquePalindromes1(input));
            stopwatch.Stop();
            Console.WriteLine("===================== FindThreeLongestUniquePalindromes1 =====================");
            Console.WriteLine(output);
            Console.WriteLine($"Time elapsed : {stopwatch.Elapsed}");
            Console.WriteLine("==============================================================================");

            Console.WriteLine(Environment.NewLine);

            stopwatch.Restart();
            output = string.Join(Environment.NewLine, palindromeHelper.FindThreeLongestUniquePalindromes2(input));
            stopwatch.Stop();
            Console.WriteLine("===================== FindThreeLongestUniquePalindromes2 =====================");
            Console.WriteLine(output);
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");
            Console.WriteLine("==============================================================================");
        }
    }
}