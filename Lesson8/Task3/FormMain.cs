//а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
//б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
//в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
//г)*Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
//        Михайлов Дмитрий Викторович

using System;
using System.Windows.Forms;

namespace Task3
{
    public partial class FormMain : Form
    {
        private TrueFalse database;

        public FormMain()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            database = new TrueFalse();
            database.Add("<Ваш первый вопрос>", false);
            nudNumber.Minimum = 1;
            nudNumber.Maximum = 1;
            nudNumber.Value = 1;
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            var result =
                MessageBox.Show(
                    "Все несохранённые изменения будут утеряны! Продолжить?",
                    "Внимание!",
                    MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            InitializeDatabase();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            int nudValue = (int)nudNumber.Value;
            tboxQuestion.Text = database[nudValue - 1].Text;
            cboxTrue.Checked = database[nudValue - 1].TrueFalse;
        }
        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database.FileName == string.Empty)
                SaveAs();
            else
                database.Save();
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database.FileName = sfd.FileName;
                database.Save();
            }
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }
        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }
    }
}
