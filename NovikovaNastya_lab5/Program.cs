using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovikovaNastya_lab5
{
    internal class Program
    {
        class TemperatureCalculator
        {
            private int[,] temperature = new int[12, 30];

            public void GenerateRandomTemperatures()
            {
                Random random = new Random();
                for (int month = 0; month < 12; month++)
                {
                    for (int day = 0; day < 30; day++)
                    {
                        temperature[month, day] = random.Next(-20, 38);
                    }
                }
            }

            public double[] CalculateAverageTemperatures()
            {
                double[] averages = new double[12];

                for (int month = 0; month < 12; month++)
                {
                    double sum = 0;
                    for (int day = 0; day < 30; day++)
                    {
                        sum += temperature[month, day];
                    }
                    averages[month] = sum / 30; 
                }

                return averages;
            }

            public void PrintAverageTemperatures(double[] averages)
            {
                Console.WriteLine("Средние температуры за каждый месяц:");
                for (int month = 0; month < averages.Length; month++)
                {
                    Console.WriteLine($"Месяц {month + 1}: {averages[month]:F1}C");
                }
            }

            public void SortAndPrintSortedAverages(double[] averages)
            {
                Array.Sort(averages);
                Console.WriteLine("\nОтсортированные средние температуры:");
                foreach (var avgTemp in averages)
                {
                    Console.WriteLine($"{avgTemp:F1}C");
                }
            }
            /// <summary>
            ///  Написать программу, вычисляющую среднюю температуру за год.
            ///  Создать двумерный рандомный массив temperature[12,30], в котором будет храниться температура для каждого дня месяца (предполагается, что в каждом месяце 30 дней).
            ///  Сгенерировать значения температур случайным образом. Для каждого месяца распечатать среднюю температуру.
            ///  Для этого написать метод, который по массиву temperature [12,30] для каждого месяца вычисляет среднюю температуру в нем, и в качестве результата возвращает массив средних температур.
            ///  Полученный массив средних температур отсортировать по возрастанию.
            /// </summary>
            /// <param name="args"></param>
            static void Main(string[] args)
            {
                Console.WriteLine("Упражнение 6.3");
                TemperatureCalculator calculator = new TemperatureCalculator();

                calculator.GenerateRandomTemperatures();

                double[] averageTemperatures = calculator.CalculateAverageTemperatures();

                calculator.PrintAverageTemperatures(averageTemperatures);

                calculator.SortAndPrintSortedAverages(averageTemperatures);
                Console.ReadLine();
            }
        }
    }
}
