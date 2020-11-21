using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task4
{
    class Birthdays
    {
        private string fileName;
        private List<Person> list;

        public string FileName
        {
            get => fileName;
            set => fileName = value;
        }

        public Birthdays() : this (null)
        {
                
        }

        public Birthdays(string fileName)
        {
            this.fileName = fileName;
            list = new List<Person>();
        }

        public void Add(DateTime birthday, string name)
        {
            list.Add(new Person(birthday, name));
        }

        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }


        public Person this[int index]
        {
            get { return list[index]; }
        }

        public void Save()
        {
            if (fileName == null)
                throw new Exception("Не указано имя файла для сохранения.");

            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Person>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        public void Load()
        {
            if (fileName == null)
                throw new Exception("Не указан источник.");

            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Person>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Person>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}
