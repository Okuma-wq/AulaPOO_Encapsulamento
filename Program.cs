using System;
using Encapsulamento.Classes;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();
            m.NomeTitular = "Pedro Laurentino Okuma";

            m.Numero = "1234567";

            m.Bandeira = "MasterCard";

            Console.WriteLine($"O Títular {m.NomeTitular} - Token {m.Token}");
        }
    }
}
