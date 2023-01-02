namespace Calculator
{
    public class Calculator
    {
        public double DoPlus(params double[] num)
        {
            double result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                result += num[i];
            }
            return result;
        }
        public double DoMinus(params double[] num)
        {
            double result = 0;
            foreach (double item in num)
            {
                result += item;
            }
            return result;
        }
        public double DoMultiply(params double[] num)
        {
            double result = 1;
            foreach (double item in num)
            {
                result *= item;
            }
            return result;
        }
        public double DoDivide(params double[] num)
        {
            double result = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] == 0)
                {
                    continue;
                }
                result /= num[i];
            }
            return result;
        }
    }
}