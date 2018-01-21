using System;
using System.Collections;
using System.Collections.Generic;

namespace Bigramy
{
    static class BigramCreate
    {
        static List<string> template = Alphabet.Template();
        public static List<string> Createlist(string text)
        {
            var lista = new List<string>();
            for (int i = 1; i < text.Length-1; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z' && text[i - 1] >= 'a' && text[i - 1] <= 'z')
                {
                    lista.Add(text[i-1]+text[i].ToString());
                }
            }
            return lista;
        }
        public static SortedList<string,float> Compare(List<string> toCompare)
        {
            var table = new SortedList<string,float>();
            foreach (var element in template)
            {
                table.Add(element, 0);
            }
            for (var i = 0; i < table.Count; i++)
            {
                var tempValue = 0;

                foreach (var element in toCompare)
                {
                    var tmpIndex = template[i];
                    if (tmpIndex == element)
                        tempValue++;
                }
                table[template[i]] = tempValue;
            }
            return table;
        }

        public static SortedList<string, float> PercentageOfUsage(SortedList<string, float> content)
        {
            float sum = 0;
            foreach (var element in content)
            {
                float tmp = float.Parse(element.Value.ToString());
                sum = sum + tmp;
            }
            var table = new SortedList<string, float>();
            foreach (var element in template)
            {
                float tmp = float.Parse(content[element].ToString())/sum;
                table.Add(element, tmp);
            }
            return table;
        }
    }
}
