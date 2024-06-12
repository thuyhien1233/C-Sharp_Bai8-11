using System;

namespace Exercise10
{
    struct Student
    {
    public string Name;
    public float Score;
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        Student[] students = new Student[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap ten sinh vien {i + 1}: ");
            students[i].Name = Console.ReadLine();

            Console.Write($"Nhap diem cua sinh vien {i + 1}: ");
            students[i].Score = float.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nThong tin cua tung sinh vien:");
        float totalScore = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Ten: {students[i].Name},    Diem: {students[i].Score}");
            totalScore += students[i].Score;
        }

        float averageScore = totalScore / n;
        Console.WriteLine($"\nDiem trung binh cua lop: {averageScore:F2}");
    }
}
}