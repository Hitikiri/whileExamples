using System;

namespace whileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //x den y ye kadar olan çift sayıların toplamını bul
            int x, y,z;
            z = 0;
            Console.WriteLine("ilk sayıyı giriniz");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz");
            y = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i < y; i++)
            {
                if (i%2==0)
                {
                    z += i;
                }
            }   Console.WriteLine("toplam:"+z);
        }   
    }
}