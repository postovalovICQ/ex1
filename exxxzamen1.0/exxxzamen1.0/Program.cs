using System;
using System.IO;
namespace exxxzamen1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text;
            using (StreamReader sr = new StreamReader("1.txt")) //bin\Debug\netcoreapp3.1\1.txt
            {
                text = sr.ReadToEnd().ToCharArray();
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ',')
                    text[i] = '.';
            }
            using (StreamWriter sw = new StreamWriter("2.txt"))
            {
                foreach (char copy in text)
                    sw.Write(copy);
            }
        }
    }
}
