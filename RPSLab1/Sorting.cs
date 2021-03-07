using System;

namespace RPSLab1
{
    public class ArrayWorking
    {
       public double[] Sorting(double[] dataArray) //Сортировка массива
        {
            double[] sortedArray;
            sortedArray = new double[dataArray.Length];
            int countPositive = 0, countNull = 0, countNegative = 0;
            //Подсчет положительных, отрицательных чисел и нулей
            for (int i = 0; i < dataArray.Length; i++)
            {
                if (dataArray[i] > 0)
                    countPositive++;
                else if (dataArray[i] == 0)
                    countNull++;
                else
                    countNegative++;
            }
            double[] positiveArray = new double[countPositive];
            double[] nullArray = new double[countNull];
            double[] negativeArray = new double[countNegative];
            //Заполнение массивов с положительными, отрицательными числами и нулями
            int j = 0, k = 0, l = 0;
            for (int i = 0; i < dataArray.Length; i++)
            {
                if (dataArray[i] > 0)
                {
                    positiveArray[j] = dataArray[i];
                    j++;
                }
                else if (dataArray[i] == 0)
                {
                    nullArray[k] = dataArray[i];
                    k++;
                }
                else
                {
                    negativeArray[l] = dataArray[i];
                    l++;
                }
            }

            //Заполнение итогового массива
            j = 0;
            for (int i = 0; i < countPositive; i++)
            {
                sortedArray[i] = positiveArray[j];
                j++;
            }

            j = 0;
            for (int i = countPositive; i < countPositive + countNull; i++)
            {
                sortedArray[i] = nullArray[j];
                j++;
            }

            j = 0;
            for (int i = countPositive + countNull; i < countPositive + countNull + countNegative; i++)
            {
                sortedArray[i] = negativeArray[j];
                j++;
            }
            return sortedArray;
        }

       public double[] RandomArray(int sizeArray) //Заполнение массива случайными числами 
        {
            Random randomValue = new Random();
            double[] randomArray = new double[sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                randomArray[i] = randomValue.Next(-50, 50);
            }
            return randomArray;
        }
    }
}
