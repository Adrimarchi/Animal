using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual animal você quer?");
            var animal = Console.ReadLine();

            if(animal == "tartaruga"){
                var tartaruga = new Tartaruga();
                tartaruga.Andar();
            }
            else if(animal == "cachorro"){
                var cachorro = new Cachorro();
                cachorro.Andar();
            }
            else if(animal == "leopardo"){
                var leopardo = new Leopardo();
                leopardo.Andar();
            } else {
                Console.WriteLine("Não conheço esse animal");
            }
        }
    }
}
