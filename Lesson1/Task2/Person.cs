using System;

namespace Task2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Person
        /// </summary>
        /// <param name="weight">Вес в килограммах</param>
        /// <param name="height">Рост в сантиметрах</param>
        public Person(int weight, int height)
        {
            Weight = weight;
            Height = height;
        }

        public double GetBodyMassIndex()
        {
            var heightInMeters = Height / 100d;
            return Weight / Math.Pow(heightInMeters, 2);
        }

        public override string ToString()
        {
            return $"Имя: {Name}. Возраст: {Age} лет. Вес: {Weight} кг. Рост: {Height} см.";
        }
    }
}
