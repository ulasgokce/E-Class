namespace EClass
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.testChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).BeginInit();
            this.SuspendLayout();
            // 
            // testChart
            // 
            chartArea2.Name = "ChartArea1";
            this.testChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.testChart.Legends.Add(legend2);
            this.testChart.Location = new System.Drawing.Point(12, 12);
            this.testChart.Name = "testChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "FalseCount";
            this.testChart.Series.Add(series2);
            this.testChart.Size = new System.Drawing.Size(443, 353);
            this.testChart.TabIndex = 0;
            this.testChart.Text = "Yanlış Yaptığın Yerler";
            title2.Name = "Title1";
            title2.Text = "Yanlış Yaptığın Yerler";
            this.testChart.Titles.Add(title2);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 440);
            this.Controls.Add(this.testChart);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Statistics_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart testChart;
    }
}