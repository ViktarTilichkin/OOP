namespace TaskIntro.MyClasses
{
    public class Fibonacci
    {
        //         У вас есть класс Fibonacci.Создать в нем функцию для вывода ряда фибоначчи.
        // Необходимо добавить проверки.

        private int Index;
        private ulong[] TempFib = new ulong[2] { 0, 1 };
        private ulong[] ResultFib;
        public Fibonacci()
        {
            Index = 1;
            ResultFib = TempFib;
        }
        public Fibonacci(int length)
        {
            if (length > 1)
            {
                Index = length;
                ResultFib = new ulong[length];
                Array.Copy(TempFib, ResultFib, TempFib.Length);
            }
            else
            {
                ResultFib = TempFib;
                Console.WriteLine("error input index");
            }
        }

        public void PrintFib()
        {
            for (int i = 2; i < Index; i++)
            {
                ResultFib[i] = ResultFib[i - 1] + ResultFib[i - 2];
            }
            Console.WriteLine(string.Join(", ", ResultFib));
            Console.WriteLine("hello Fibonacci");
        }
    }
}