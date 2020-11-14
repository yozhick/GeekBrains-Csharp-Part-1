//Используя Windows Forms, разработать игру «Угадай число».
//Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
//Компьютер говорит, больше или меньше загаданное число введенного.  
//a) Для ввода данных от человека используется элемент TextBox;
//б) **Реализовать отдельную форму c TextBox для ввода числа.
//        Михайлов Дмитрий Викторович

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
    public partial class frmMain : Form
    {
        int number;
        int triesCount = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpenKeyboard_Click(object sender, EventArgs e)
        {
            frmInput frmInput = new frmInput()
            {
                Owner = this
            };

            btnOpenKeyboard.Visible = false;
            frmInput.FormClosed += FrmInput_FormClosed;
            frmInput.KeyPress += FrmInput_KeyPress;
            tbInput.ReadOnly = true;
            frmInput.Show();
        }

        private void FrmInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case (char)Keys.D0:
                case (char)Keys.D1:
                case (char)Keys.D2:
                case (char)Keys.D3:
                case (char)Keys.D4:
                case (char)Keys.D5:
                case (char)Keys.D6:
                case (char)Keys.D7:
                case (char)Keys.D8:
                case (char)Keys.D9:
                    tbInput.Text += $"{(char)e.KeyChar}";
                    break;

                case (char)Keys.Enter:
                    Input();
                    break;

                case (char)Keys.Back:
                    string currentText = tbInput.Text;
                    if (currentText == string.Empty)
                        break;
                    tbInput.Text = currentText.Substring(0, currentText.Length - 1);
                    break;
            }
        }

        private void FrmInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnOpenKeyboard.Visible = true;
            tbInput.ReadOnly = false;
        }

        private void miGameStart_Click(object sender, EventArgs e)
        {
            miGameStart.Enabled = false;
            miGameStop.Enabled = true;
            number = new Random().Next(1, 100);
            lblMessage.Text = "Игра началась, угадайте число от 1 до 100.";
        }

        private void miGameStop_Click(object sender, EventArgs e)
        {
            GameStop();
        }

        private void GameStop()
        {
            miGameStart.Enabled = true;
            miGameStop.Enabled = false;
            number = 0;
            triesCount = 0;
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Input();
            }
        }

        private void Input()
        {
            if (number == 0)
                return;

            triesCount++;
            int checkResult = CheckVictory();

            if (checkResult == 0)
            {
                GameStop();
                lblMessage.Text = $"Вы победили! Кол-во попыток {triesCount}.";
            }
            else if(checkResult > 0)
            {
                lblMessage.Text = $"Введённое число больше. Кол-во попыток {triesCount}.";
            }
            else
            {
                lblMessage.Text = $"Введённое число меньше. Кол-во попыток {triesCount}.";
            }          
        }

        private int CheckVictory()
        {
            return int.Parse(tbInput.Text).CompareTo(number);
        }
    }
}
