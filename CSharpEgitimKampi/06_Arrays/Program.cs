using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[7 ]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion
            #region Dizideki tüm elemanları listeme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNum= myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNum)
            //    {
            //        maxNum = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNum);

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion
            #region Dizi Metotlar

            //string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar", "Kaya" };
            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);

            //int[] nums = { 3, 76, 34, 765, 235, 124, 7689, 342, 67 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + nums.Max() + " Dizinin en küçük elemanı: " + nums.Min());

            #endregion
            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. şehri giriniz");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] nums = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //}
            //Console.WriteLine(sum);

            //int[] nums = { 21, 42, 33, 54, 75, 86, 47, 568,789, 7770 };
            //Console.WriteLine("Çift sayılar");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}
            //Console.WriteLine("Tek sayılar");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 1)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}

            #endregion
            Console.Read();
        }
    }
}
