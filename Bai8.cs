using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Phần a: Hiển thị bảng mã ASCII
        Console.WriteLine("Bang ma ASCII:");
        for (int i = 0; i < 128; i++)
        {
            Console.Write($"{i}: {(char)i}\t");
            if ((i + 1) % 8 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();

        // Phần b: Hiển thị bảng mã UTF-8
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Bang ma UTF-8:");
        for (int i = 0; i < 65536; i++)
        {
            try
            {
                Console.WriteLine($"{i}: {(char)i}");
            }
            catch (Exception)
            {
                continue;
            }
        }
        Console.WriteLine();

        // Phần c: Phát tiếng beep khi nhấn phím space
        Console.WriteLine("Nhan phim space de phat tieng beep...");
        while (true)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                Console.Beep();
            }
        }

        // Phần d: Đếm số lần xuất hiện của mỗi kí tự trong chuỗi
        Console.Write("Nhập chuoi: ");
        string input = Console.ReadLine();

        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        Console.WriteLine("Ket qua dem:");
        foreach (var item in charCount)
        {
            Console.WriteLine($"'{item.Key}': {item.Value} lan");
        }
    }
}
