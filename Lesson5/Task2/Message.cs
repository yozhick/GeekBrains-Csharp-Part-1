using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task2
{
    public static class Message
    {
        public static string[] Words(string message, int letters)
        {
            var pattern = $"\\b(\\w{{1,{letters}}})\\b";
            var regex = new Regex(pattern);

            var matches = regex.Matches(message);
            var words = new string[matches.Count];

            for (int i = 0; i < matches.Count; i++)
            {
                words[i] = matches[i].Value;
            }

            return words;
        }

        public static string RemoveWords(string message, char symbol)
        {
            var pattern = $"\\b([^0-9\\W]+{symbol})\\b";
            var regex = new Regex(pattern);
            return regex.Replace(message, string.Empty);
        }

        public static string GetLongestWord(string message)
        {
            var words = GetWords(message);
            var longestWord = string.Empty;
            var count = 0;

            foreach(var word in words)
            {
                if (word.Length > count)
                {
                    longestWord = word;
                    count = word.Length;
                }
            }

            return longestWord;
        }

        public static string GetLongestWords(string message)
        {
            var words = GetWords(message);
            if (words.Length == 0)
                throw new Exception("Сообщение не содержит слов.");

            var wordsLookup = words.ToLookup(p => p.Length).OrderByDescending(p => p.Key);

            var stringBuilder = new StringBuilder();
            foreach(var word in wordsLookup.First())
            {
                stringBuilder.Append(word).Append(' ');
            }

            return stringBuilder.Remove(stringBuilder.Length - 1, 1).ToString();
        }

        public static Dictionary<string, int> FrequencyAnalysis(string message, string[] words)
        {
            var wordsCount = new Dictionary<string, int>();
            foreach(var word in words)
            {
                var lowerWord = word.ToLower();
                if (!wordsCount.ContainsKey(lowerWord))
                {
                    wordsCount.Add(lowerWord, 0);
                }
            }

            foreach(var word in GetWords(message))
            {
                var lowerWord = word.ToLower();
                if (wordsCount.ContainsKey(lowerWord))
                {
                    wordsCount[lowerWord]++;
                }
            }

            return wordsCount;
        }

        private static string[] GetWords(string message)
        {
            var pattern = @"\b([^0-9\W]+)\b";
            var regex = new Regex(pattern);
            var matches = regex.Matches(message);
            var words = from Match word in matches // Есть ли аналог этому выражению при использовании методов расширения?
                        select word.Value;
            return words.ToArray();
        }
    }
}
