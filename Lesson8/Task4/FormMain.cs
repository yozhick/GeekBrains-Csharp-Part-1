//*Используя полученные знания и класс TrueFalse в качестве шаблона,
//разработать собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
//        Михайлов Дмитрий Викторович

using System;
using System.Windows.Forms;

namespace Task4
{
    public partial class FormMain : Form, IBirthdayView
    {
        private BirthdayAdapter adapter;

        public FormMain()
        {
            InitializeComponent();
            adapter = new BirthdayAdapter(this);
        }

        string IBirthdayView.Name { get => tboxName.Text; set => tboxName.Text = value == string.Empty ? "<Введите имя>" : value; }
        public DateTime Birthday { get => dtpBirthday.Value; set => dtpBirthday.Value = value; }
        public string Index { set => lblIndex.Text = value; }

        public bool TryGetFileNameToLoad(out string fileName)
        {
            OpenFileDialog pfd = new OpenFileDialog();
            if (pfd.ShowDialog() == DialogResult.OK)
            {
                fileName = pfd.FileName;
                return true;
            }
            else
            {
                fileName = string.Empty;
                return false;
            }
        }

        public bool TryGetFileNameToSave(out string fileName)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
                return true;
            }
            else
            {
                fileName = string.Empty;
                return false;
            }
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            adapter.OpenDataBase();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            adapter.CreateNewDatabase();
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            adapter.SaveDataBase();
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            adapter.SaveDataBaseAs();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddValue_Click(object sender, EventArgs e)
        {
            adapter.AddValue();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            adapter.SaveChanges();
        }

        private void btnPreviousValue_Click(object sender, EventArgs e)
        {
            adapter.PreviousValue();
        }

        private void btnNextValue_Click(object sender, EventArgs e)
        {
            adapter.NextValue();
        }
    }
}
