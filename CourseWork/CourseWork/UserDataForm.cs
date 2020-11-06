using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class UserDataForm : Form
    {
        public const int DEFAULT_COLUMN_COUNT = 3;
        public const int DEFAULT_ROW_COUNT = 4;

        public static int categoriesNumber = 4;
        const double DEFAULT_TOTAL_CONSUMPTION = 35000;
        const double DEFAULT_ORDER_AND_DELIVERY_OUTCOME = 300;
        int[] DEFAULT_MIN_DISCOUNT_BORDER = { 1, 900, 3000, 8000 };
        int[] DEFAULT_MAX_DISCOUNT_BORDER = { 899, 2999, 7999, 1000000 };
        double[] DEFAULT_PRICE_PER_M2 = { 10.2, 9.7, 9.4, 9.2 };
        const double DEFAULT_PERCENTAGE = 0.15;

        public static double totalConsumption;
        public static double orderAndDeliveryOutcome;
        public static int[] minDiscountBorder;
        public static int[] maxDiscountBorder;
        public static double[] pricePerM2;
        public static double percentage;

        public UserDataForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = LoginForm.username;
            dataGridViewCategories.RowCount = DEFAULT_ROW_COUNT;
            dataGridViewCategories.ColumnCount = DEFAULT_COLUMN_COUNT;

            dataGridViewCategories.Columns[0].HeaderCell.Value = "V мин";
            dataGridViewCategories.Columns[1].HeaderCell.Value = "V макс";
            dataGridViewCategories.Columns[2].HeaderCell.Value = "Цена";

            for (int i = 1; i < dataGridViewCategories.RowCount + 1; i++)
            {
                dataGridViewCategories.Rows[i - 1].HeaderCell.Value = Convert.ToString(i);
            }

            numericUpDownPercentage.Value = 15;
            textBox1.Text = "35000";
            textBox2.Text = "500";
            FillStringGridWithIntData(dataGridViewCategories, DEFAULT_MIN_DISCOUNT_BORDER, 0);
            FillStringGridWithIntData(dataGridViewCategories, DEFAULT_MAX_DISCOUNT_BORDER, 1);
            FillStringGridWithDoubleData(dataGridViewCategories, DEFAULT_PRICE_PER_M2, 2);

            totalConsumption = DEFAULT_TOTAL_CONSUMPTION;
            orderAndDeliveryOutcome = DEFAULT_ORDER_AND_DELIVERY_OUTCOME;
            percentage = DEFAULT_PERCENTAGE;
            minDiscountBorder = DEFAULT_MIN_DISCOUNT_BORDER;
            maxDiscountBorder = DEFAULT_MAX_DISCOUNT_BORDER;
            pricePerM2 = DEFAULT_PRICE_PER_M2;

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!LoginForm.isGuest)
            {
                categoriesNumber = (int)numericUpDownCategoriesNumber.Value;
                dataGridViewCategories.RowCount = categoriesNumber;
                dataGridViewCategories.ColumnCount = DEFAULT_COLUMN_COUNT;

                for (int i = 1; i < dataGridViewCategories.RowCount + 1; i++)
                {
                    dataGridViewCategories.Rows[i - 1].HeaderCell.Value = Convert.ToString(i);
                }
            }
            else
            {
                MessageBox.Show("Это функциональность не доступна гостям!", "Внимание!");
            }
            
        }

        private void calculationButton_Click(object sender, EventArgs e)
        {
            try
            {
                minDiscountBorder = ReadIntInfoFromStringGrid(dataGridViewCategories, 0);
                maxDiscountBorder = ReadIntInfoFromStringGrid(dataGridViewCategories, 1);
                pricePerM2 = ReadDoubleInfoFromStringGrid(dataGridViewCategories, 2);
                percentage = Convert.ToDouble(numericUpDownPercentage.Value / 100);
                totalConsumption = Convert.ToInt32(textBox1.Text);
                orderAndDeliveryOutcome = Convert.ToInt32(textBox2.Text);

                ResultsForm res = new ResultsForm();
                res.ShowDialog();

            }
            catch(Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception),"Внимание!");
            }
        }

        private void FillStringGridWithIntData(DataGridView dataGridView,int []array,int column)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Cells[column].Value = array[i];
            }
        }

        private void FillStringGridWithDoubleData(DataGridView dataGridView, double[] array, int column)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Cells[column].Value = array[i];
            }
        }

        private int[] ReadIntInfoFromStringGrid(DataGridView dataGridView,int column)
        {
            int[] info = new int[dataGridView.RowCount];
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                info[i] = Convert.ToInt32(dataGridView.Rows[i].Cells[column].Value);
            }
            return info;
        }

        private double[] ReadDoubleInfoFromStringGrid(DataGridView dataGridView, int column)
        {
            double[] info = new double[dataGridView.RowCount];
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                info[i] = Convert.ToDouble(dataGridView.Rows[i].Cells[column].Value);
            }
            return info;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (!LoginForm.isGuest)
            {
                dataGridViewCategories.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Это функциональность не доступна гостям!", "Внимание!");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            RegisterForm lf = new RegisterForm();
            lf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
