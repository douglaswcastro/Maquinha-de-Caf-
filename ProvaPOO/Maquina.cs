using System;

namespace ProvaPOO
{
    public class Maquina
    {
        Capsula cap = new Capsula();

        public int agua = 200, acucar = 15;
        public string tipocap = null;
        char op, op1;

        public void Preparar()
        {
            Console.WriteLine("Se dejesa ligar digite <L>,\n" +
                "se dejesa desligar digite <D>");
            op = char.Parse(Console.ReadLine());
            if (op == 'L' || op == 'l')
            {
                Console.WriteLine("Ligada");
                Console.WriteLine("deseja preparar o café? digite<S> para sim e <N> para não");
                op1 = char.Parse(Console.ReadLine());
                if (op1 == 'S' || op1 == 's')
                {
                    cap.Fazercafe(ref agua, ref acucar);
                }   
            }
            else if (op == 'D' || op == 'd')
            {
                Console.WriteLine("desligada");
            }
        }
    }
}