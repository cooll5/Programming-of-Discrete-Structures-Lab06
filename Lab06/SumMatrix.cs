﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class SumMatrix
    {
        private int[,] matrix = null;
        private int n = 0;
        private int m = 0;
        public int[,] createMatrix(Graph graph, int[,] result)
        {
            this.n = graph.GetN();
            this.m = graph.GetM();

            int[] T = fillUp(graph.GetN());

            int[,] matrix = new int[n + 1 , n + 1];

            bool isEqual = false;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    isEqual = false;
                    int[] V = {T[i], T[j]};
                    for (int l = 1; l < m + 1; l++)
                    {
                        if(V[0] == result[l, 0] && V[1] == result[l, 1])
                        {
                            isEqual = true;
                            break;
                        }
                    }
                    if (isEqual)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            this.matrix = result;
            return matrix;
        }

        public int[] fillUp(int n)
        {
            int[] V = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                V[i] = i;
            }
            return V;
        }

        public static void printMatrix(int[,] matrix, Graph graph)
        {
            Console.Write("   |");
            for (int j = 1; j < graph.GetN() + 1; j++)
            {
                Console.Write($"{j,2} |");
            }
            Console.WriteLine();

            for (int i = 1; i < graph.GetN() + 1; i++)
            {
                Console.Write($"{i,2} |");
                for (int j = 1; j < graph.GetN() + 1; j++)
                {
                    Console.Write($"{matrix[i, j],2} |");
                }
                Console.WriteLine();
            }
        }
        public int GetN()
        {
            return this.n;
        }
        public int GetM()
        {
            return this.m;
        }

        public int[,] GetMatrix()
        {
            return this.matrix;
        }
    }
}
