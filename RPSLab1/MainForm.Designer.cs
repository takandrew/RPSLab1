
namespace RPSLab1
{
    partial class MainForm
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
            this.ManualInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ManualInputButton = new System.Windows.Forms.Button();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.SortedDataTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИсходныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРезультатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IncorrectDataWarningLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChooseInputFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SizeOfArrayUpDown = new System.Windows.Forms.NumericUpDown();
            this.FileInputRadioButton = new System.Windows.Forms.RadioButton();
            this.RandomInputRadioButton = new System.Windows.Forms.RadioButton();
            this.ManualInputRadioButton = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeOfArrayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ManualInputTextBox
            // 
            this.ManualInputTextBox.Location = new System.Drawing.Point(53, 133);
            this.ManualInputTextBox.Name = "ManualInputTextBox";
            this.ManualInputTextBox.Size = new System.Drawing.Size(138, 22);
            this.ManualInputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите массив";
            // 
            // ManualInputButton
            // 
            this.ManualInputButton.Location = new System.Drawing.Point(53, 172);
            this.ManualInputButton.Name = "ManualInputButton";
            this.ManualInputButton.Size = new System.Drawing.Size(138, 29);
            this.ManualInputButton.TabIndex = 2;
            this.ManualInputButton.Text = "Ввести";
            this.ManualInputButton.UseVisualStyleBackColor = true;
            this.ManualInputButton.Click += new System.EventHandler(this.ManualInputButton_Click);
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(233, 237);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ReadOnly = true;
            this.DataTextBox.Size = new System.Drawing.Size(278, 22);
            this.DataTextBox.TabIndex = 4;
            // 
            // SortButton
            // 
            this.SortButton.Enabled = false;
            this.SortButton.Location = new System.Drawing.Point(275, 402);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(194, 31);
            this.SortButton.TabIndex = 6;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SortedDataTextBox
            // 
            this.SortedDataTextBox.Location = new System.Drawing.Point(48, 358);
            this.SortedDataTextBox.Name = "SortedDataTextBox";
            this.SortedDataTextBox.ReadOnly = true;
            this.SortedDataTextBox.Size = new System.Drawing.Size(636, 22);
            this.SortedDataTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Отсортированный массив";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Исходный массив";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьИсходныеДанныеToolStripMenuItem,
            this.сохранитьРезультатToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьИсходныеДанныеToolStripMenuItem
            // 
            this.сохранитьИсходныеДанныеToolStripMenuItem.Name = "сохранитьИсходныеДанныеToolStripMenuItem";
            this.сохранитьИсходныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.сохранитьИсходныеДанныеToolStripMenuItem.Text = "Сохранить исходные данные";
            this.сохранитьИсходныеДанныеToolStripMenuItem.Click += new System.EventHandler(this.SaveDataToolStripMenuItem_Click);
            // 
            // сохранитьРезультатToolStripMenuItem
            // 
            this.сохранитьРезультатToolStripMenuItem.Name = "сохранитьРезультатToolStripMenuItem";
            this.сохранитьРезультатToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.сохранитьРезультатToolStripMenuItem.Text = "Сохранить результат ";
            this.сохранитьРезультатToolStripMenuItem.Click += new System.EventHandler(this.SaveResultToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.InformationToolStripMenuItem_Click);
            // 
            // IncorrectDataWarningLabel
            // 
            this.IncorrectDataWarningLabel.AutoSize = true;
            this.IncorrectDataWarningLabel.Location = new System.Drawing.Point(219, 446);
            this.IncorrectDataWarningLabel.Name = "IncorrectDataWarningLabel";
            this.IncorrectDataWarningLabel.Size = new System.Drawing.Size(303, 34);
            this.IncorrectDataWarningLabel.TabIndex = 11;
            this.IncorrectDataWarningLabel.Text = "Недопустимые символы в исходных данных. \n Попробуйте ввести их заново.";
            this.IncorrectDataWarningLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChooseInputFile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SizeOfArrayUpDown);
            this.groupBox1.Controls.Add(this.FileInputRadioButton);
            this.groupBox1.Controls.Add(this.RandomInputRadioButton);
            this.groupBox1.Controls.Add(this.ManualInputRadioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ManualInputTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ManualInputButton);
            this.groupBox1.Controls.Add(this.DataTextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 284);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заполнение массива";
            // 
            // ChooseInputFile
            // 
            this.ChooseInputFile.Location = new System.Drawing.Point(542, 120);
            this.ChooseInputFile.Name = "ChooseInputFile";
            this.ChooseInputFile.Size = new System.Drawing.Size(134, 36);
            this.ChooseInputFile.TabIndex = 15;
            this.ChooseInputFile.Text = "Выбрать файл";
            this.ChooseInputFile.UseVisualStyleBackColor = true;
            this.ChooseInputFile.Click += new System.EventHandler(this.ChooseInputFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Размер массива";
            // 
            // SizeOfArrayUpDown
            // 
            this.SizeOfArrayUpDown.Location = new System.Drawing.Point(315, 134);
            this.SizeOfArrayUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SizeOfArrayUpDown.Name = "SizeOfArrayUpDown";
            this.SizeOfArrayUpDown.Size = new System.Drawing.Size(120, 22);
            this.SizeOfArrayUpDown.TabIndex = 13;
            this.SizeOfArrayUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FileInputRadioButton
            // 
            this.FileInputRadioButton.AutoSize = true;
            this.FileInputRadioButton.Location = new System.Drawing.Point(525, 51);
            this.FileInputRadioButton.Name = "FileInputRadioButton";
            this.FileInputRadioButton.Size = new System.Drawing.Size(176, 21);
            this.FileInputRadioButton.TabIndex = 12;
            this.FileInputRadioButton.TabStop = true;
            this.FileInputRadioButton.Text = "Считывание из файла";
            this.FileInputRadioButton.UseVisualStyleBackColor = true;
            this.FileInputRadioButton.CheckedChanged += new System.EventHandler(this.FileInputRadioButton_CheckedChanged);
            // 
            // RandomInputRadioButton
            // 
            this.RandomInputRadioButton.AutoSize = true;
            this.RandomInputRadioButton.Location = new System.Drawing.Point(285, 51);
            this.RandomInputRadioButton.Name = "RandomInputRadioButton";
            this.RandomInputRadioButton.Size = new System.Drawing.Size(184, 21);
            this.RandomInputRadioButton.TabIndex = 11;
            this.RandomInputRadioButton.TabStop = true;
            this.RandomInputRadioButton.Text = "Случайное заполнение";
            this.RandomInputRadioButton.UseVisualStyleBackColor = true;
            this.RandomInputRadioButton.CheckedChanged += new System.EventHandler(this.RandomInputRadioButton_CheckedChanged);
            // 
            // ManualInputRadioButton
            // 
            this.ManualInputRadioButton.AutoSize = true;
            this.ManualInputRadioButton.Location = new System.Drawing.Point(53, 51);
            this.ManualInputRadioButton.Name = "ManualInputRadioButton";
            this.ManualInputRadioButton.Size = new System.Drawing.Size(160, 21);
            this.ManualInputRadioButton.TabIndex = 10;
            this.ManualInputRadioButton.TabStop = true;
            this.ManualInputRadioButton.Text = "Ручное заполнение";
            this.ManualInputRadioButton.UseVisualStyleBackColor = true;
            this.ManualInputRadioButton.CheckedChanged += new System.EventHandler(this.ManualInputRadioButton_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IncorrectDataWarningLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SortedDataTextBox);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Сортировка ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeOfArrayUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ManualInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ManualInputButton;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.TextBox SortedDataTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label IncorrectDataWarningLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FileInputRadioButton;
        private System.Windows.Forms.RadioButton RandomInputRadioButton;
        private System.Windows.Forms.RadioButton ManualInputRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown SizeOfArrayUpDown;
        private System.Windows.Forms.Button ChooseInputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИсходныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРезультатToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

