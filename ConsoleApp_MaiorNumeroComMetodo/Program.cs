using System;

namespace ConsoleApp_MaiorNumeroComMetodo
{
    class Program
    {
        public static void Chama()
        {
            Console.WriteLine("Os números digitados são iguais");
        }

        static int MaiorNumero(int verificaNumero01, int verificaNumero02)
        {
            int infoFinal;

            
                if (verificaNumero01.Equals(verificaNumero02))
                {
                    infoFinal = int.Parse("0");
                    Chama();
                }
                else
                {
                    infoFinal = Math.Max(verificaNumero01, verificaNumero02);
                }
           
            return infoFinal;
        }

        static void Main(string[] args)
        {
            try
            {
                string msgValida = MaiorNumero(2, 4).ToString();

                Console.WriteLine("Resultado >> " + msgValida);
                Console.ReadKey();
            }
            catch (FormatException ex)
            {

                Console.Write("Não é um número valído. Tente novamente.");
            }

            Console.ReadKey();
        }
    }
}
