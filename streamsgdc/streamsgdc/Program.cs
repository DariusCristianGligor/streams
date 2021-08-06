using System;
using System.IO;

namespace streamsgdc
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo di = new DirectoryInfo(@"D:");
            //FileSystemInfo[] dirs = di.GetFiles("*aaaa*");
            //Console.WriteLine($"Numbers:{dirs.Length}");
            //foreach (DirectoryInfo diNext in dirs)
            //{
            //    Console.WriteLine($"nr of files and directories in{diNext}with an o is{diNext.GetFileSystemInfos("*e*")}");



            //FileStream fs = new FileStream("cars22.txt", FileMode.OpenOrCreate,FileAccess.Write);

            //if (fs.CanRead && fs.CanWrite)
            //{
            //    Console.WriteLine("MyFile.txt can be both written to and read from.");
            //}
            //else if (fs.CanRead)
            //{
            //    Console.WriteLine("MyFile.txt is not writable.");
            //}
            //else if (fs.CanWrite)
            //{
            //    Console.WriteLine("MyFile.txt is writable.");
            //}
            //Console.WriteLine("Eneter the file name:");
            //string fn = Console.ReadLine();
            //Console.WriteLine("Eneter the file name:");
            //string fn1 = Console.ReadLine();
            //StreamReader reader = null;
            //try
            //{
            //    reader = new StreamReader(fn);
            //    //var writer = new StreamWriter(fn1, true);                //var writer = new StreamWriter(fn1, true);
            //    using (StreamWriter outputFile = new StreamWriter(Path.Combine("C:/Users/dariu/Desktop/IA/streams/streams/streamsgdc/streamsgdc/bin/Debug/net5.0", fn1)))
            //    {

            //        for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
            //    {
            //        Console.WriteLine(line);
            //            outputFile.WriteLine(line);
            //    }

            //}

            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally {
            //    if (reader != null)
            //    {
            //        reader.Close();
            //    }
            //}
            //const string fileName = "textWrite.txt";
            //byte[] dataArray = new byte[5000];
            //Random rnd = new Random();
            //rnd.NextBytes(dataArray);

            //using (FileStream
            //fileStream = new FileStream(fileName, FileMode.Create))
            //{
            //    // Write the data to the file, byte by byte.
            //    for (int i = 0; i < dataArray.Length; i++)
            //    {
            //        fileStream.WriteByte(dataArray[i]);
            //    }

            //    // Set the stream position to the beginning of the file.
            //    fileStream.Seek(0, SeekOrigin.Begin);

            //    // Read and verify the data.
            //    for (int i = 0; i < fileStream.Length; i++)
            //    //{
            //    //    if (dataArray[i] != fileStream.ReadByte())
            //    //    {
            //    //        Console.WriteLine("Error writing data.");
            //    //        return;
            //    //    }
            //    {

            //        Console.WriteLine(fileStream.ReadByte());
            //    }
            //    Console.WriteLine("The data was written to {0} " +
            //        "and verified.", fileStream.Name);
            //}
            const string fileName = "textWrite.txt";
            byte[] dataArray = new byte[5000];
            byte[] dataArray2 = new byte[30];
            Random rnd = new Random();
            rnd.NextBytes(dataArray);

            using (FileStream
            fileStream = new FileStream(fileName, FileMode.Create))
            {
                // Write the data to the file, byte by byte.
                for (int i = 0; i < dataArray.Length; i++)
                {
                    fileStream.WriteByte(dataArray[i]);
                }

                // Set the stream position to the beginning of the file.
                Console.WriteLine($"Position:{fileStream.Position}");
                fileStream.Seek(0, SeekOrigin.Begin);
                fileStream.SetLength(60);
                // Read and verify the data.
                for (int i = 0; i < dataArray2.Length; i++)
                {
                    fileStream.WriteByte(dataArray2[i]);
                }
                Console.WriteLine($"Position:{fileStream.Position}");
                fileStream.Seek(0, SeekOrigin.Begin);
                for (int i = 0; i < fileStream.Length; i++)
                {
                    Console.WriteLine(fileStream.ReadByte());
                }
                //{
                //    if (dataArray[i] != fileStream.ReadByte())
                //    {
                //        Console.WriteLine("Error writing data.");
                //        return;
                //    }

            }



        }
    }
}