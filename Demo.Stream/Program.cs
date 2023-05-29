using System.IO;
using System.Text;

namespace Demo.Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "MyFiel.txt";
            File.WriteAllText(filePath, "Hello World!");

            byte[] bytes = Encoding.ASCII.GetBytes("This is BufferedStream demo.");

            using (FileStream fileStream = new(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                BufferedStream bufferedStream = new(fileStream, 1024);
                bufferedStream.Write(bytes);
                bufferedStream.Flush();
                bufferedStream.Close();
            }

            //using (MemoryStream memoryStream = new(50))
            //{
            //    memoryStream.Write(bytes, 0, bytes.Length);
            //}
        }
    }
}