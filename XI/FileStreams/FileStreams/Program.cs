using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (FileStream source = new FileStream("D:/Photosi/1.jpg", FileMode.Open)) //конструктора на FileStream в режим на отваряне на файла
            {
                using (var destination = new FileStream("D:/Photosi/0.jpg", FileMode.Create)) //конструктора на FileStream в режим на //конструктора на FileStream в режим на отваряне и създаване на файла
                {
                    byte[] buffer = new byte[4096]; //създаваме си буфер от байтове

                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length); //връща стойността на прочетените байтове от позиция 0
                        if (readBytes == 0) //ако броя на прочетените байтоне достигне края, излизаме от цикъла
                            break;
                        destination.Write(buffer, 0, readBytes); //записваме поредица от readBytes наброй байта в изходящия поток, започвайки от позиция 0
                    }
                }
            }*/
            int parts = int.Parse(Console.ReadLine()); //четем броя на частите
            using (FileStream source = new FileStream("D:/Photosi/art.mp4", FileMode.Open)) //конструктора на FileStream в режим на отваряне на файла
            {
                double partSize = source.Length / parts; //намираме дължината на броя части
                for (int i = 0; i < parts; i++) //всяка нова част се записва в нов файл
                {
                    using (FileStream destination = new FileStream($"D:/Photosi/Part-{i}.mp4", FileMode.Create)) //конструктора на FileStream в режим на //конструктора на FileStream в режим на отваряне и създаване на файла
                    {
                        byte[] buffer = new byte[4096];
                        int readBytes;
                        while (destination.Length < partSize && (readBytes = source.Read(buffer, 0, buffer.Length)) != 0) //докато дължината на изходния поток е по-малка от тази на частта и броя на байтовете не е достигнал края
                        {
                            destination.Write(buffer, 0, readBytes); //записваме поредица от readBytes наброй байта в изходящия поток, започвайки от позиция 0
                        }
                    }
                }
            }
            List<string> files = new List<string>();
            for (int i = 0; i < parts; i++) //добавя всички части в лист
            {
                files.Add($"D:/Photosi/Part-{i}.mp4");
            }
            using (FileStream destination = new FileStream($"D:/Photosi/assembled.mp4", FileMode.Create)) //конструктора на FileStream в режим на //конструктора на FileStream в режим на отваряне и създаване на файла
            {
                foreach (var file in files) //копираме всеки файл в листа в изходния поток
                {
                    using (FileStream partStream = new FileStream(file, FileMode.Open)) //конструктора на FileStream в режим на отваряне на файла
                    {
                        byte[] buffer = new byte[4096];
                        int readBytes;
                        while ((readBytes = partStream.Read(buffer, 0, buffer.Length)) != 0) //докато броя на байтовете не достигне края
                        {
                            destination.Write(buffer, 0, readBytes); //записваме поредица от readBytes наброй байта в изходящия поток, започвайки от позиция 0
                        }
                    }
                }
            }
        }
    }
}
