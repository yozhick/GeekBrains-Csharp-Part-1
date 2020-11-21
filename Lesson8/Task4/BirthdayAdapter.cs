using System;

namespace Task4
{
    public class BirthdayAdapter
    {
        private Birthdays birthdays = new Birthdays();
        private IBirthdayView view;
        private int currentIndex;

        public BirthdayAdapter(IBirthdayView view)
        {
            this.view = view;
            AddEmptyValue();
            SetView();
        }

        private void SetView()
        {
            view.Name = birthdays[currentIndex].Name;
            view.Birthday = birthdays[currentIndex].Birthday;
            view.Index = (currentIndex + 1).ToString();
        }

        private void AddEmptyValue()
        {
            birthdays.Add(DateTime.Now, string.Empty);
        }

        public void CreateNewDatabase()
        {
            birthdays = new Birthdays();
            AddEmptyValue();
            currentIndex = 0;
            SetView();
        }

        public void OpenDataBase()
        {
            if (!view.TryGetFileNameToLoad(out string fileName))
                return;

            birthdays = new Birthdays(fileName);
            birthdays.Load();

            if (birthdays.Count == 0)
                AddEmptyValue();

            currentIndex = birthdays.Count - 1;
            SetView();
        }

        public void SaveDataBase()
        {
            if (birthdays.FileName == null)
                SaveDataBaseAs();
            else
                birthdays.Save();
        }

        public void SaveDataBaseAs()
        {
            if (!view.TryGetFileNameToSave(out string fileName))
                return;

            birthdays.FileName = fileName;
            birthdays.Save();
        }

        public void PreviousValue()
        {
            if (currentIndex == 0)
                return;

            currentIndex--;
            SetView();
        }

        public void NextValue()
        {
            if (currentIndex + 1 >= birthdays.Count)
                return;

            currentIndex++;
            SetView();
        }

        public void AddValue()
        {
            AddEmptyValue();
            currentIndex = birthdays.Count - 1;
            SetView();
        }

        public void SaveChanges()
        {
            birthdays[currentIndex].Birthday = view.Birthday;
            birthdays[currentIndex].Name = view.Name;

        }
    }
}
