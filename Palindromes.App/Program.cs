using Palindromes.Service;
using System.Diagnostics;

namespace Palindromes
{
    public class MainClass
    {
        static void Main()
        {
            //string input = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";
            //string input = "sqrrqzqxxxqq";
            string input = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";
            //string input = "sbqxaqaxqbss";
            //string input = "rdhdfhddhd342243dhddhfdhdr1112222111fdsfsdd456654dd";
            Console.WriteLine($"input string length: {input.Length}{Environment.NewLine}");

            string output;
            var palindromeHelper = new PalindromeHelper();
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            output = string.Join(Environment.NewLine, palindromeHelper.FindThreeLongestUniquePalindromes1(input));
            stopwatch.Stop();
            Console.WriteLine("===================== Solution 1 =====================");
            Console.WriteLine(output);
            Console.WriteLine($"Time elapsed : {stopwatch.Elapsed}");
            Console.WriteLine("======================================================");

            Console.WriteLine(Environment.NewLine);

            stopwatch.Restart();
            output = string.Join(Environment.NewLine, palindromeHelper.FindThreeLongestUniquePalindromes2(input));
            stopwatch.Stop();
            Console.WriteLine("===================== Solution 2 =====================");
            Console.WriteLine(output);
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");
            Console.WriteLine("======================================================");
        }
    }
}