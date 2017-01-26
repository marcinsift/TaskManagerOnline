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
            this.Procesy = new System.Windows.Forms.TabControl();
            this.tab_Statystyki = new System.Windows.Forms.TabPage();
            this.cb_hdd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ch_Ram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ch_cpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dg_Process = new System.Windows.Forms.DataGridView();
            this.Procesy.SuspendLayout();
            this.tab_Statystyki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_hdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_cpu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Process)).BeginInit();
            this.SuspendLayout();
            // 
            // Procesy
            // 
            this.Procesy.Controls.Add(this.tab_Statystyki);
            this.Procesy.Controls.Add(this.tabPage2);
            this.Procesy.Location = new System.Drawing.Point(2, 3);
            this.Procesy.Name = "Procesy";
            this.Procesy.SelectedIndex = 0;
            this.Procesy.Size = new System.Drawing.Size(806, 458);
            this.Procesy.TabIndex = 0;
            // 
            // tab_Statystyki
            // 
            this.tab_Statystyki.Controls.Add(this.cb_hdd);
            this.tab_Statystyki.Controls.Add(this.label3);
            this.tab_Statystyki.Controls.Add(this.label2);
            this.tab_Statystyki.Controls.Add(this.label1);
            this.tab_Statystyki.Controls.Add(this.ch_Ram);
            this.tab_Statystyki.Controls.Add(this.ch_cpu);
            this.tab_Statystyki.Location = new System.Drawing.Point(4, 22);
            this.tab_Statystyki.Name = "tab_Statystyki";
            this.tab_Statystyki.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Statystyki.Size = new System.Drawing.Size(798, 432);
            this.tab_Statystyki.TabIndex = 0;
            this.tab_Statystyki.Text = "Wydajność";
            this.tab_Statystyki.UseVisualStyleBackColor = true;
            // 
            // cb_hdd
            // 
            chartArea1.Name = "ChartArea1";
            this.cb_hdd.ChartAreas.Add(chartArea1);
            this.cb_hdd.Location = new System.Drawing.Point(36, 237);
            this.cb_hdd.Name = "cb_hdd";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Punkty";
            this.cb_hdd.Series.Add(series1);
            this.cb_hdd.Size = new System.Drawing.Size(300, 168);
            this.cb_hdd.TabIndex = 12;
            this.cb_hdd.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Procentowe użycie dysku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "RAM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPU";
            // 
            // ch_Ram
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_Ram.ChartAreas.Add(chartArea2);
            this.ch_Ram.Location = new System.Drawing.Point(430, 29);
            this.ch_Ram.Name = "ch_Ram";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Punkty";
            this.ch_Ram.Series.Add(series2);
            this.ch_Ram.Size = new System.Drawing.Size(300, 168);
            this.ch_Ram.TabIndex = 8;
            this.ch_Ram.Text = "ch_Ram";
            // 
            // ch_cpu
            // 
            chartArea3.Name = "ChartArea1";
            this.ch_cpu.ChartAreas.Add(chartArea3);
            this.ch_cpu.Location = new System.Drawing.Point(36, 29);
            this.ch_cpu.Name = "ch_cpu";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Punkty";
            this.ch_cpu.Series.Add(series3);
            this.ch_cpu.Size = new System.Drawing.Size(300, 168);
            this.ch_cpu.TabIndex = 7;
            this.ch_cpu.Text = "ch_cpu";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dg_Process);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Procesy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dg_Process
            // 
            this.dg_Process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Process.Location = new System.Drawing.Point(3, 0);
            this.dg_Process.Name = "dg_Process";
            this.dg_Process.Size = new System.Drawing.Size(795, 432);
            this.dg_Process.TabIndex = 0;
            // 
            // ComputerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.Procesy);
            this.Name = "ComputerDetails";
            this.Text = "Menadżer online";
            this.Load += new System.EventHandler(this.ComputerDetails_Load);
            this.Procesy.ResumeLayout(false);
            this.tab_Statystyki.ResumeLayout(false);
            this.tab_Statystyki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_hdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_cpu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Process)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Procesy;
        private System.Windows.Forms.TabPage tab_Statystyki;
        private System.Windows.Forms.DataVisualization.Charting.Chart cb_hdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Ram;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_cpu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dg_Process;
    }
}