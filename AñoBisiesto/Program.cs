using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite su año a evaluar");
        int YearUsur = Convert.ToInt32(Console.ReadLine());
        VerifyYear(YearUsur);
    }

    static void VerifyYear(int num )
    {

        int isBisi;

        if ((num % 4 == 0 && num % 100 != 0) || (num % 400 == 0))
        {
            isBisi = 1;
        }
        else
        {
            isBisi = 2;
        }
        if (isBisi == 1)
        {
            Console.WriteLine("el año es biciesto");
        }
        if (isBisi == 2)
        {
            Console.WriteLine("el año no es biciesto");
        }
    }
}