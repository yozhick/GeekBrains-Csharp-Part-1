//**Считайте файл различными способами. Смотрите “Пример записи файла различными способами”.
//Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.
//        Михайлов Дмитрий Викторович

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            long kbyte = 1024;
            long mbyte = 1024 * kbyte;
            long gbyte = 1024 * mbyte;
            long size = mbyte;
            //Write FileStream
            //Write BinaryStream
            //Write StreamReader/StreamWriter
            //Write BufferedStream

            Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSample("D:\\temp\\bigdata0.bin", size));
            _ = FileStreamReadBytes("D:\\temp\\bigdata0.bin");
            Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSample("D:\\temp\\bigdata1.bin", size));
            _ = BinaryReaderRead("D:\\temp\\bigdata1.bin");
            Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSample("D:\\temp\\bigdata2.bin", size));
            _ = StreamReaderReadString("D:\\temp\\bigdata2.bin");
            Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSample("D:\\temp\\bigdata3.bin", size));
            _ = BufferedStreamReadBytes("D:\\temp\\bigdata3.bin");

            Console.ReadKey();
        }

        static byte[] FileStreamReadBytes(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            byte[] buffer = new byte[fs.Length];
            
            for (int i = 0; i < fs.Length; i++)
            {
                buffer[i] = (byte)fs.ReadByte();
            }

            fs.Close();
            return buffer;
        }

        static long FileStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                fs.WriteByte(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long BinaryStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write((byte)0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static int[] BinaryReaderRead(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            var size = fs.Length / sizeof(int);
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = br.ReadInt32();
            }
            br.Close();
            fs.Close();
            return array;
        }

        static long StreamWriterSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
                sw.Write(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static string StreamReaderReadString(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                return sr.ReadToEnd();
            }
        }

        static long BufferedStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static byte[] BufferedStreamReadBytes(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            BufferedStream bs = new BufferedStream(fs);

            byte[] buffer = new byte[bs.Length];

            for (int i = 0; i < bs.Length; i++)
            {
                buffer[i] = (byte)bs.ReadByte();
            }

            bs.Close();
            fs.Close();

            return buffer;
        }
    }

}
