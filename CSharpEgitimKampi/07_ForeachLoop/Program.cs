using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "milano", "ankara", "varşova", "budapeşte", "istanbul" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] nums = { 1, 2, 3, 65, 7452, 56478, 341, 236358, 457, 32 };
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] nums = { 1, 2, 3, 65, 7452, 56478, 341, 236358, 457, 32 };
            //foreach (int i in nums)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] nums = { 1, 2, 3, 65, 7452, 56478, 341, 236358, 457, 32 };
            //int total = 0;
            //foreach (int i in nums)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion
            #region Örnek sınav sistemi uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            ////Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            ////Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExam = 0;
            //    //Her öğrenci için 3 sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. sınav notunu giriniz: ");
            //        double value= double.Parse(Console.ReadLine());
            //        totalExam += value;
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExam / 3;
            //}
            ////Sınav ortalamaları
            //for (int i = 0;i < studentCount;i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
            //    //Öğrencilerin geçme kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti") ;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }
            //    Console.WriteLine("----------------------");
            //}

            #endregion
            Console.Read();
        }
    }
}
