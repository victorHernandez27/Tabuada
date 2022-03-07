using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0 ;

            do
            {
                Console.WriteLine("Digite um numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if(numero < 1 ||numero > 9)
                {
                    Console.WriteLine("Numero Inválido");
                }

            } while (numero < 1 || numero > 9);

            Console.WriteLine("Tabuado do: {0}", numero);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", numero,i,(numero*i));
            }
            Console.ReadKey();
        }
    }
}
