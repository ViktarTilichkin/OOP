using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dayli._18._02
{
    internal class Task1
    {
        public int[,] Matrix;
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public Task1(int rows, int columns)
        {
            Rows = rows; Columns = columns;
            Matrix = new int[Rows, Columns];
        }
        public void InitMatrix()
        {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Matrix[i, j] = rnd.Next(0, 20);
                }
            }
        }
        public void Revers()
        {
            int[,] newMatrix = new int[Columns, Rows];
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    newMatrix[i, j] = Matrix[j, i];
                }
            }
            (Rows, Columns) = (Columns, Rows);
            Matrix = newMatrix;
        }
        public override string ToString()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            return "";
        }
    }
}
