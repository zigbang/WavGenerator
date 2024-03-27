namespace WavGenerator
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            numericUpDownSampleRate = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            numericUpDownToneFrequency = new NumericUpDown();
            label3 = new Label();
            numericUpDownAmp = new NumericUpDown();
            label4 = new Label();
            numericUpDownTime = new NumericUpDown();
            textBoxFilePath = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSampleRate).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownToneFrequency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(99, 63);
            button1.Name = "button1";
            button1.Size = new Size(191, 101);
            button1.TabIndex = 0;
            button1.Text = "Make && Save Tone";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDownSampleRate
            // 
            numericUpDownSampleRate.Location = new Point(203, 3);
            numericUpDownSampleRate.Maximum = new decimal(new int[] { 96000, 0, 0, 0 });
            numericUpDownSampleRate.Minimum = new decimal(new int[] { 4000, 0, 0, 0 });
            numericUpDownSampleRate.Name = "numericUpDownSampleRate";
            numericUpDownSampleRate.Size = new Size(194, 39);
            numericUpDownSampleRate.TabIndex = 1;
            numericUpDownSampleRate.TextAlign = HorizontalAlignment.Center;
            numericUpDownSampleRate.Value = new decimal(new int[] { 4000, 0, 0, 0 });
            numericUpDownSampleRate.ValueChanged += numericUpDownSampleRate_ValueChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(numericUpDownSampleRate, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(numericUpDownToneFrequency, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(numericUpDownAmp, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(numericUpDownTime, 1, 3);
            tableLayoutPanel1.Location = new Point(388, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(400, 194);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 48);
            label1.TabIndex = 2;
            label1.Text = "Sample Rate";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(194, 48);
            label2.TabIndex = 2;
            label2.Text = "Sine Freq.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDownToneFrequency
            // 
            numericUpDownToneFrequency.Location = new Point(203, 51);
            numericUpDownToneFrequency.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numericUpDownToneFrequency.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownToneFrequency.Name = "numericUpDownToneFrequency";
            numericUpDownToneFrequency.Size = new Size(194, 39);
            numericUpDownToneFrequency.TabIndex = 1;
            numericUpDownToneFrequency.TextAlign = HorizontalAlignment.Center;
            numericUpDownToneFrequency.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownToneFrequency.ValueChanged += numericUpDownToneFrequency_ValueChanged;
            // 
            // label3
            // 
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(194, 48);
            label3.TabIndex = 2;
            label3.Text = "Amp. (Volume)";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDownAmp
            // 
            numericUpDownAmp.Location = new Point(203, 99);
            numericUpDownAmp.Name = "numericUpDownAmp";
            numericUpDownAmp.Size = new Size(194, 39);
            numericUpDownAmp.TabIndex = 1;
            numericUpDownAmp.TextAlign = HorizontalAlignment.Center;
            numericUpDownAmp.Value = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDownAmp.ValueChanged += numericUpDownAmp_ValueChanged;
            // 
            // label4
            // 
            label4.Location = new Point(3, 144);
            label4.Name = "label4";
            label4.Size = new Size(194, 50);
            label4.TabIndex = 2;
            label4.Text = "Time (sec.)";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDownTime
            // 
            numericUpDownTime.Location = new Point(203, 147);
            numericUpDownTime.Name = "numericUpDownTime";
            numericUpDownTime.Size = new Size(194, 39);
            numericUpDownTime.TabIndex = 1;
            numericUpDownTime.TextAlign = HorizontalAlignment.Center;
            numericUpDownTime.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownTime.ValueChanged += numericUpDownTime_ValueChanged;
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(12, 221);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(776, 39);
            textBoxFilePath.TabIndex = 3;
            textBoxFilePath.TextChanged += textBox1_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 283);
            Controls.Add(textBoxFilePath);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMain";
            Text = "Wav Tone Generator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownSampleRate).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownToneFrequency).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NumericUpDown numericUpDownSampleRate;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownToneFrequency;
        private Label label3;
        private NumericUpDown numericUpDownAmp;
        private Label label4;
        private NumericUpDown numericUpDownTime;
        private TextBox textBoxFilePath;
    }
}
