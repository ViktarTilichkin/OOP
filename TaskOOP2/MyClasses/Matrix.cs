// Создать класс Matrix. + 
// Класс должен иметь следующие поля:
// двумерный массив чисел; +
// количество строк и столбцов в матрице. + 
// Класс должен иметь следующие методы:
// сложение с другой матрицей;+
// умножение на число; + 
// вывод на печать; + 
// умножение матриц.
// Значения заполняются рандомными числами. Сложение и умножение
// матриц возвращает новую матрицу.
// ДОДЕЛАТЬ!!!
namespace TaskOOP2.MyClasses;

public class Matrix
{
    public int[,] ItemMat;
    public int CountColumn;
    public int CountRow;

    public Matrix(int countRow, int countColumn)
    {
        CountColumn = countColumn;
        CountRow = countRow;
        ItemMat = new int[CountRow, CountColumn];
    }

    public void InitMatrix()
    {
        Random rnd = new Random();
        for (int i = 0; i < CountRow; i++)
        {
            for (int j = 0; j < CountColumn; j++)
            {
                ItemMat[i, j] = rnd.Next(-100, 100);
            }

        }
    }
    public Matrix? SummMatrix(Matrix matrix)
    {
        matrix.Print();
        Console.WriteLine();
        if (CountColumn == matrix.CountColumn && CountRow == matrix.CountRow)
        {
            Matrix matresult = new Matrix(CountRow, CountColumn);
            for (int i = 0; i < CountRow; i++)
            {
                for (int j = 0; j < CountColumn; j++)
                {
                    matresult.ItemMat[i, j] = ItemMat[i, j] + matrix.ItemMat[i, j];
                }
            }
            matresult.Print();
            return matresult;
        }
        return null;
    }
    public Matrix MatrixMultNum(int num)
    {
        Matrix matresult = new Matrix(CountRow, CountColumn);
        for (int i = 0; i < CountRow; i++)
        {
            for (int j = 0; j < CountColumn; j++)
            {
                matresult.ItemMat[i, j] = ItemMat[i, j] * num;
            }
        }
        matresult.Print();
        return matresult;
    }
    public Matrix? MiltMatrix(Matrix matrix)
    {
        matrix.Print();
        Console.WriteLine();
        if (CountColumn == matrix.CountColumn && CountRow == matrix.CountRow)
        {
            Matrix matresult = new Matrix(CountRow, CountColumn);
            for (int i = 0; i < CountRow; i++)
            {
                for (int j = 0; j < CountColumn; j++)
                {
                    matresult.ItemMat[i, j] = ItemMat[i, j] *  matrix.ItemMat[i, j];
                }
            }
            matresult.Print();
            return matresult;
        }
        return null;
    }
    public void Print()
    {
        for (int i = 0; i < CountRow; i++)
        {
            string text = "";
            for (int j = 0; j < CountColumn; j++)
            {
                text += ItemMat[i, j] + ", ";
            }
            Console.WriteLine(text.Remove(text.Length - 2, 2));
        }
    }
}