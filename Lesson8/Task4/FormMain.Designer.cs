
namespace Task4
{
    partial class FormMain
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
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.btnPreviousValue = new System.Windows.Forms.Button();
            this.btnNextValue = new System.Windows.Forms.Button();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpBirthday.Location = new System.Drawing.Point(44, 97);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(269, 20);
            this.dtpBirthday.TabIndex = 0;
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(359, 24);
            this.msMainMenu.TabIndex = 1;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.toolStripSeparator1,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(180, 22);
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(180, 22);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(180, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(180, 22);
            this.miSaveAs.Text = "Save as...";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(180, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(44, 81);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(90, 13);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "День рождения:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Имя:";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(44, 48);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(269, 20);
            this.tboxName.TabIndex = 4;
            // 
            // btnPreviousValue
            // 
            this.btnPreviousValue.Location = new System.Drawing.Point(105, 134);
            this.btnPreviousValue.Name = "btnPreviousValue";
            this.btnPreviousValue.Size = new System.Drawing.Size(29, 23);
            this.btnPreviousValue.TabIndex = 5;
            this.btnPreviousValue.Text = "<";
            this.btnPreviousValue.UseVisualStyleBackColor = true;
            this.btnPreviousValue.Click += new System.EventHandler(this.btnPreviousValue_Click);
            // 
            // btnNextValue
            // 
            this.btnNextValue.Location = new System.Drawing.Point(215, 134);
            this.btnNextValue.Name = "btnNextValue";
            this.btnNextValue.Size = new System.Drawing.Size(29, 23);
            this.btnNextValue.TabIndex = 6;
            this.btnNextValue.Text = ">";
            this.btnNextValue.UseVisualStyleBackColor = true;
            this.btnNextValue.Click += new System.EventHandler(this.btnNextValue_Click);
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(44, 173);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(129, 44);
            this.btnAddValue.TabIndex = 7;
            this.btnAddValue.Text = "Новая запись";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(184, 173);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(129, 44);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Сохранить запись";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.Location = new System.Drawing.Point(140, 134);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(73, 23);
            this.lblIndex.TabIndex = 9;
            this.lblIndex.Text = "0";
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 238);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnAddValue);
            this.Controls.Add(this.btnNextValue);
            this.Controls.Add(this.btnPreviousValue);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "FormMain";
            this.Text = "Дни рождения";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Button btnPreviousValue;
        private System.Windows.Forms.Button btnNextValue;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblIndex;
    }
}

