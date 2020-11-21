//**Написать программу - преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
//      Михайлов Дмитрий Викторович

using System;
using System.IO;
using System.Windows.Forms;

namespace Task5
{
    public partial class FormMain : Form
    {
        private Converter converter = new Converter();

        public FormMain()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            string extension = Path.GetExtension(ofd.FileName).ToLower();
            switch (extension)
            {
                case ".xml":
                    converter.LoadFromXml(ofd.FileName);
                    break;
                case ".csv":
                    converter.LoadFromCsv(ofd.FileName);
                    break;
                default:
                    MessageBox.Show("Неизвестный формат файла. Попробуйте ещё раз.");
                    break;
            }

        }

        private void btnSaveCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "csv";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                converter.SaveToCsv(sfd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "xml";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                converter.SaveToXml(sfd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
