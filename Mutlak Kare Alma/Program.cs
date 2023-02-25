using System;

namespace Mutlak_Kare_Alma
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("Kaç Tane Sayı Girmek İstiyoesanız Yazınız. ");
            int sayi=int.Parse(Console.ReadLine());
            int[] sayilistesi = new int[sayi];
            int[] fark=new int[sayi];
            int[] fark2=new int[sayi];
            int[] kareler=new int[sayi];
           
            
            int toplam=0;
            int toplambuyuk=0;

            for(int i=0;i<sayi;i++)
            {
                Console.WriteLine("{0} . sayıyı Giriniz: ", i+1);
                sayilistesi[i]=int.Parse(Console.ReadLine());
            }

            for(int i=0;i<sayilistesi.Length;i++)
            {
                if(sayilistesi[i]<67)
                {
                    fark[i]=67 - sayilistesi[i];
                }
                else if (sayilistesi[i]>67)
                {
                    fark2[i]=sayilistesi[i]-67;
                    kareler[i]=fark2[i]*fark2[i];
                }
               toplam=toplam+fark[i];

               toplambuyuk=toplambuyuk+kareler[i];
            }
            Console.WriteLine("67'den Küçük Olanların Farkının Toplamı:{0} ",toplam);
            Console.WriteLine("67'den Büyük Olanların Farkının Karelerinin Toplamı{0} ",toplambuyuk);
        }   
    }
}
