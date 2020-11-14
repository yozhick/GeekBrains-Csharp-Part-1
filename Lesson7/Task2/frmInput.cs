using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class frmInput : Form
    {
        public frmInput()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.D0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.D1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.D2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.D3));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.D4));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.D5));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.D6));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.D7));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.D8));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.D9));
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.Enter));
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            OnKeyPress(new KeyPressEventArgs((char)Keys.Back));
        }
    }
}
