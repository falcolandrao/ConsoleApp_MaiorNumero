using System;

namespace ConsoleApp_MaiorNumeroCom3eComMetodo
{
    class Program
    {
        public static void Chama()
        {
            Console.WriteLine("Os números digitados são iguais");
        }

        static int MaiorDe3Numeros(int verificaNumero01, int verificaNumero02, int verificaNumero03)
        {
            int infoFinal = 0;

            if (verificaNumero01 == verificaNumero02 && verificaNumero02 == verificaNumero03)
            {
                infoFinal = int.Parse("0");
                Chama();
            }
            else
            {
                if (verificaNumero01 > verificaNumero02 && verificaNumero01 > verificaNumero03)
                {
                    infoFinal = verificaNumero01;
                }
                else if (verificaNumero02 > verificaNumero01 && verificaNumero02 > verificaNumero03)
                {
                    infoFinal = verificaNumero02;
                }
                else
                {
                    infoFinal = verificaNumero03;
                }
            }

            return infoFinal;
        }

        static void Main(string[] args)
        {

            string msgValida = MaiorDe3Numeros(12, 9, 0).ToString();

            Console.WriteLine("Resultado >> " + msgValida);
            Console.ReadKey();

        }
    }
}