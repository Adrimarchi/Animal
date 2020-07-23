using System;
using Comida;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual animal você quer?");
            var tipoDeAnimal = Console.ReadLine();
            var animal = CriarAnimal(tipoDeAnimal);

            animal.Andar();
            animal.Comer(new Alface().Tipo);
        }

        static Animal CriarAnimal(string tipoDeAnimal)
        {
            switch(tipoDeAnimal)
            {
                case "boi":
                    return new Boi();
                case "tartaruga":
                    return new Tartaruga();
                case "cachorro":
                    return new Cachorro();
                case "leopardo":
                    return new Leopardo();
                default:
                    throw new Exception("Não conheço esse animal");
            }
        }
    }
}
