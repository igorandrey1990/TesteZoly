using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteZoly
{
    class Program
    {
        static void Main(string[] args)
        {
            // Caso 1
            var arrayA = new int[] { 4, 2, 1 };
            var arrayB = new int[] { 2, 5, 3 };
            int FDevs = 2;

            // Resultado Experado 10
            int somaMaxContribCaso1 = CalcSomaMax(arrayA, arrayB, FDevs);

            // Caso 2
            arrayA = new int[] { 7, 1, 4, 4 };
            arrayB = new int[] { 5, 3, 4, 3 };
            FDevs = 2;

            // Resultado Experado 18
            int somaMaxContribCaso2 = CalcSomaMax(arrayA, arrayB, FDevs);

            // Caso 3
            arrayA = new int[] { 5, 5, 5 };
            arrayB = new int[] { 5, 5, 5 };
            FDevs = 1;

            // Resultado Experado 15
            int somaMaxContribCaso3 = CalcSomaMax(arrayA, arrayB, FDevs);

            // Caso 4
            arrayA = new int[] { 6, 5, 5, 8, 15, 1, 4, 9 };
            arrayB = new int[] { 5, 5, 5, 4, 2, 7, 5, 20 };
            FDevs = 2;

            // Resultado Experado 58
            int somaMaxContribCaso4 = CalcSomaMax(arrayA, arrayB, FDevs);
        }

        public static int CalcSomaMax(int[] arrayA, int[] arrayB, int numDevsFront)
        {
            // Calcula quantidade de devs back-end.
            int numDevsBack = arrayA.Length - numDevsFront;
            int soma = 0;

            // Array temporario para quando as contribuições forem iguais.
            List<int> tempArray = new List<int>();

            // Loop somente arrayA considerando a premissa 2 que A e B tem comprimentos iguais.
            for (int i = 0; i < arrayA.Length; i++)
            {
                // Compara valor de A e B e caso o count para numero de devs back-end esteja ja
                // completo passa para o proximo de A, e por ultimo se ambos são iguais adiciona na lista temp
                if ((arrayA[i] > arrayB[i] && numDevsFront != 0) || numDevsBack == 0)
                {
                    soma = soma + arrayA[i];
                    numDevsFront--;
                }
                else if ((arrayB[i] > arrayA[i] && numDevsBack != 0)|| numDevsFront == 0)
                {
                    soma = soma + arrayB[i];
                    numDevsBack--;
                }
                else if (arrayA[i] == arrayB[i])
                    tempArray.Add(arrayA[i]);
            }

            // Caso o numero de devs front for inferior ao numero esperado de devs.
            if (numDevsFront != 0)
            {
                for (int i = 0; i < numDevsFront; i++)
                {
                    soma = soma + tempArray[i];
                }
            }

            // Caso o numero de devs front for inferior ao numero esperado de devs.
            if (numDevsBack != 0)
            {
                for (int i = 0; i < numDevsBack; i++)
                {
                    soma = soma + tempArray[i];
                }
            }

            // Retorna a soma de contribuições de ambas equipes.
            return soma;
        }

        
    }
}
