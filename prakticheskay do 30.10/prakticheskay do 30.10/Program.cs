using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakticheskay_do_30._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            string clubName = "ClubName";
            foreach (char letter in clubName)
            {
                Console.WriteLine(letter);
            }

            // 2
            string word = "example";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(word[i]);
            }

            // 3
            string s1 = "example";
            string s2 = "";
            for (int i = 0; i < s1.Length; i++)
            {
                if (i % 2 != 0)
                {
                    s2 += s1[i];
                }
            }
            Console.WriteLine(s2);

            // 4
            string s = "example";
            char[] tArray = s.ToCharArray();
            Array.Reverse(tArray);
            string t = new string(tArray);
            Console.WriteLine(t);

            // 5
            char character = 'A';
            int count = 5;
            string result = new string(character, count);
            Console.WriteLine(result);

            // 6
            string wordWithSymbols = "+example–";
            Console.WriteLine(wordWithSymbols);

            // 7
            string wordWithStars = "*example*";
            Console.WriteLine(wordWithStars);

            // 8
            string firstWord = "example";
            string secondWord = "replace";
            string replacedWord = firstWord + secondWord.Substring(firstWord.Length);
            Console.WriteLine(replacedWord);

            // 9
            string sentence = "This is an example sentence.";
            foreach (char letter in sentence)
            {
                if (char.ToLower(letter) == 'и')
                {
                    Console.WriteLine(letter);
                }
            }

            // 10
            string sentenceToPrint = "This is an example sentence.";
            for (int i = 2; i < sentenceToPrint.Length; i += 3)
            {
                Console.WriteLine(sentenceToPrint[i]);
            }

            // 11
            string sentenceToSearch = "This is another example sentence.";
            char char1 = 'a';
            char char2 = 'e';
            for (int i = 0; i < sentenceToSearch.Length; i++)
            {
                if (sentenceToSearch[i] == char1 || sentenceToSearch[i] == char2)
                {
                    Console.WriteLine($"Character '{sentenceToSearch[i]}' found at position {i}");
                }
            }

            // 12
            string sentenceToPrint2 = "This is another example sentence.";
            for (int i = 0; i < sentenceToPrint2.Length; i++)
            {
                if (i == 0 || i == 1 || i == 4 || i == 5 || i == 8 || i == 9)
                {
                    Console.WriteLine(sentenceToPrint2[i]);
                }
            }

            // 13
            string sentenceToCountSpaces = "This is a sentence with spaces.";
            int spaceCount = 0;
            foreach (char letter in sentenceToCountSpaces)
            {
                if (letter == ' ')
                {
                    spaceCount++;
                }
            }
            Console.WriteLine($"Number of spaces: {spaceCount}");

            // 14
            string sentenceToCountA = "This is an example sentence with a few 'a' characters.";
            int totalCharacters = sentenceToCountA.Length;
            int aCount = 0;
            foreach (char letter in sentenceToCountA)
            {
                if (char.ToLower(letter) == 'a')
                {
                    aCount++;
                }
            }
            double percentageA = (double)aCount / totalCharacters * 100;
            Console.WriteLine($"Percentage of 'a' characters: {percentageA:F2}%");

            // 15
            string text = "This+is+an*example+text*with+symbols.";
            int plusCount = 0;
            int starCount = 0;
            foreach (char character in text)
            {
                if (character == '+')
                {
                    plusCount++;
                }
                else if (character == '*')
                {
                    starCount++;
                }
            }
            Console.WriteLine($"'+' count: {plusCount}, '*' count: {starCount}");

            // 16
            string sentenceToCountVowels = "This is a sentence with some vowels.";
            int vowelCount = 0;
            foreach (char letter in sentenceToCountVowels)
            {
                if ("AEIOUaeiou".Contains(letter))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine($"Number of vowels: {vowelCount}");

            // 17
            string sentenceToCheckWords = "This is a test sentence.";
            string[] words = sentenceToCheckWords.Split(' ');
            bool moreThanThreeWords = words.Length > 3;
            Console.WriteLine($"More than three words: {moreThanThreeWords}");

            // 18
            string textToCheckConsecutive = "AABBBCCCCCDDDDEEEE";
            int consecutiveCount = 1;
            bool hasFiveConsecutive = false;
            for (int i = 1; i < textToCheckConsecutive.Length; i++)
            {
                if (textToCheckConsecutive[i] == textToCheckConsecutive[i - 1])
                {
                    consecutiveCount++;
                    if (consecutiveCount == 5)
                    {
                        hasFiveConsecutive = true;
                        break;
                    }
                }
                else
                {
                    consecutiveCount = 1;
                }
            }
            Console.WriteLine($"Has five consecutive identical characters: {hasFiveConsecutive}");
            Console.ReadKey();
        }
        
    }
}
  

