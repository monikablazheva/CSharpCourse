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
            using (FileStream source = new FileStream("../Pictures/1.jpg", FileMode.Open))
            {
                using (var destination = new FileStream("../Pictures/0.jpg", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                            break;
                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }

        }
    }
}
