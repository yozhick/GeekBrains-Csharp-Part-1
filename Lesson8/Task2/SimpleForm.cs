//Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
//        Михайлов Дмитрий Викторович

using System.Windows.Forms;

namespace Task2
{
    public partial class SimpleForm : Form
    {
        public SimpleForm()
        {
            InitializeComponent();            
            Binding binding = new Binding("Text", NumericUpDown, "Value");
            TextBox.DataBindings.Add(binding);
        }
    }
}
