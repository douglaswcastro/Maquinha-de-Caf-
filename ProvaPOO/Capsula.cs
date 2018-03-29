using System;
using System.Collections.Generic;

namespace ProvaPOO
{
    public class Capsula
    {
        public string tipo, tipocap;
        
        public Capsula()
        {}
        public void Fazercafe(ref int quantagua,ref int quantacucar)
        {
            Console.WriteLine("informe qual a capsula que deseja fazer!!!");
            tipocap = Console.ReadLine();
            Maquina m = new Maquina();
            if (tipocap == "expresso")
            {
                tipo = "expresso";
                quantagua = 30;
                quantacucar = 3;
                if (m.agua < quantagua)
                {
                    Console.WriteLine("abasteça agua!!!");
                    m.agua = int.Parse(Console.ReadLine());
                }
                if (m.acucar < quantacucar)
                {
                    Console.WriteLine("abasteça açucar!!!");
                    m.acucar = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("você escolheu fazer " + tipo + " irá gastar " + quantagua + " ml de água e " + quantacucar + " gramas de açucar!!!");
            }
            else if (tipocap == "latte machiato")
            {
                tipo = "latte machiato";
                quantagua = 70;
                quantacucar = 4;
                if (m.agua < quantagua)
                {
                    Console.WriteLine("abasteça agua!!!");
                    m.agua = int.Parse(Console.ReadLine());
                }
                if (m.acucar < quantacucar)
                {
                    Console.WriteLine("abasteça açucar!!!");
                    m.acucar = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("você escolheu fazer " + tipo + " irá gastar " + quantagua + " ml de água e " + quantacucar + " gramas de açucar!!!");
            }
            else if (tipocap == "caputtino")
            {
                tipo = "caputtino";
                quantagua = 50;
                quantacucar = 3;
                if (m.agua < quantagua)
                {
                    Console.WriteLine("abasteça agua!!!");
                    m.agua = int.Parse(Console.ReadLine());
                }
                if (m.acucar < quantacucar)
                {
                    Console.WriteLine("abasteça açucar!!!");
                    m.acucar = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("você escolheu fazer " + tipo + " irá gastar " + quantagua + " ml de água e " + quantacucar + " gramas de açucar!!!");
            }
            else if (tipocap == "cafe au lait")
            {
                tipo = "cafe au lait";
                quantagua = 50;
                quantacucar = 4;
                if (m.agua < quantagua)
                {
                    Console.WriteLine("abasteça agua!!!");
                    m.agua = int.Parse(Console.ReadLine());
                }
                if (m.acucar < quantacucar)
                {
                    Console.WriteLine("abasteça açucar!!!");
                    m.acucar = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("você escolheu fazer " + tipo + " irá gastar " + quantagua + " ml de água e " + quantacucar + " gramas de açucar!!!");
            }
            else
            {
                Console.WriteLine("Capsula incorreta!!!");
            }     
        }
    }
}