using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular a área de um triângulo retângulo, para isso digite o valor da... ");
           
            Console.WriteLine("Base: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Altura: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double divisao = 2;

            Console.WriteLine("O resultado do calculo da área é: "+ b * h / divisao);
             

        }
    }
}
