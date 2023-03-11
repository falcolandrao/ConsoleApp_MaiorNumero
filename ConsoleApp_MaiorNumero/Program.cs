using System;

namespace ConsoleApp_MaiorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###   Programa Maior Número   ###");

            #region "Declaração das varáveis"
            int? numRecebe01 = null; int? numRecebe02 = null;
            string msgUsuario = null;
            #endregion;

            if (numRecebe01 == null && numRecebe02 == null)
            {
                msgUsuario = "Os números >> " + numRecebe01.ToString() + numRecebe02.ToString() + " são Nullables";
            }
            else
            {
                if (numRecebe01 == numRecebe02)
                {
                    msgUsuario = "Os números são iguais";
                }
                else if (numRecebe01 > numRecebe02)
                {
                    msgUsuario = " O primeiro número " + numRecebe01 + " é maior que o segundo " + numRecebe02;
                }
                else
                {
                    msgUsuario = " O segundo número " + numRecebe02 + " é maior que o primeiro " + numRecebe01;
                }

                Console.WriteLine("Retorno >> " + msgUsuario);
            }

            Console.WriteLine(" Outro Retorno >> " + msgUsuario);

            Console.ReadKey();

        }
    }
}