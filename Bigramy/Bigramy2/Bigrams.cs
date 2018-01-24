using System;
using System.Collections.Generic;

namespace Bigramy2
{
    public abstract class Bigrams
    {
        private static string alphabet = "abcdefghijklmnopqrstuwxyz";

        /// <summary>
        /// Creating object list of all possible bigrams.
        /// </summary>
        /// <returns></returns>
        private static List<Bigram> Template()
        {
            var list = new List<Bigram>();
            foreach (var first in alphabet)
            {
                foreach (var second in alphabet)
                {
                    list.Add(new Bigram(first + second.ToString(),0));
                }
            }
            return list;
        }

        /// <summary>
        /// Creating list of all bigrams in string.
        /// </summary>
        /// <param name="text">String of text to convert.</param>
        /// <returns></returns>
        public static List<string> CreateListOfBigrams(string text)
        {
            var lista = new List<string>();
            for (int i = 1; i < text.Length - 1; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z' && text[i - 1] >= 'a' && text[i - 1] <= 'z')
                {
                    lista.Add(text[i - 1] + text[i].ToString());
                }
            }
            return lista;
        }

        /// <summary>
        /// Creates list of bigrams and its amount in text.
        /// </summary>
        /// <param name="text">String of text</param>
        public static List<Bigram> ApperanceOfBigrams(string text)
        {
            var bigrams = CreateListOfBigrams(text);
            var list = Template();
            foreach (var bigram in bigrams)
            {
                foreach (var obj in list)
                {
                    if (bigram == obj.name)
                    {
                        obj.value = obj.value + 1;
                    }
                }
            }
            list.Sort((x, y) => x.name.CompareTo(y.name));
            RemoveNotUsed(list);
            return list;
        }

        /// <summary>
        /// Returns list of bigrams and its percentage apperance in text.
        /// </summary>
        /// <param name="text">String of text</param>
        /// <returns></returns>
        public static List<Bigram> ApperanceOfBigramsPercentage(string text)
        {
            var list = ApperanceOfBigrams(text);
            ToPercentage(list);
            return list;
        }

        /// <summary>
        /// Returns amount of bigrams in text.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int Count(List<Bigram> list)
        {
            int amount = 0;
            foreach (var bigram in list)
            {
                amount = amount + (int)bigram.value;
            }

            return amount;
        }

        /// <summary>
        /// Returns amount of bigrams in text.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int Count(string text)
        {
            return Count(ApperanceOfBigrams(text));
        }

        private static void ToPercentage(List<Bigram> list)
        {
            var amount = Count(list);
            foreach (var bigram in list)
            {
                bigram.value = bigram.value / amount *100;
            }
        }

        /// <summary>
        /// Removes not used bigrams in list
        /// </summary>
        /// <param name="list"></param>
        public static void RemoveNotUsed(List<Bigram> list)
        {
            for (int i = list.Count - 1; i >= 0; i-- )
            {
                if (list[i].value == 0)
                    list.RemoveAt(i);
            }
        }

        
    }
}
