using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static int IntputInt()
        {
            bool ok;
            int Num;
            do
            {
                ok = Int32.TryParse(Console.ReadLine(), out Num);
            }
            while (!ok);
            return Num;        
        }
        static int [][] FormArr(int[][] A)
        {
            Random rnd = new Random();
            int K;
            for (int i = 0; i < A.Length; i++)
            {
                K = rnd.Next(1, 10);
                A[i] = new int[K];
                for (int j = 0; j < K; j++)
                {
                    A[i][j] = rnd.Next(0, 10);
                }
            }
            return A;
        }
        static void PrintArr(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            { 
                for (int j = 0; j < A[i].Length; j++)
                    Console.Write(" " + A[i][j]);
                Console.WriteLine();
            }            
        }
        static int[][] DeleteStrg(int [] []A)
        {
            int min = Int32.MaxValue; 
            int h=1;
            for (int i = 0; i < A.Length; i++)                  //выявление минимальной длины;
            {
                if (A[i].Length < min) min = A[i].Length;
            }
            for (int j = 0; j < A.Length; j++)                //Выявление номера строки;
                if(A[j].Length==min) { h = j;  break; }

            int[][] T = new int [A.Length - 1][];

            for (int i = 0; i < T.Length; i++)                  //Удаление строки
            {
                if (i >= h) T[i] = A[i+1];
                else if (i<h) T[i] = A[i];
            }            
            return T;
            
        }        
        static void Main(string[] args)
        {
            Console.WriteLine("Ввидите число строк N");
            int N = IntputInt();
            Console.WriteLine("Начальный массив");
            int[][] A = new int[N][];
            FormArr(A);
            PrintArr(A);
            Console.WriteLine("Конечный массив");          
            A=DeleteStrg(A);
            PrintArr(A);
            Console.ReadLine();
        }
    }
}
