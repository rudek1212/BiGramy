using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigramy2
{
    public abstract class Texts
    {
        public static string eng1 = File.ReadAllText(Directory.GetCurrentDirectory() + @"\English\eng1.txt");
        public static string eng2 = File.ReadAllText(Directory.GetCurrentDirectory() + @"\English\eng2.txt");
        public static string eng3 = File.ReadAllText(Directory.GetCurrentDirectory() + @"\English\eng3.txt");
        public static string eng4 = File.ReadAllText(Directory.GetCurrentDirectory() + @"\English\eng4.txt");
        public static string eng5 = File.ReadAllText(Directory.GetCurrentDirectory() + @"\English\eng5.txt");

        public static string pl1 = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Polish\pl1.txt");
        public static string pl2 = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Polish\pl2.txt");
        public static string pl3 = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Polish\pl3.txt");
        public static string pl4 = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Polish\pl4.txt");
        public static string pl5 = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Polish\pl5.txt");

        public static string ger1;
        public static string ger2;
        public static string ger3;
        public static string ger4;
        public static string ger5;

        public static string spa1;
        public static string spa2;
        public static string spa3;
        public static string spa4;
        public static string spa5;

        public static string fr1;
        public static string fr2;
        public static string fr3;
        public static string fr4;
        public static string fr5;

    }
}
