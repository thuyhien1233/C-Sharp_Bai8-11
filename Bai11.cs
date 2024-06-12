using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập tên file
            Console.Write("Nhap ten file: ");
            string fileName = Console.ReadLine();

            // Nhập nội dung
            Console.Write("Nhap noi dung: ");
            string content = Console.ReadLine();

            // Ghi nội dung vào file
            WriteToFile(fileName, content);

            // Đọc nội dung từ file
            string readContent = ReadFromFile(fileName);

            // Hiển thị nội dung
            Console.WriteLine("Noi dung cua file:");
            Console.WriteLine(readContent);
        }

        static void WriteToFile(string fileName, string content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(content);
                }
                Console.WriteLine("Da ghi noi dung vao file.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Loi khi ghi file: {e.Message}");
            }
        }

        static string ReadFromFile(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Loi khi doc file: {e.Message}");
                return "";
            }
        }
    }
}