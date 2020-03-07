using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Part2
{
   public static class ListWordsOperation
    {
    
        public static void findDuplicateWords (List<string> words)
        {
            Dictionary<string, int> amountOfWords = new Dictionary<string, int>();
            string wordSorted;

            for (int i = 0; i < words.Count; i++)
            {
                char[] chars = words[i].ToCharArray();
                Array.Sort(chars);
                wordSorted = new string(chars);

                if (amountOfWords.TryGetValue(wordSorted, out int amount))
                {
                    amountOfWords[wordSorted] = amount + 1;
                }
                else
                {
                    amountOfWords.Add(wordSorted, 1);
                }
            }
            PrintDictionary(amountOfWords);
        }

        public static void PrintDictionary(Dictionary<string, int> dictionary)
        {
            foreach (var word in dictionary)
            {
                Console.WriteLine($"{word.Key} {word.Value}");
            }
        }

    }
}
