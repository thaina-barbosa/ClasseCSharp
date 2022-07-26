using Animais.Src;
using System;

namespace Cachorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ListaAnimais animal1  = new ("Cachorro","Thor", "Sptiz","Pequeno","Branco");
             ListaAnimais animal2  = new ("Gato","Babi", "Siamês", "Pequeno","Marrom");
             ListaAnimais animal3  = new ("Coelho","Fred", "Angorâ", "Pequeno","Creme");
             ListaAnimais animal4  = new ("Leão","Mufasa", "leão-americano", "Médio","Amarelo");
            

            Console.WriteLine(animal1.ToString());
            Console.WriteLine(animal2.ToString());
            Console.WriteLine(animal3.ToString());
            Console.WriteLine(animal4.ToString());

        }
    }
}
