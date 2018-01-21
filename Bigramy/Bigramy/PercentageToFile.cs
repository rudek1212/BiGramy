using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Bigramy
{
    abstract class PercentageToFile
    {
        static public void ToFile(string path, string toSavePath)
        {
            var text = File.ReadAllText(path).ToLower();
            var BigramOfText = BigramCreate.Compare(BigramCreate.Createlist(text));
            var usageOfText = BigramCreate.PercentageOfUsage(BigramOfText);
            List<String> TableOfUsage = new List<string>();
            foreach (var element in usageOfText)
            {
                TableOfUsage.Add(element.Key + " " + element.Value);
            }
            TableOfUsage.Sort();
            File.WriteAllLines(toSavePath,TableOfUsage);
        }
    }
}
