﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            int opcao = 0;
            
            while(opcao != 6)
            {
                Console.WriteLine("1. Listar a quantidade de aviões que estão aguardando na fila de decolagem\n2. Autorizar a decolagem do primeiro avião da fila de decolagem\n3. Adicionar um avião na fila de colagem\n4. Listar todos os aviões que estão na fila de colagem\n5. Exibir o primeiro avião da fila de colagem\n6. Sair\nDigite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        Console.WriteLine("Aviões estão aguardando na fila: "+ fila.Count());
                        break;
                    case 2:
                        Console.WriteLine("Primeiro avião da fila autorizado: "+fila.Dequeue());
                        break;
                    case 3:
                        Console.WriteLine("Qual avião deseja adicionar a fila? ");
                        string aviao = Console.ReadLine();
                        fila.Enqueue(aviao);
                        Console.WriteLine("Avião " + aviao + " adicionado a fila com sucesso!");
                        break;
                    case 4:
                        Console.WriteLine("Fila:");
                        foreach (string s in fila)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Primeiro avião da fila: " + fila.Peek());
                        break;
                    case 6:
                        Console.WriteLine("FIM!");
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
                
            }

            Console.ReadLine();
        }
    }
}
