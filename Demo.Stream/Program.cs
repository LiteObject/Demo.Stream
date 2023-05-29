using System.IO;
using System.Text;

namespace Demo.Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "MyFile.txt";
            File.WriteAllText(filePath, $"[{DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt")}] Hello World!");

            byte[] bytes = Encoding.ASCII.GetBytes($"\n[{DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt")}] This is a BufferedStream demo!");

            using FileStream fileStream = new(filePath, FileMode.Append, FileAccess.Write);
            BufferedStream bufferedStream = new(fileStream, 1024);
            bufferedStream.Write(bytes);
            bufferedStream.Flush();
            bufferedStream.Close();

            //using (MemoryStream memoryStream = new(50))
            //{
            //    memoryStream.Write(bytes, 0, bytes.Length);
            //}
        }
    }
}