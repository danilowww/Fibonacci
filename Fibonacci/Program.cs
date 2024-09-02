using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            // Verifica se o número pertence à sequência de Fibonacci
            if (PertenceFibonacci(numero))
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
        }
    }

    static bool PertenceFibonacci(int n)
    {
        int a = 0, b = 1;

        if (n < 0)
        {
            return false;
        }

        else if (n == a || n == b)
        {
            return true;
        }

        else
        {
            while (b < n)
            {
                int temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine($"a = {a}, b = {b} e temp = {temp}");
            }

            return b == n;
        }
    }
}