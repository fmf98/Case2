using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doubleDeğişkenler
            //double number;
            //number = 4.78;
            //Console.WriteLine(number);
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, tomatoPrice, potatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("Elma birim fiyatı: "+ applePrice + "TL");
            //Console.WriteLine("Portakal birim fiyatı: "+ orangePrice + "TL");
            //Console.WriteLine("Çilek birim fiyatı: "+ strawberryPrice + "TL");
            //Console.WriteLine("Domates birim fiyatı: "+ tomatoPrice + "TL");
            //Console.WriteLine("Patates birim fiyatı: "+ potatoPrice+ "TL");
            //double appleGram, orangeGram, strawberryGram, tomatoGram, potatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, tomatoTotalPrice, potatoTotalPrice;
            //appleTotalPrice = applePrice * appleGram;
            //orangeTotalPrice = orangePrice * orangeGram;
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //tomatoTotalPrice = tomatoPrice * tomatoGram;
            //potatoTotalPrice = potatoPrice * potatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam tutar: " + tomatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam tutar: " + potatoTotalPrice);
            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine("Toplam tutar: " + shoppingTotalPrice + "TL");
            #endregion
            #region charDeğişkenler

            //ABCDEFG Türkçe karakterler yok!
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion
            #region Klavyeden string veri girişleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçeniz: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehriniz: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaşınız: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("TC kimlik no: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Yolcu: "+ passengerName + " " +  passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge + " " + passengerIdentityNumber);
            #endregion
            #region Klavyeden Tam sayı veri girişleri ve dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısınız giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısınız giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısınız giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısınız giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice*shoesCount + computerPrice*computerCount + chairPrice*chairCount + tvPrice*tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Ödemeniz gereken toplam tutar: "+ totalPrice);


            #endregion
            #region Klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen ilk sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen üçüncü sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: " + result);

            #endregion
            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.ReadLine();
        }
    }
}
