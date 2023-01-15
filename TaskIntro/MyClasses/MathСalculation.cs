namespace TaskIntro.MyClasses
{
    public class MathCalculation
    {
        //         У вас есть класс MathСalculation. Создать в нем функцию для подсчета всех
        // положительных чисел. Проверки.

        private int[] Numbers;
        public MathCalculation()
        {
            Numbers = new int[0];
        }
        public MathCalculation(params int[] num)
        {
            Numbers = num;
        }
        public void SumPositivenumbers()
        {
            int countPosNum = 0;
            for (int i=0; i < Numbers.Length; i++)
            {
                if(Numbers[i] > 0)
                {
                    countPosNum++;
                }
            }
            Console.WriteLine($"положительных чисел {countPosNum}");
        }
    }
}