using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
           //viết 1 chương trình  đọc file test.csv, gồm 6 cột, Có thể sử dụng phương thức String.Split() để cắt chuỗi
           
           var path= @"D:\GITHUB\Ex_C-_ReadFile.CSV\ReadFile\test.csv";

	              var lines = System.IO.File.ReadAllLines(path);

	                foreach (var line in lines)
                    {
                        var values = line.Split(',');
                        Console.WriteLine($"Name: {values[0]}, Age: {values[1]}, Address: {values[2]}, Phone: {values[3]}, Email: {values[4]}, Salary: {values[5]}");
                    }
        }
    }
}