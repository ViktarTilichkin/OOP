// 11. Реализуйте класс Sort, сдержащий метод SortData, сортирующий все числа
// статичного массива сортировкой пузырьком

namespace Myclasses.Sort;

public class Sort
{
    public void SortData(out int[] numbers, params int[] num)
    {
        for (int i = 0; i < num.Length - 1; i++)
        {
            for (int j = 0; j < num.Length - 1; j++)
            {
                if (num[j] > num[j + 1])
                {
                    int temp = num[j];
                    num[j] = num[j+1];
                    num[j+1]= temp;
                }
            }
        }
        numbers = num;
    }

}