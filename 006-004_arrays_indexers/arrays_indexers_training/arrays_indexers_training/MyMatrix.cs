using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_indexers_training
{
    internal class MyMatrix
    {
        private int[,] data;
        private int rows;
        private int cols;

        public MyMatrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
            {
                throw new ArgumentException("Размеры матрицы должны быть положительными");
            }

            this.rows = rows;
            this.cols = cols;
            data = new int[rows, cols];
        }

        public int get(int row, int col)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols)
            {
                throw new ArgumentOutOfRangeException("Недопустимые индексы строки или столбца");
            }

            return data[row, col];
        }

        public void set(int row, int col, int value)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols)
            {
                throw new ArgumentOutOfRangeException("Недопустимые индексы строки или столбца");
            }

            data[row, col] = value;
        }

        public void resize(int newRows, int newCols)
        {
            if (newRows <= 0 || newCols <= 0)
            {
                throw new ArgumentException("Новые размеры матрицы должны быть положительными");
            }

            int[,] newData = new int[newRows, newCols];

            for (int i = 0; i < Math.Min(rows, newRows); i++)
            {
                for (int j = 0; j < Math.Min(cols, newCols); j++)
                {
                    newData[i, j] = data[i, j];
                }
            }

            data = newData;
            rows = newRows;
            cols = newCols;
        }

        public void fillMatrix(int rows, int cols)
        {
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    data[i, j] = rnd.Next(1, 100);
        }
        public void print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(data[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public int getRows()
        {
            return rows;
        }

        public int getCols()
        {
            return cols;
        }

        public MyMatrix getSubmatrix(int startRow, int startCol, int numRows, int numCols)
        {
            if (startRow < 0 || startRow >= rows || startCol < 0 || startCol >= cols ||
                numRows <= 0 || numCols <= 0 ||
                startRow + numRows > rows || startCol + numCols > cols)
            {
                throw new ArgumentException("Недопустимые параметры для получения подматрицы");
            }

            MyMatrix submatrix = new MyMatrix(numRows, numCols);

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    submatrix.set(i, j, data[startRow + i, startCol + j]);
                }
            }

            return submatrix;
        }
    }
}
