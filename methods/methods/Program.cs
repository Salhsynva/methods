using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //string word = Console.ReadLine();
            //char letter = Convert.ToChar(Console.ReadLine());
            //int index = FindIndex(word, letter);
            //Console.WriteLine("char deyerinin indeksi: " + index);
            #endregion

            #region task2
            //Console.WriteLine("ededi daxil edin: ");
            //string numberstr = Console.ReadLine();
            //int number = Convert.ToInt32(numberstr);
            //int squareRoot = FindSquareRoot(number);
            //Console.WriteLine($"edede en yaxin olan kokati: {squareRoot}");
            #endregion

            #region task3
            //Console.WriteLine("ededi daxil edin: ");
            //string numstr = Console.ReadLine();
            //int num = Convert.ToInt32(numstr);
            //int sumOfDigits = SumOfDigits(num);
            //Console.WriteLine("ededin reqemleri cemi: " + sumOfDigits);
            #endregion

            #region task4
            //Console.WriteLine("massivin uzunlugunu daxil edin: ");
            //string sizeStr = Console.ReadLine();
            //int size = Convert.ToInt32(sizeStr);
            //int[] numbers = new int[size];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"{i}. deyeri daxil edin: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int maxNum = MaxNumberOfArray(numbers);
            //Console.WriteLine("arraydaki en boyuk eded :" + maxNum);
            #endregion

            #region task5
            //Console.WriteLine("massivin uzunlugunu daxil edin: ");
            //string sizeStr = Console.ReadLine();
            //int size = Convert.ToInt32(sizeStr);
            //int[] numbers = new int[size];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"{i}. deyeri daxil edin:");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int[] positiveArray = PositiveArray(numbers);
            //Console.WriteLine("yeni array: ");
            //foreach (var item in positiveArray)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
        static int FindIndex(string output, char letter)
        {
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == letter)
                    return i;
            }
            return -1;
        }

        static int FindSquareRoot(int number)
        {
            if(number >= 0)
            {
                for (int i = 0; i <= number; i++)
                {
                    if (i * i == number)
                        return i;
                    else if (i * i > number)
                        return i - 1;
                }
            }
            return -1;
        }
           
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while(number > 0 || number < 0)
            {
                sum += number % 10;
                number = (number - number % 10) / 10;
            }
            return sum;
        }

        static int MaxNumberOfArray(int[] output)
        {
            int max = output[0];
            for (int i = 0; i < output.Length; i++)
            {
                if (max < output[i])
                    max = output[i];
            }
            return max;
        }

        static int[] PositiveArray(int[] numbers)
        {
            int length = numbers.Length;
            int[] positiveNumbers = new int[length];
            int j = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    positiveNumbers[j] = -numbers[i];
                else
                    positiveNumbers[j] = numbers[i];
                j++;
            }
            return positiveNumbers;
        }
    }
}
