namespace Task1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"Имя: {Name}. Возраст: {Age} лет. Вес: {Weight} кг. Рост: {Height} см."; 
        }
    }
}
