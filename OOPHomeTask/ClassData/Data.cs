namespace ClassData;
// Задача
// Написать обобщенный класс (без ограничений)
// поле Items массив 
// метод добавления
// метод поиск индеса по значению
// удаления значения (по индексу, удаление по занчению)
// метод вывода

public class CustomClass<T>
{
    public T?[] ArrayT;
    public int Index = 0;


    public CustomClass(int arrayLength)
    {
        ArrayT = new T[arrayLength];
    }
    public bool AddValue(T value)
    {
        if (value != null)
        {
            if(Index == ArrayT.Length)
            {
                return false;
            }
            ArrayT[Index++] = value;
            return true;
        }
        return false;
    }
    public int SearchIndex(T value)
    {
        if (value != null)
        {
            for (int i = 0; i < ArrayT.Length; i++)
            {
                if (value.Equals(ArrayT[i]))
                {
                    return i;
                }
            }
        }
        return -1;
    }
    public bool RemoveByIndex(int index)
    {
        if (index >= 0 && index <= ArrayT.Length)
        {
            ArrayT[index] = default;
            return true;
        }
        return false;
    }
    public bool RemoveByValue(T value)
    {
        if (value != null)
        {
            for (int i = 0; i < ArrayT.Length; i++)
            {
                if (value.Equals(ArrayT[i]))
                {
                    ArrayT[i] = default;
                    return true;
                }
            }
        }
        return false;
    }

    public void Show()
    {
        foreach (T? item in ArrayT)
        {
            if (item != null)
            {
                Console.WriteLine(item);
            }
        }
    }

}