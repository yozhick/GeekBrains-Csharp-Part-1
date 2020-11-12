namespace Task5
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public Person(string firstName, string lastName, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public override string ToString()
        {
            return $"Имя: {FirstName}. Фамилия: {LastName}. Город проживания: {City}.";
        }
    }
}
