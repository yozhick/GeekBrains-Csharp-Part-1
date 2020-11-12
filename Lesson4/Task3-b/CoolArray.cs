using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task3_b
{
    public class CoolArray
    {
        private int[] array;
        private int maxCount;
        private bool maxCountCalculated;
        private Random random = new Random();

        public int Max => array.Max();
        public int Sum => array.Sum();

        public int MaxCount
        {
            get
            {
                if (!maxCountCalculated)
                {
                    int max = Max;
                    maxCount = 0;

                    foreach (var arrayElement in array)
                    {
                        if (arrayElement == max)
                            maxCount++;
                    }
                    maxCountCalculated = true;
                }

                return maxCount;
            }
        }

        public int this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        private CoolArray()
        {

        }

        public CoolArray(int capacity)
        {
            array = new int[capacity];
            for (int i = 0; i < capacity; i++)
                array[i] = random.Next(1, 101);
        }

        public CoolArray(int capacity, int startValue, int step)
        {
            array = new int[capacity];
            int currentValue = startValue;
            for (int i = 0; i < capacity; i++)
            {
                array[i] = currentValue;
                currentValue += step;
            }
        }

        public CoolArray(string filename)
        {
            if (File.Exists(filename))
            {
                string[] ss = File.ReadAllLines(filename);
                array = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                    array[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Error load file");
        }

        public CoolArray Inverse()
        {
            CoolArray newArray = new CoolArray
            {
                array = new int[array.Length]
            };

            for (int i = 0; i < array.Length; i++)
            {
                newArray.array[i] = -array[i];
            }

            return newArray;
        }

        public void Multi(int multiplier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= multiplier;
            }

            maxCountCalculated = false;
        }

        public Dictionary<int, int> CountElements()
        {
            Dictionary<int, int> elementsCounter = new Dictionary<int, int>();
            foreach (var element in array)
            {
                if (elementsCounter.ContainsKey(element))
                    elementsCounter[element]++;
                else
                    elementsCounter.Add(element, 1);
            }

            return elementsCounter;
        }

        public void Print()
        {
            foreach (int el in array)
                Console.Write("{0,4}", el);
        }
    }
}
