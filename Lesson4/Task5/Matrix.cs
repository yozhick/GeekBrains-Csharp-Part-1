//*а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами.
//    Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного,
//    свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, 
//    метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
//**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
//**в) Обработать возможные исключительные ситуации при работе с файлами.
//        Михайлов Дмитрий Викторович

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Task5
{
    public class Matrix
    {
        private int[,] array;
        private int capacityX, capacityY;
        private int min;
        private int max;
        private bool minMaxCalculated;
        public int Min
        {
            get
            {
                if (!minMaxCalculated)
                {
                    CalculateMinMaxElement();
                    minMaxCalculated = true;
                }

                return min;
            }
        }

        public int Max
        {
            get
            {
                if (!minMaxCalculated)
                {
                    CalculateMinMaxElement();
                    minMaxCalculated = true;
                }
                return max;
            }
        }

        public Matrix(int capacityX, int capacityY)
        {
            this.capacityX = capacityX;
            this.capacityY = capacityY;

            array = new int[capacityX, capacityY];
            FillWithRandomNumbers();
        }

        public Matrix(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new Exception("Невозможно заполнить массив из файла, т.к. он не создан");
            }

            var lines = File.ReadAllLines(filePath);
            int[][] array = new int[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                // Читерю, потому что не успеваю вовремя сдать. (((
                var elements = lines[i].Split(' ')
                    .Select(p => int.TryParse(p, out int result) ? result : throw new Exception("Неудачное преобразование в число")).ToArray();
                array[i] = elements;
            }

            var lenght = array.First().Length;

            foreach (var item in array)
            {
                if (item.Length != lenght)
                    throw new Exception("Невозможно заполнить массив, т.к. кол-во элементов в строках различается");
            }

            this.capacityX = lines.Length;
            this.capacityY = lenght;
            this.array = new int[capacityX, capacityY];

            for (int i = 0; i < capacityX; i++)
            {
                for (int j = 0; j < capacityY; j++)
                {
                    this.array[i, j] = array[i][j];
                }
            }

        }

        private void CalculateMinMaxElement()
        {
            for (int i = 0; i < capacityX; i++)
            {
                for (int j = 0; j < capacityY; j++)
                {
                    int currentValue = array[i, j];

                    if (currentValue < min)
                        min = currentValue;

                    if (currentValue > max)
                        max = currentValue;
                }
            }
        }

        public void MaxElementIndex(out int indexX, out int indexY)
        {
            indexX = -1;
            indexY = -1;

            for (int i = 0; i < this.capacityX; i++)
            {
                for (int j = 0; j < this.capacityY; j++)
                {
                    int currentValue = array[i, j];
                    if (currentValue == Max)
                    {
                        indexX = i;
                        indexY = j;
                        return;
                    }

                }
            }
        }



        private void FillWithRandomNumbers()
        {
            Random random = new Random();

            for (int i = 0; i < capacityX; i++)
            {
                for (int j = 0; j < capacityY; j++)
                {
                    array[i, j] = random.Next(-100, 100);
                }
            }
        }

        public int GetSum()
        {
            int sum = 0;

            for (int i = 0; i < capacityX; i++)
            {
                for (int j = 0; j < capacityY; j++)
                {
                    sum += array[i, j];
                }
            }

            return sum;
        }

        public int GetSum(int notLess)
        {
            int sum = 0;

            for (int i = 0; i < capacityX; i++)
            {
                for (int j = 0; j < capacityY; j++)
                {
                    
                    int currentValue = array[i, j];
                    if (currentValue >= notLess)
                    {
                        sum += currentValue;
                    }
                }
            }

            return sum;
        }

        public void UploadToFile(string filePath)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    for (int i = 0; i < capacityX; i++)
                    {
                        StringBuilder line = new StringBuilder();
                        for (int j = 0; j < capacityY; j++)
                        {
                            line.Append($"{array[i, j]} ");
                        }

                        streamWriter.WriteLine(line.ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
