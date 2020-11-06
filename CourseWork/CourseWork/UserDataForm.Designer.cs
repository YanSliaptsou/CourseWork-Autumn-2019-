namespace CourseWork
{
    partial class UserDataForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownPercentage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownCategoriesNumber = new System.Windows.Forms.NumericUpDown();
            this.confirmButton = new System.Windows.Forms.Button();
            this.calculationButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.gotoRegisterButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.gotoLoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCategoriesNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPercentage
            // 
            this.numericUpDownPercentage.Location = new System.Drawing.Point(152, 235);
            this.numericUpDownPercentage.Name = "numericUpDownPercentage";
            this.numericUpDownPercentage.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPercentage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(408, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Входные параметры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Доход по рублёвым вкладам, %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Средний расход металлочерепицы, м2/год ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(874, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(749, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Издержки по оформлению заказа и его доставке, $$";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(389, 266);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.Size = new System.Drawing.Size(364, 227);
            this.dataGridViewCategories.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Таблица стоимости кровли";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Количество категорий стоимости";
            // 
            // numericUpDownCategoriesNumber
            // 
            this.numericUpDownCategoriesNumber.Location = new System.Drawing.Point(385, 200);
            this.numericUpDownCategoriesNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCategoriesNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCategoriesNumber.Name = "numericUpDownCategoriesNumber";
            this.numericUpDownCategoriesNumber.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCategoriesNumber.TabIndex = 9;
            this.numericUpDownCategoriesNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(523, 194);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(119, 33);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Применить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // calculationButton
            // 
            this.calculationButton.Location = new System.Drawing.Point(450, 508);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(261, 45);
            this.calculationButton.TabIndex = 12;
            this.calculationButton.Text = "Рассчитать";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(648, 194);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 33);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // gotoRegisterButton
            // 
            this.gotoRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gotoRegisterButton.Location = new System.Drawing.Point(17, 54);
            this.gotoRegisterButton.Name = "gotoRegisterButton";
            this.gotoRegisterButton.Size = new System.Drawing.Size(131, 39);
            this.gotoRegisterButton.TabIndex = 14;
            this.gotoRegisterButton.Text = "Перейти на форму регистрации";
            this.gotoRegisterButton.UseVisualStyleBackColor = true;
            this.gotoRegisterButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(14, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 17);
            this.usernameLabel.TabIndex = 15;
            // 
            // gotoLoginButton
            // 
            this.gotoLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gotoLoginButton.Location = new System.Drawing.Point(183, 54);
            this.gotoLoginButton.Name = "gotoLoginButton";
            this.gotoLoginButton.Size = new System.Drawing.Size(131, 39);
            this.gotoLoginButton.TabIndex = 16;
            this.gotoLoginButton.Text = "Перейти на авторизации регистрации";
            this.gotoLoginButton.UseVisualStyleBackColor = true;
            this.gotoLoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 565);
            this.Controls.Add(this.gotoLoginButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.gotoRegisterButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculationButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownCategoriesNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewCategories);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownPercentage);
            this.Name = "UserDataForm";
            this.Text = "Строительная фирма";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCategoriesNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown numericUpDownPercentage;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridViewCategories;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown numericUpDownCategoriesNumber;
        public System.Windows.Forms.Button confirmButton;
        public System.Windows.Forms.Button calculationButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button gotoRegisterButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button gotoLoginButton;

    }
}

