using System;

namespace ProvaPOO
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Maquina m = new Maquina();
            m.Preparar();
            Console.WriteLine("digite qualquer tecla para sair!!");
            Console.ReadKey(true);
        }
    }
}

