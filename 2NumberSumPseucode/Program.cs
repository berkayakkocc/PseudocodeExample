using System;

namespace _2NumberSumPseucode
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoNumberGreaterThisDoProcess();

            TwoNumberSum();

            
        }

        private static void TwoNumberSum()
        {
            Console.WriteLine("Entry first number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entry second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine("Result : {0}", result);
            Console.ReadLine();
            // 1 - 2 Sayı girdir ve okut
            // Toplama işlemi yaptır
            // Sonucu ekrana yaz
        }

        private static void TwoNumberGreaterThisDoProcess()
        {
            // iki sayıdan hangisi buyuk ise ona göre işlem seçer 
            Console.WriteLine("Entry the first number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second the entry number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                int result = firstNumber * secondNumber;
                Console.WriteLine("Result : {0}", result);
            }
            else
            {
                int result = firstNumber + secondNumber;
                Console.WriteLine("Result : {0}", result);
            }
            // 2 Sayı girdir
            // Eğer birinci sayi 2. sayıdan buyuk ise çarpma
            // küçük ise toplama işlemi yap
            // sonucu ekrana yaz
        }
    }
}
