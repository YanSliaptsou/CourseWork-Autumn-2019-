namespace CourseWork
{
    partial class Graphics
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.outcomesTHandTSchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.totalOutcomesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outcomesTHandTSchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalOutcomesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // outcomesTHandTSchart
            // 
            chartArea1.AxisX.Title = "Размер заказа";
            chartArea1.AxisY.Title = "Издержки";
            chartArea1.Name = "ChartArea1";
            this.outcomesTHandTSchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.outcomesTHandTSchart.Legends.Add(legend1);
            this.outcomesTHandTSchart.Location = new System.Drawing.Point(21, 41);
            this.outcomesTHandTSchart.Name = "outcomesTHandTSchart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Годовые издержки хранения:";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Годовые издержки заказа";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Суммарные издержки";
            this.outcomesTHandTSchart.Series.Add(series1);
            this.outcomesTHandTSchart.Series.Add(series2);
            this.outcomesTHandTSchart.Series.Add(series3);
            this.outcomesTHandTSchart.Size = new System.Drawing.Size(652, 449);
            this.outcomesTHandTSchart.TabIndex = 0;
            this.outcomesTHandTSchart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "График зависимости на хранение и заказы от размера заказа";
            // 
            // totalOutcomesChart
            // 
            chartArea2.AxisX.Interval = 500D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea2.AxisX.Title = "Размер заказа";
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea2.AxisY.Title = "Полные издержки";
            chartArea2.Name = "ChartArea1";
            this.totalOutcomesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.totalOutcomesChart.Legends.Add(legend2);
            this.totalOutcomesChart.Location = new System.Drawing.Point(714, 41);
            this.totalOutcomesChart.Name = "totalOutcomesChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.Red;
            series4.Name = "Полные издержки";
            this.totalOutcomesChart.Series.Add(series4);
            this.totalOutcomesChart.Size = new System.Drawing.Size(674, 449);
            this.totalOutcomesChart.TabIndex = 2;
            this.totalOutcomesChart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "График полных издержек";
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(12, 9);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(97, 26);
            this.goBackButton.TabIndex = 15;
            this.goBackButton.Text = "<";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 583);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalOutcomesChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outcomesTHandTSchart);
            this.Name = "Graphics";
            this.Text = "Graphics";
            this.Load += new System.EventHandler(this.Graphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outcomesTHandTSchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalOutcomesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart outcomesTHandTSchart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart totalOutcomesChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goBackButton;
    }
}