using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigramy
{
    public class Alphabet
    {
        private static string alphabet = "abcdefghijklmnopqrstuwxyz";

        public static void PrintAlphabet()
        {

            foreach (var character in alphabet)
            {
                foreach (var letter in alphabet)
                {
                    Console.Write(character + "" + letter + " ");
                }
                Console.WriteLine();
            }
        }

        public static List<string> Template()
        {
            var list = new List<String>();
            foreach (var first in alphabet)
            {
                foreach (var second in alphabet)
                {
                    list.Add(first+second.ToString());
                }
            }
            return list;
        }
    }
}
