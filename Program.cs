using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06_JogoDosAmigos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int card1 = num.Next(1,11), card2 = num.Next(1, 11), card3 = num.Next(1, 11), total_cartas = card1 + card2;
            string continua;

            Console.WriteLine("=============Bem vindo ao jogo de los amigos!!!=============");

            Console.WriteLine($"\nSuas cartas: {card1} + {card2}");
            Console.WriteLine($"Você tem: {total_cartas}");

            while (total_cartas < 21)
            {
                Console.WriteLine("Continuar? Responda com SIM ou NÃO.");
                continua = Console.ReadLine();

                if (continua == "SIM")
                {
                    card3 = num.Next(1, 11);
                    total_cartas += card3;

                    Console.WriteLine($"Suas cartas: {card1}, {card2}, {card3}. Total: {total_cartas}");
                }
                else if (continua == "NÃO")
                {
                    Console.WriteLine("Saiu do jogo. Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
                else 
                {
                    Console.WriteLine("Resposta inválida. Digite SIM ou NÃO.");
                }

            }
                if (total_cartas == 21)
                {
                    Console.WriteLine("Ganhou da casa!");
                    Console.ReadKey();
                    Console.Clear();
                    return;
            }

                if(total_cartas > 21)
                {
                    Console.WriteLine("Estourou. Perdeste.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }

                Console.ReadKey();
        }
    }
}
