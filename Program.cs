using System;
using Comida;
namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual animal você quer?");
            var animal = Console.ReadLine();
            var alface = new Alface();

            if(animal == "tartaruga"){
                var tartaruga = new Tartaruga();
                tartaruga.Andar();
                tartaruga.Comer(alface.Tipo);
            }
            else if(animal == "cachorro"){
                var cachorro = new Cachorro();
                cachorro.Andar();
                cachorro.Comer(alface.Tipo);
            }
            else if(animal == "leopardo"){
                var leopardo = new Leopardo();
                leopardo.Andar();
                leopardo.Comer(alface.Tipo);
            } else {
                Console.WriteLine("Não conheço esse animal");
            }
        }
    }
}
