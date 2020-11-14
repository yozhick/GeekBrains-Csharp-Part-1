namespace Task2
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.msHeader = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miGame = new System.Windows.Forms.ToolStripMenuItem();
            this.miGameStart = new System.Windows.Forms.ToolStripMenuItem();
            this.miGameStop = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.MaskedTextBox();
            this.btnOpenKeyboard = new System.Windows.Forms.Button();
            this.msHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // msHeader
            // 
            this.msHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.msHeader.Location = new System.Drawing.Point(0, 0);
            this.msHeader.Name = "msHeader";
            this.msHeader.Size = new System.Drawing.Size(654, 24);
            this.msHeader.TabIndex = 7;
            this.msHeader.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGame,
            this.miExit});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // miGame
            // 
            this.miGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGameStart,
            this.miGameStop});
            this.miGame.Name = "miGame";
            this.miGame.Size = new System.Drawing.Size(180, 22);
            this.miGame.Text = "Игра";
            // 
            // miGameStart
            // 
            this.miGameStart.Name = "miGameStart";
            this.miGameStart.Size = new System.Drawing.Size(180, 22);
            this.miGameStart.Text = "Начать";
            this.miGameStart.Click += new System.EventHandler(this.miGameStart_Click);
            // 
            // miGameStop
            // 
            this.miGameStop.Enabled = false;
            this.miGameStop.Name = "miGameStop";
            this.miGameStop.Size = new System.Drawing.Size(180, 22);
            this.miGameStop.Text = "Закончить";
            this.miGameStop.Click += new System.EventHandler(this.miGameStop_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(109, 22);
            this.miExit.Text = "Выход";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.Location = new System.Drawing.Point(12, 49);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(630, 42);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Добро пожаловать в игру \"Угадай число\"!";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(194, 109);
            this.tbInput.Mask = "000";
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(229, 53);
            this.tbInput.TabIndex = 9;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // btnOpenKeyboard
            // 
            this.btnOpenKeyboard.Location = new System.Drawing.Point(429, 109);
            this.btnOpenKeyboard.Name = "btnOpenKeyboard";
            this.btnOpenKeyboard.Size = new System.Drawing.Size(78, 53);
            this.btnOpenKeyboard.TabIndex = 10;
            this.btnOpenKeyboard.Text = "Клавиатура";
            this.btnOpenKeyboard.UseVisualStyleBackColor = true;
            this.btnOpenKeyboard.Click += new System.EventHandler(this.btnOpenKeyboard_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 192);
            this.Controls.Add(this.btnOpenKeyboard);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.msHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Угадай число";
            this.msHeader.ResumeLayout(false);
            this.msHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msHeader;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miGame;
        private System.Windows.Forms.ToolStripMenuItem miGameStart;
        private System.Windows.Forms.ToolStripMenuItem miGameStop;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.MaskedTextBox tbInput;
        private System.Windows.Forms.Button btnOpenKeyboard;
    }
}

