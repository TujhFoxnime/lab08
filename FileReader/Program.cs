using System.IO.Compression;
using System.Text;

namespace FileReader
{

    class Program
    {
        static void Main()
        {
            try
            {
              Console.WriteLine("Please, enter the path:");
                string path = Console.ReadLine();

                Console.WriteLine("Please, enter the file name:");
                string name = Console.ReadLine();

                string fileLoc = Find(path, name);
                Show(fileLoc);

                CompressFile(@"C:\Users\gkras\OneDrive\Рабочий стол\animal.xml", @"C:\Users\gkras\OneDrive\Рабочий стол\animal1.gz");

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
  
        }

        static string Find(string path, string name)
        {
            string foundFiles = Directory.GetFiles(path, name, SearchOption.AllDirectories).FirstOrDefault();
            if (foundFiles == null)
            {
                return "not found";
            }
            else
            {
                return foundFiles;
            }
        }

        static void Show(string fileLoc)
        {
            using (FileStream fs = File.OpenRead(fileLoc))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen = fs.Read(b, 0, b.Length);
                string content = temp.GetString(b, 0, readLen);
                Console.WriteLine(content);
            }
        }
        static void CompressFile(string fileLoc, string newDest)
        {
            try
            {
                using (FileStream source = new FileStream(fileLoc, FileMode.Open))
                {
                    using (FileStream compressed = File.Create(newDest))
                    {
                        using (GZipStream gzipStream = new GZipStream(compressed, CompressionMode.Compress))
                        {
                            source.CopyTo(gzipStream);
                          Console.WriteLine($"File compressed. Previous size: {source.Length}  Compressed size: {compressed.Length}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}