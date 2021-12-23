using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int yıl=2021;
            string ay="Aralık";
            string tarih= DateTime.Now.ToString("dd.MMM.yyyy");
            long uzun_sayı=12347775778;
            short kısa_sayı=-12345;// + ve- 5 hane
            float ondalıklı_sayı=1.4f;
            double ond_sayı=444.78;
            byte b=123;//3 hane
            ushort k_sayı=12345;//5 hane
            sbyte k_byte=123;//3hane
            Int32 int32= 1234567890;//10 hane
            string cümle="Bugün tarihlerden ";
            Console.WriteLine(cümle+ay+" "+yıl);
            System.Console.WriteLine("Tam tarih: "+tarih);
        }
    }
}
