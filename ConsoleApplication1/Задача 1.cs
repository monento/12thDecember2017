using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int InputInt()
        {
            bool ok;
            int Num;
            do
                ok = Int32.TryParse(Console.ReadLine(), out Num);
            while (!ok);
            return Num;
        }
        static int[,] FormArray(int N, int M)
        {
            int [,] A = new int [N,M];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    A[i, j] = rnd.Next(0, 10);
            return A;
        }
        static void PrintArr(int[,] A)
        {            
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write(" " + A[i, j]);
                Console.WriteLine();
            }
        }
        static int InputK(int N)
        {
            int K; bool ok;
            do
            {
                K = InputInt();
                if ((K > 0) && (K <= N+1)) ok = true;
                else ok = false;
            }
            while (!ok);
            return K;
        }
        static int[,] AddStr(int[,] A, int N, int M, int K)
        {
            Random rnd = new Random();
            int[,] T = new int[N + 1, M];
            for (int i = 0; i < N + 1; i++)
               for (int j = 0; j < M; j++)
                {
                    if (i < K - 1) T[i, j] = A[i, j];
                    if (i == K - 1) T[i, j] = rnd.Next(-9, 0);
                    if (i > K - 1) T[i, j] = A[i - 1, j];
                }
            A = T;
            return A;   
        }
        static void Main(string[] args)
        {
            int N, M;
            Console.WriteLine("Введите число строк");               
            N=InputInt();
            Console.WriteLine("Введите число столбцов");
            M = InputInt();
            Console.WriteLine("Начальный массив");
            int[,] A = FormArray(N, M);
            PrintArr(A);
            Console.WriteLine("Введите число K");
            int K=InputK(N);
            Console.WriteLine("Конечный массив");
            A = AddStr(A, N, M, K);
            PrintArr(A);
            Console.ReadLine();
        }
    }
}
