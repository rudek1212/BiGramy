using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Bigramy
{
    class Program
    {
        static void Main()
        {
            var lista1 = new List<Bigram>(); 




            //pltext1
            PercentageToFile.ToFile(Directory.GetCurrentDirectory() + @"\Polish\pl1.txt", Directory.GetCurrentDirectory() + @"\plText1Percentage.txt");
            //pltext2
            PercentageToFile.ToFile(Directory.GetCurrentDirectory() + @"\Polish\pl2.txt", Directory.GetCurrentDirectory() + @"\plText2Percentage.txt");
            //pltext3
            PercentageToFile.ToFile(Directory.GetCurrentDirectory() + @"\Polish\pl3.txt", Directory.GetCurrentDirectory() + @"\plText3Percentage.txt");
            //pltext4
            PercentageToFile.ToFile(Directory.GetCurrentDirectory() + @"\Polish\pl4.txt", Directory.GetCurrentDirectory() + @"\plText4Percentage.txt");
            //pltext5
            PercentageToFile.ToFile(Directory.GetCurrentDirectory() + @"\Polish\pl5.txt", Directory.GetCurrentDirectory() + @"\plText5Percentage.txt");

            /////////////////////////////////////////////////////
            //hashtable.Cast<DictionaryEntry>().OrderBy(entry => entry.Value).ToList()
            var tablepltext1 = BigramCreate.PercentageOfUsage(BigramCreate.Compare(BigramCreate.Createlist(File.ReadAllText(Directory.GetCurrentDirectory() + @"\Polish\pl1.txt").ToLower())));
            foreach (var element in tablepltext1)
                Console.WriteLine(element.Value);
            Console.ReadKey();
        }
    }
}
