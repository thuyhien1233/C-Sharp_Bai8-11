using System;

class Program
{
    static void Main(string[] args)
    {
        // Phần a: Đảo ngược chuỗi
        Console.Write("Nhap chuoi ki tu: ");
        string inputString = Console.ReadLine();
        string reversedString = ReverseString(inputString);
        Console.WriteLine("Chuoi dao nguoc: " + reversedString);

        // Phần b: Đếm số từ trong chuỗi
        Console.Write("Nhap chuoi ki tu: ");
        string input = Console.ReadLine();
        int wordCount = CountWords(input);
        Console.WriteLine("So luong tu trong chuoi: " + wordCount);
    }

    // Hàm đảo ngược chuỗi
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray(); // Chuyển chuỗi thành mảng ký tự
        Array.Reverse(charArray); // Đảo ngược mảng ký tự
        return new string(charArray); // Chuyển mảng ký tự thành chuỗi mới
    }

    // Hàm đếm số từ trong chuỗi
    static int CountWords(string str)
    {
        // Tách chuỗi thành các từ dựa trên khoảng trắng và loại bỏ các từ trống
        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length; // Trả về số lượng từ
    }
}
