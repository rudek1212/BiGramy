using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigramy2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pl1 = Bigrams.ApperanceOfBigramsPercentage(Texts.pl1);
            var pl2 = Bigrams.ApperanceOfBigramsPercentage(Texts.pl2);
            var pl3 = Bigrams.ApperanceOfBigramsPercentage(Texts.pl3);
            var pl4 = Bigrams.ApperanceOfBigramsPercentage(Texts.pl4);
            var pl5 = Bigrams.ApperanceOfBigramsPercentage(Texts.pl5);
            var eng1 = Bigrams.ApperanceOfBigramsPercentage(Texts.eng1);
            var eng2 = Bigrams.ApperanceOfBigramsPercentage(Texts.eng2);
            var eng3 = Bigrams.ApperanceOfBigramsPercentage(Texts.eng3);
            var eng4 = Bigrams.ApperanceOfBigramsPercentage(Texts.eng4);
            var eng5 = Bigrams.ApperanceOfBigramsPercentage(Texts.eng5);
            Console.WriteLine(Compare.CheckLanguage(pl1));
            Console.WriteLine(Compare.CheckLanguage(pl2));
            Console.WriteLine(Compare.CheckLanguage(pl3));
            Console.WriteLine(Compare.CheckLanguage(pl4));
            Console.WriteLine(Compare.CheckLanguage(pl5));
            Console.WriteLine(Compare.CheckLanguage(eng1));
            Console.WriteLine(Compare.CheckLanguage(eng2));
            Console.WriteLine(Compare.CheckLanguage(eng3));
            Console.WriteLine(Compare.CheckLanguage(eng4));
            Console.WriteLine(Compare.CheckLanguage(eng5));

            Console.ReadKey();
        }
    }
}
