using System;
using System.Collections.Generic;
using System.Linq;

namespace Bigramy2
{
    abstract class Compare
    {
        public static string CheckLanguage(List<Bigram> bigrams)
        {
            var englishList = Frequencies.English();
            var polishList = Frequencies.Polish();
            var frenchList = Frequencies.French();
            var spanishList = Frequencies.Spanish();
            var germanList = Frequencies.German();

            int[] languagePropability = {0,0,0,0,0};


            // for each bigram, in list check for absolute value of subtraction frequencies then add them to table
            foreach (var bigram in bigrams)
            {
                //index of 0 - english, 1 - polish, 2 - french, 3 - spanish, 4 - german;
                double[] table = new double[5];
                foreach (var bigram1 in englishList)
                {
                    if (bigram.name == bigram1.name){
                        table[0] = Math.Abs(bigram.value - bigram1.value);
                        break;
                    }
                }
                foreach (var bigram1 in polishList)
                {
                    if (bigram.name == bigram1.name){
                        table[1] = Math.Abs(bigram.value - bigram1.value);
                        break;
                    }
                }
                foreach (var bigram1 in frenchList)
                {
                    if (bigram.name == bigram1.name){
                        table[2] = Math.Abs(bigram.value - bigram1.value);
                        break;
                    }
                }
                foreach (var bigram1 in spanishList)
                {
                    if (bigram.name == bigram1.name){
                        table[3] = Math.Abs(bigram.value - bigram1.value);
                        break;
                    }
                }
                foreach (var bigram1 in germanList)
                {
                    if (bigram.name == bigram1.name){
                        table[4] = Math.Abs(bigram.value - bigram1.value);
                        break;
                    }
                }

                //chcecking for minimum distance betweeen chcecked bigram and template frequency
                var min = CheckForMin(table);
                for (int i = 0; i < 4; i++)
                {
                    //table[i] == min
                    if (table[i] == min)
                    {
                        languagePropability[i]++;
                        break;
                    }
                }
            }
            var max = CheckForMax(languagePropability);
            var sum = languagePropability.Sum();

            if (max == languagePropability[0]){
                float freq = (float)languagePropability[0] / sum * 100;
                return "English " + freq + "%";
            }
            if (max == languagePropability[1]){
                var freq = (float)languagePropability[1] / sum * 100;
                return "Polish " + freq + "%";
            }
            if (max == languagePropability[2]){
                var freq = (float)languagePropability[2] / sum * 100;
                return "French " + freq + "%";
            }
            if (max == languagePropability[3]){
                var freq = (float)languagePropability[3] / sum * 100;
                return "Spanish " + freq + "%";
            }
            if (max == languagePropability[4]){
                var freq = (float)languagePropability[4] / sum * 100;
                return "German " + freq + "%";
            }
            return "Language not recognizeable";
        }

        private static int CheckForMax(int[] tab)
        {
            int max = tab[0];
            foreach (var d in tab)
            {
                if (d > max)
                    max = d;
            }
            return max;
        }
        private static double CheckForMin(double[] tab)
        {
            double min = tab[0];
            foreach (var d in tab)
            {
                if (d < min)
                    min = d;
            }
            return min;
        }

    }
}
