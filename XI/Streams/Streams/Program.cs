using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример от презентацията

            //StreamReader reader = new StreamReader(@"/School/C#/text.txt");
            //StreamWriter writer = new StreamWriter(@"/School/C#/text2.txt");
            /*using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while(line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }*/

            //Задача 1

            /*using(reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 0)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                    line = reader.ReadLine();
                }
            }*/

            //Задача 2

            /*using(var reader = new StreamReader("/School/C#/text.txt"))
            {
                using(var writer = new StreamWriter("/School/C#/newText.txt"))
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                        writer.WriteLine("Line {0}: {1}", lineNumber, line);
                        line = reader.ReadLine();
                    }
                }
            }*/

            //Задача 3

            using (var reader = new StreamReader("/School/C#/words.txt"))
            {
                using (var reader2 = new StreamReader("/School/C#/textt.txt"))
                {
                    using (var writer = new StreamWriter("/School/C#/result.txt"))
                    {
                        int count = 0;
                        string line = reader.ReadToEnd();
                        List<string> words = line.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                        string line2 = reader2.ReadToEnd();
                        List<string> words2 = line2.Split(new string[] { "\r\n", "\r", "\n", ",", "-", ".", "!", "?", " "}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                        for(int i = 0; i < words.Count; i++)
                        {
                            for(int j = 0; j < words2.Count; j++)
                            {
                                if(words[i].ToLower() == words2[j].ToLower())
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine("{0} - {1}", words[i], count);
                            writer.WriteLine("{0} - {1}", words[i], count);
                            count = 0;
                        }
                    }
                }
            }
        }
    }
}
