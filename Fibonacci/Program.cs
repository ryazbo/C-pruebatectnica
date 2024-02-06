using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite su numero para hallar dentro de los numeros fibonacci:");
        int UsrDigit = Convert.ToInt32(Console.ReadLine());

        bool found = IsFibonacci(UsrDigit);

        if (found)
        {
            Console.WriteLine($"Su numero {UsrDigit} se encontró dentro de los números fibonacci.");
        }
        else
        {
            Console.WriteLine($"Su numero {UsrDigit} no se encontró dentro de los números fibonacci.");
        }
    }

    static bool IsFibonacci(int numUser)
    {
        if (numUser == 0 || numUser == 1) return true;

        int prev = 0;
        int current = 1;

        while (current < numUser)
        {
            int next = prev + current;
            prev = current;
            current = next;
        }

        return current == numUser;
    }
}