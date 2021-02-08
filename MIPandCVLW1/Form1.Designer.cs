namespace MIPandCVLW1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.blackWhitePictureBox = new System.Windows.Forms.PictureBox();
            this.inversionPictureBox = new System.Windows.Forms.PictureBox();
            this.binarizationPictureBox = new System.Windows.Forms.PictureBox();
            this.extrpolPictureBox = new System.Windows.Forms.PictureBox();
            this.examplePictureBox = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.normalPictureBox = new System.Windows.Forms.PictureBox();
            this.iterpPictureBox = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.linerHistogrammButton = new System.Windows.Forms.Button();
            this.kumHistogrammButton = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.blackWhitePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inversionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binarizationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extrpolPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // blackWhitePictureBox
            // 
            this.blackWhitePictureBox.Location = new System.Drawing.Point(268, 52);
            this.blackWhitePictureBox.Name = "blackWhitePictureBox";
            this.blackWhitePictureBox.Size = new System.Drawing.Size(250, 250);
            this.blackWhitePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blackWhitePictureBox.TabIndex = 0;
            this.blackWhitePictureBox.TabStop = false;
            // 
            // inversionPictureBox
            // 
            this.inversionPictureBox.Location = new System.Drawing.Point(524, 52);
            this.inversionPictureBox.Name = "inversionPictureBox";
            this.inversionPictureBox.Size = new System.Drawing.Size(250, 250);
            this.inversionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inversionPictureBox.TabIndex = 1;
            this.inversionPictureBox.TabStop = false;
            // 
            // binarizationPictureBox
            // 
            this.binarizationPictureBox.Location = new System.Drawing.Point(12, 52);
            this.binarizationPictureBox.Name = "binarizationPictureBox";
            this.binarizationPictureBox.Size = new System.Drawing.Size(250, 250);
            this.binarizationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.binarizationPictureBox.TabIndex = 2;
            this.binarizationPictureBox.TabStop = false;
            // 
            // extrpolPictureBox
            // 
            this.extrpolPictureBox.Location = new System.Drawing.Point(12, 308);
            this.extrpolPictureBox.Name = "extrpolPictureBox";
            this.extrpolPictureBox.Size = new System.Drawing.Size(250, 250);
            this.extrpolPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.extrpolPictureBox.TabIndex = 3;
            this.extrpolPictureBox.TabStop = false;
            this.extrpolPictureBox.Click += new System.EventHandler(this.ExtrpolPictureBox_Click);
            // 
            // examplePictureBox
            // 
            this.examplePictureBox.Location = new System.Drawing.Point(780, 52);
            this.examplePictureBox.Name = "examplePictureBox";
            this.examplePictureBox.Size = new System.Drawing.Size(250, 250);
            this.examplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.examplePictureBox.TabIndex = 4;
            this.examplePictureBox.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialogImage";
            this.openFile.Filter = "Image|*.jpg";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(14, 10);
            this.pathTextBox.Multiline = true;
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(504, 35);
            this.pathTextBox.TabIndex = 5;
            // 
            // selectBtn
            // 
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.Location = new System.Drawing.Point(780, 10);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(250, 33);
            this.selectBtn.TabIndex = 6;
            this.selectBtn.Text = "Выбрать изображение";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // normalPictureBox
            // 
            this.normalPictureBox.Location = new System.Drawing.Point(524, 308);
            this.normalPictureBox.Name = "normalPictureBox";
            this.normalPictureBox.Size = new System.Drawing.Size(250, 250);
            this.normalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.normalPictureBox.TabIndex = 9;
            this.normalPictureBox.TabStop = false;
            // 
            // iterpPictureBox
            // 
            this.iterpPictureBox.Location = new System.Drawing.Point(268, 308);
            this.iterpPictureBox.Name = "iterpPictureBox";
            this.iterpPictureBox.Size = new System.Drawing.Size(250, 250);
            this.iterpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iterpPictureBox.TabIndex = 10;
            this.iterpPictureBox.TabStop = false;
            this.iterpPictureBox.Click += new System.EventHandler(this.IterpPictureBox_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(14, 564);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(760, 250);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // linerHistogrammButton
            // 
            this.linerHistogrammButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linerHistogrammButton.Location = new System.Drawing.Point(780, 564);
            this.linerHistogrammButton.Name = "linerHistogrammButton";
            this.linerHistogrammButton.Size = new System.Drawing.Size(250, 33);
            this.linerHistogrammButton.TabIndex = 12;
            this.linerHistogrammButton.Text = "Линейнная гистограмма";
            this.linerHistogrammButton.UseVisualStyleBackColor = true;
            this.linerHistogrammButton.Click += new System.EventHandler(this.LinerHistogrammButton_Click);
            // 
            // kumHistogrammButton
            // 
            this.kumHistogrammButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kumHistogrammButton.Location = new System.Drawing.Point(780, 603);
            this.kumHistogrammButton.Name = "kumHistogrammButton";
            this.kumHistogrammButton.Size = new System.Drawing.Size(250, 33);
            this.kumHistogrammButton.TabIndex = 13;
            this.kumHistogrammButton.Text = "Кумулятивная гистограмма";
            this.kumHistogrammButton.UseVisualStyleBackColor = true;
            this.kumHistogrammButton.Click += new System.EventHandler(this.KumHistogrammButton_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "исходное изображение",
            "отенки серого",
            "бинариализация",
            "инверсия",
            "экстраполяция нулевого порядка",
            "интерполяция первого порядка"});
            this.checkedListBox.Location = new System.Drawing.Point(780, 308);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(248, 251);
            this.checkedListBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(780, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 22;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(524, 10);
            this.valueTextBox.Multiline = true;
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(250, 33);
            this.valueTextBox.TabIndex = 23;
            this.valueTextBox.Text = "127";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1037, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 798);
            this.textBox1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 820);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.kumHistogrammButton);
            this.Controls.Add(this.linerHistogrammButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.iterpPictureBox);
            this.Controls.Add(this.normalPictureBox);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.examplePictureBox);
            this.Controls.Add(this.extrpolPictureBox);
            this.Controls.Add(this.binarizationPictureBox);
            this.Controls.Add(this.inversionPictureBox);
            this.Controls.Add(this.blackWhitePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "л/р 1";
            ((System.ComponentModel.ISupportInitialize)(this.blackWhitePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inversionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binarizationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extrpolPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox blackWhitePictureBox;
        private System.Windows.Forms.PictureBox inversionPictureBox;
        private System.Windows.Forms.PictureBox binarizationPictureBox;
        private System.Windows.Forms.PictureBox extrpolPictureBox;
        private System.Windows.Forms.PictureBox examplePictureBox;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.PictureBox normalPictureBox;
        private System.Windows.Forms.PictureBox iterpPictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button linerHistogrammButton;
        private System.Windows.Forms.Button kumHistogrammButton;
        private System.Windows.Forms.ListBox checkedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

