using System.Reflection;
using System.Windows.Forms;

namespace Task3
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            lblVersion.Text = $"Версия: { Assembly.GetExecutingAssembly().GetName().Version }";
        }
    }
}
