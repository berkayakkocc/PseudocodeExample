using System;

namespace SquareFunctionPseudocode
{
    class Program
    {
        static void Main(string[] args)
        {
            //karesini hesaplayan algoritma


            
            int value1, result;
            Console.WriteLine("Enter the value :  ");
            value1 = Convert.ToInt32(Console.ReadLine());

            result = value1 * value1;
            Console.WriteLine("Sonuç : {0}", result);
            Console.ReadLine();
            // Adım adım yapılan işlemler
            // 1- Kullanıcıdan deger isteyip bunu inte convert ettik
            // İstenen işlemi sağlamak için ise degeri kendisi ile çarpıp,
            // Ekrana yazdırdık
        }
    }
}
