using System;
using System.Threading;

namespace Animal
{
    public class Animal
    {

        public string Tipo {get; set;}
        public int TempoDoPasso {get; set;}

        public void Andar()
        {
            Console.WriteLine($"O {Tipo} vai andar");

            for(int contador = 0; contador < 10; contador++){
                Console.WriteLine($"{Tipo} deu {contador} passos");
                Thread.Sleep(TempoDoPasso);
            }

            Console.WriteLine($"O {Tipo} andou");
        }

        public void Comer(string comida)
        {
            Console.WriteLine($"O {Tipo} comeu {comida}");
        }
    }
}
