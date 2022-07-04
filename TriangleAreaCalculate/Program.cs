using System;

namespace TriangleAreaCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Üçgen alan hesaplama
            int height, sole, result;
            Console.WriteLine("Enter the height : ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sole : ");
            sole = Convert.ToInt32(Console.ReadLine());
            result = (height * sole) / 2;
            Console.WriteLine("Result : {0}", result);
            Console.ReadKey();

            //Adımlar
            // 1- 2 deger girdirdik kullanıcıya
            //2- Alan hesaplama formulunu gercekleştirdim 
            //3- Ekrana yazdım
        }
    }
}
