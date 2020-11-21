using System;

namespace Task4
{
    [Serializable]
    public class Person
    {
        private DateTime birthday;
        private string name;
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Name { get => name; set => name = value; }

        private Person()
        {

        }

        public Person(DateTime birthday, string name)
        {
            this.birthday = birthday;
            this.name = name;
        }
    }
}
