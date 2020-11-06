namespace CourseWork
{
    partial class ResultsForm
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
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBetterRes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.graphicsButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBetterRes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(31, 64);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowTemplate.Height = 24;
            this.dataGridViewResults.Size = new System.Drawing.Size(1298, 256);
            this.dataGridViewResults.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Расчётные результаты";
            // 
            // dataGridViewBetterRes
            // 
            this.dataGridViewBetterRes.AllowUserToAddRows = false;
            this.dataGridViewBetterRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBetterRes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBetterRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBetterRes.Location = new System.Drawing.Point(31, 480);
            this.dataGridViewBetterRes.Name = "dataGridViewBetterRes";
            this.dataGridViewBetterRes.RowTemplate.Height = 24;
            this.dataGridViewBetterRes.Size = new System.Drawing.Size(1298, 256);
            this.dataGridViewBetterRes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(323, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Улучшенные результаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(28, 768);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вывод/принятие решений:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Получить улучшенные результаты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // graphicsButton
            // 
            this.graphicsButton.Enabled = false;
            this.graphicsButton.Location = new System.Drawing.Point(560, 353);
            this.graphicsButton.Name = "graphicsButton";
            this.graphicsButton.Size = new System.Drawing.Size(156, 44);
            this.graphicsButton.TabIndex = 8;
            this.graphicsButton.Text = "Посмотреть графики";
            this.graphicsButton.UseVisualStyleBackColor = true;
            this.graphicsButton.Click += new System.EventHandler(this.graphicsButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(32, 9);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(102, 39);
            this.goBackButton.TabIndex = 15;
            this.goBackButton.Text = "<";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 848);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.graphicsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewBetterRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewResults);
            this.Name = "ResultsForm";
            this.Text = "Результаты";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBetterRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBetterRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button graphicsButton;
        private System.Windows.Forms.Button goBackButton;
    }
}