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
            var tekst =
                "Pierwsze egzemplarze nieoznakowanych policyjnych BMW serii 3 trafily do funkcjonariuszy. Na razie to tylko 40 pojazdow, lecz do konca roku flote radiowozow zasili jeszcze 100 aut niemieckiej produkcji. W jakich okolicach beda patrolowac drogi i po czym je rozpoznac?";
            var obj = Bigrams.ApperanceOfBigramsPercentage(tekst);
            var amount = Bigrams.Count(tekst);
            Bigrams.RemoveNotUsed(obj);
            obj.Sort((x, y) => x.value.CompareTo(y.value));
            foreach (var bigram in obj)
            {
                Console.WriteLine(bigram);
            }
            Console.WriteLine(amount);
            Console.ReadKey();
        }
    }
}
