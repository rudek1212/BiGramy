using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigramy2
{
    abstract class Frequencies
    {
        private static List<Bigram> Template(string path)
        {
            var test = File.ReadAllLines(path);
            var lista = new List<Bigram>();
            foreach (var s in test)
            {
                string[] words = s.Split(' ');
                lista.Add(new Bigram(words[0].ToLower(), Convert.ToSingle(words[1])));
            }
            double sum = 0;
            for (var i = lista.Count - 1; i >= 0; i--)
            {
                sum = sum + lista[i].value;
            }
            for (var i = lista.Count - 1; i >= 0; i--)
            {
                lista[i].value = lista[i].value / sum * 100;
            }
            for (var i = lista.Count - 1; i >= 0; i--)
            {
                if (!(lista[i].name[0] >= 'a' && lista[i].name[0] <= 'z' && lista[i].name[1] >= 'a' && lista[i].name[1] <= 'z'))
                {
                    lista.RemoveAt(i);
                }
            }
            lista.Sort((x, y) => x.name.CompareTo(y.name));

            return lista;
        }

        public static List<Bigram> English()
        {
            return Template(Directory.GetCurrentDirectory() + @"\Frequencies\english_bigrams.txt");
        }
        public static List<Bigram> Polish()
        {
            return Template(Directory.GetCurrentDirectory() + @"\Frequencies\polish_bigrams.txt");
        }
        public static List<Bigram> German()
        {
            return Template(Directory.GetCurrentDirectory() + @"\Frequencies\german_bigrams.txt");
        }
        public static List<Bigram> Spanish()
        {
            return Template(Directory.GetCurrentDirectory() + @"\Frequencies\spanish_bigrams.txt");
        }
        public static List<Bigram> French()
        {
            return Template(Directory.GetCurrentDirectory() + @"\Frequencies\french_bigrams.txt");
        }
    }
}
