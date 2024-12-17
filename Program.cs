

using System.Linq;
using System.Text;

namespace Assingment7_2_2
{
    internal class Program
    {
        //Given a string s, reverse only all the vowels in the string and return it.
        //The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
        //BOTH CHARACTERS IN SWAP MUST BE VOWELS(track found vowel with a pointer, i sould alwaus be pointer +1)
        static void Main(string[] args)
        {
            //Console.WriteLine(ReverseVowels("IceCreAm"));
            Console.WriteLine(PointerReverseVowels("IceCreAm"));
        }

        // Pointers used to keep track of vowels. If vowel is not found increment left or decrement right.
        // If pointers are both vowels, swap indexes, increment left and decrement right
        // O(n) Time O(1) Space
        static string PointerReverseVowels(string word)
        {
            StringBuilder sb = new StringBuilder(word);
            string vowelTest = "aeiouAEIOU";


            int leftPointer = 0;
            int rightPointer = word.Length - 1;
            while (leftPointer < rightPointer)
            {
                if (vowelTest.Contains(word[leftPointer]) && vowelTest.Contains(word[rightPointer]))
                {
                    (sb[leftPointer], sb[rightPointer]) = (sb[rightPointer], sb[leftPointer]);
                    leftPointer++;
                    rightPointer--;
                }
                if (!vowelTest.Contains(word[leftPointer]))
                {
                    leftPointer++;
                }
                if (!vowelTest.Contains(word[rightPointer]))
                {
                    rightPointer--;
                }
            }
            return sb.ToString();
        }




        // O(n) Time, O(n) Space
        static string ReverseVowels(string word)
        {
            StringBuilder sb = new StringBuilder();
            char[] chars = new char[word.Length];
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if ("aeiouAEIOU".Contains(word[word.Length - i - 1]))
                {
                    chars[count] = (word[word.Length - i - 1]);
                    count++;
                }
            }
            Print(chars);
            count = 0;
            for (int i = 0; i < word.Length; i++)
            {

                if ("aeiouAEIOU".Contains(word[i]))
                {
                    sb.Append(chars[count]);
                    count++;
                }
                else
                {
                    sb.Append(word[i]);
                }
            }
            return sb.ToString();
        }

        static void Print(char[] arr)
        {
            Console.Write("|");
            foreach (char i in arr)
            {
                Console.Write($" {i} |");
            }
            Console.WriteLine();
        }
    }
}
