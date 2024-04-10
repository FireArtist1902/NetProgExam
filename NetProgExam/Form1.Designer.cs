namespace NetProgExam
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
            this.TempChart = new LiveCharts.WinForms.CartesianChart();
            this.LongitudeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LatitudeLabel = new System.Windows.Forms.Label();
            this.LatitudeTB = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.HumChart = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // TempChart
            // 
            this.TempChart.Location = new System.Drawing.Point(12, 154);
            this.TempChart.Name = "TempChart";
            this.TempChart.Size = new System.Drawing.Size(617, 177);
            this.TempChart.TabIndex = 0;
            this.TempChart.Text = "cartesianChart1";
            // 
            // LongitudeTB
            // 
            this.LongitudeTB.Location = new System.Drawing.Point(12, 18);
            this.LongitudeTB.Name = "LongitudeTB";
            this.LongitudeTB.Size = new System.Drawing.Size(167, 22);
            this.LongitudeTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Довгота";
            // 
            // LatitudeLabel
            // 
            this.LatitudeLabel.AutoSize = true;
            this.LatitudeLabel.Location = new System.Drawing.Point(284, 18);
            this.LatitudeLabel.Name = "LatitudeLabel";
            this.LatitudeLabel.Size = new System.Drawing.Size(57, 16);
            this.LatitudeLabel.TabIndex = 4;
            this.LatitudeLabel.Text = "Широта";
            // 
            // LatitudeTB
            // 
            this.LatitudeTB.Location = new System.Drawing.Point(347, 18);
            this.LatitudeTB.Name = "LatitudeTB";
            this.LatitudeTB.Size = new System.Drawing.Size(167, 22);
            this.LatitudeTB.TabIndex = 3;
            this.LatitudeTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(287, 125);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // HumChart
            // 
            this.HumChart.Location = new System.Drawing.Point(12, 353);
            this.HumChart.Name = "HumChart";
            this.HumChart.Size = new System.Drawing.Size(617, 177);
            this.HumChart.TabIndex = 6;
            this.HumChart.Text = "cartesianChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 575);
            this.Controls.Add(this.HumChart);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.LatitudeLabel);
            this.Controls.Add(this.LatitudeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LongitudeTB);
            this.Controls.Add(this.TempChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart TempChart;
        private System.Windows.Forms.TextBox LongitudeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LatitudeLabel;
        private System.Windows.Forms.TextBox LatitudeTB;
        private System.Windows.Forms.Button Submit;
        private LiveCharts.WinForms.CartesianChart HumChart;
    }
}

