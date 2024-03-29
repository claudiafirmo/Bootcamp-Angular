﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_ArraysNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definindo Arrays de números inteiros:
            // Forma 1: criar o array e definir uma quantidade
            int[] numeros = new int[5];
            // [0,0,0,0,0]

            numeros[0] = 15;
            numeros[1] = 30;
            numeros[4] = 15 * 5;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"numeros[{i}] = {numeros[i]}");
            }
            Console.WriteLine();

            // para cada item inteiro na coleção
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Forma 2: Na declaração do array, atribuir seus valores
            int[] valores = { 10, 20, 30, 40 }; 
            // forma completa - int[] valores = new int[] {10,20,30,40};
            // ou int[] valores; valores = new int[]{10,20,30,40}

            foreach(int elemento in valores)
            {
                Console.WriteLine(elemento);
            }


            Console.ReadKey();
        }
    }
}
