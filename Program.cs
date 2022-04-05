using System;

namespace StartsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";

            //Texto começa com ("")
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texto"));
            Console.WriteLine("");

            //Texto termina com ("")
            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("xpro"));
        }
    }
}
