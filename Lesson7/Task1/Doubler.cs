//а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
//в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
//Вся логика игры должна быть реализована в классе с удвоителем.
//        Михайлов Дмитрий Викторович

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Task1
{
    public partial class Doubler : Form
    {

        private int currentNumber = 0;
        private int gameNumber;
        private int commandsCount = 0;
        private Stack<int> commands = new Stack<int>();

        public Doubler()
        {
            InitializeComponent();
        }

        private void OnCommandExecution()
        {
            commands.Push(currentNumber);
            lblCommandCounter.Text = (++commandsCount).ToString();            
        }

        private void CancelLastCommand(object sender, EventArgs e)
        {
            if (commands.Count == 0)
                return;

            currentNumber = commands.Pop();
            lblNumber.Text = currentNumber.ToString();
            lblCommandCounter.Text = (--commandsCount).ToString();
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            OnCommandExecution();
            lblNumber.Text = (++currentNumber).ToString();
        }
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            OnCommandExecution();
            currentNumber *= 2;
            lblNumber.Text = currentNumber.ToString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            OnCommandExecution();
            Reset();
        }

        private void Reset()
        {
            currentNumber = 0;
            lblNumber.Text = currentNumber.ToString();
        }

        private void CheckVictory(object sender, EventArgs e)
        {
            if (currentNumber == gameNumber)
            {
                MessageBox.Show("Поздравляем! Вы достигли цели!");
                GameStop();
            }
        }

        private void miGameStart_Click(object sender, EventArgs e)
        {
            miGameStart.Enabled = false;
            miGameStop.Enabled = true;
            Text = "Удвоитель: режим игры";

            gameNumber = new Random().Next(1, 1024);

            commands.Clear();
            Reset();            
            GameSubscribe();            

            commandsCount = 0;
            lblCommandCounter.Text = commandsCount.ToString();

            MessageBox.Show($"Игра началась! Загаданно число: {gameNumber}");
        }

        private void miGameStop_Click(object sender, EventArgs e)
        {
            GameStop();
        }

        private void GameStop()
        {
            miGameStart.Enabled = true;
            miGameStop.Enabled = false;
            GameUnsubscribe();
            Text = "Удвоитель: простой режим";
        }

        private void GameSubscribe()
        {
            btnCommand1.Click += CheckVictory;
            btnCommand2.Click += CheckVictory;
            btnReset.Click += CheckVictory;
        }

        private void GameUnsubscribe()
        {
            btnCommand1.Click -= CheckVictory;
            btnCommand2.Click -= CheckVictory;
            btnReset.Click -= CheckVictory;
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
