namespace CheckComputer
{
    partial class ComputerDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ch_cpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ch_Ram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_hdd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ch_cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_hdd)).BeginInit();
            this.SuspendLayout();
            // 
            // ch_cpu
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_cpu.ChartAreas.Add(chartArea1);
            this.ch_cpu.Location = new System.Drawing.Point(39, 39);
            this.ch_cpu.Name = "ch_cpu";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Punkty";
            this.ch_cpu.Series.Add(series1);
            this.ch_cpu.Size = new System.Drawing.Size(300, 168);
            this.ch_cpu.TabIndex = 0;
            this.ch_cpu.Text = "ch_cpu";
            // 
            // ch_Ram
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_Ram.ChartAreas.Add(chartArea2);
            this.ch_Ram.Location = new System.Drawing.Point(433, 39);
            this.ch_Ram.Name = "ch_Ram";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Punkty";
            this.ch_Ram.Series.Add(series2);
            this.ch_Ram.Size = new System.Drawing.Size(300, 168);
            this.ch_Ram.TabIndex = 1;
            this.ch_Ram.Text = "ch_Ram";
            this.ch_Ram.Click += new System.EventHandler(this.ch_Ram_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Procentowe użycie dysku";
            // 
            // cb_hdd
            // 
            chartArea3.Name = "ChartArea1";
            this.cb_hdd.ChartAreas.Add(chartArea3);
            this.cb_hdd.Location = new System.Drawing.Point(39, 247);
            this.cb_hdd.Name = "cb_hdd";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Punkty";
            this.cb_hdd.Series.Add(series3);
            this.cb_hdd.Size = new System.Drawing.Size(300, 168);
            this.cb_hdd.TabIndex = 6;
            this.cb_hdd.Text = "chart1";
            // 
            // ComputerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 433);
            this.Controls.Add(this.cb_hdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ch_Ram);
            this.Controls.Add(this.ch_cpu);
            this.Name = "ComputerDetails";
            this.Text = "ComputerDetails";
            ((System.ComponentModel.ISupportInitialize)(this.ch_cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_hdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch_cpu;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Ram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart cb_hdd;
    }
}