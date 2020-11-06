using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace CourseWork
{
    public partial class ResultsForm : Form
    {
        public static double[] EOQ;
        public static int[] realQ;
        public static double[] amountOfOrders;
        public static double[] intNumberOfOrders;
        public static double[] orderSizes;
        public static double[] TH;
        public static double[] TS;
        public static double[] sumTHandTS;
        public static double[] totalOutcome;
        public static int index;
        BuilderCompany builderCompany;
        public ResultsForm()
        {
            InitializeComponent();
            builderCompany = new BuilderCompany(UserDataForm.totalConsumption, UserDataForm.orderAndDeliveryOutcome, UserDataForm.minDiscountBorder, UserDataForm.maxDiscountBorder, UserDataForm.pricePerM2, UserDataForm.percentage);

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            dataGridViewResults.RowCount = UserDataForm.categoriesNumber;
            dataGridViewResults.ColumnCount = 10;

            dataGridViewBetterRes.RowCount = UserDataForm.categoriesNumber;
            dataGridViewBetterRes.ColumnCount = 10;

            dataGridViewResults.Columns[0].HeaderCell.Value = "V мин";
            dataGridViewResults.Columns[1].HeaderCell.Value = "V макс";
            dataGridViewResults.Columns[2].HeaderCell.Value = "Цена";
            dataGridViewResults.Columns[3].HeaderCell.Value = "EOQ";
            dataGridViewResults.Columns[4].HeaderCell.Value = "Реальный Q";
            dataGridViewResults.Columns[5].HeaderCell.Value = "Число заказов";
            dataGridViewResults.Columns[6].HeaderCell.Value = "TH";
            dataGridViewResults.Columns[7].HeaderCell.Value = "TS";
            dataGridViewResults.Columns[8].HeaderCell.Value = "TH + TS";
            dataGridViewResults.Columns[9].HeaderCell.Value = "Суммарн. изд.";


            for (int i = 1; i < dataGridViewResults.RowCount + 1;i++)
            {
                dataGridViewResults.Rows[i-1].HeaderCell.Value = Convert.ToString(i);
            }


            EOQ = builderCompany.CountEOQ();
            realQ = builderCompany.CountRealQ(EOQ);
            amountOfOrders = builderCompany.CountamountOfOrders(realQ);
            TH = builderCompany.CountTH(realQ, amountOfOrders);
            TS = builderCompany.CountTS(realQ, amountOfOrders);
            totalOutcome = builderCompany.CountTotalOutcome(TH, TS);
            sumTHandTS = builderCompany.SumTHAndTS(TH, TS);

            FillStringGridWithIntData(dataGridViewResults, builderCompany.GetMinDiscountBorder(), 0);
            FillStringGridWithIntData(dataGridViewResults, builderCompany.GetMaxDiscountBorder(), 1);
            FillStringGridWithDoubleData(dataGridViewResults,builderCompany.GetPricesPerM2() , 2);
            FillStringGridWithDoubleData(dataGridViewResults, EOQ, 3);
            FillStringGridWithIntData(dataGridViewResults, realQ, 4);
            FillStringGridWithDoubleData(dataGridViewResults, amountOfOrders, 5);
            FillStringGridWithDoubleData(dataGridViewResults, TH, 6);
            FillStringGridWithDoubleData(dataGridViewResults, TS, 7);
            FillStringGridWithDoubleData(dataGridViewResults, sumTHandTS, 8);
            FillStringGridWithDoubleData(dataGridViewResults, totalOutcome, 9);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            graphicsButton.Enabled = true;
            dataGridViewBetterRes.Columns[0].HeaderCell.Value = "V мин";
            dataGridViewBetterRes.Columns[1].HeaderCell.Value = "V макс";
            dataGridViewBetterRes.Columns[2].HeaderCell.Value = "Цена";
            dataGridViewBetterRes.Columns[3].HeaderCell.Value = "EOQ";
            dataGridViewBetterRes.Columns[4].HeaderCell.Value = "Оптимальный размер заказа";
            dataGridViewBetterRes.Columns[5].HeaderCell.Value = "Число заказов";
            dataGridViewBetterRes.Columns[6].HeaderCell.Value = "TH";
            dataGridViewBetterRes.Columns[7].HeaderCell.Value = "TS";
            dataGridViewBetterRes.Columns[8].HeaderCell.Value = "TH + TS";
            dataGridViewBetterRes.Columns[9].HeaderCell.Value = "Суммарн. изд.";

            for (int i = 1; i < dataGridViewBetterRes.RowCount + 1; i++)
            {
                dataGridViewBetterRes.Rows[i - 1].HeaderCell.Value = Convert.ToString(i);
            }

            EOQ = builderCompany.CountEOQ();
            realQ = builderCompany.CountRealQ(EOQ);
            amountOfOrders = builderCompany.CountamountOfOrders(realQ);
            intNumberOfOrders = builderCompany.FindIntNumberOfOrders(realQ, amountOfOrders);
            orderSizes = builderCompany.FindOrserSize(intNumberOfOrders);
            TH = builderCompany.CountTH(realQ, intNumberOfOrders);
            TS = builderCompany.CountTS(realQ, intNumberOfOrders);
            totalOutcome = builderCompany.CountTotalOutcome(TH, TS);
            index = builderCompany.FindApprOrderAmountAndOrderSizeGroup(totalOutcome, orderSizes, intNumberOfOrders);

            FillStringGridWithIntData(dataGridViewBetterRes, builderCompany.GetMinDiscountBorder(), 0);
            FillStringGridWithIntData(dataGridViewBetterRes, builderCompany.GetMaxDiscountBorder(), 1);
            FillStringGridWithDoubleData(dataGridViewBetterRes, builderCompany.GetPricesPerM2(), 2);
            FillStringGridWithDoubleData(dataGridViewBetterRes, EOQ, 3);
            FillStringGridWithDoubleData(dataGridViewBetterRes, orderSizes, 4);
            FillStringGridWithDoubleData(dataGridViewBetterRes, intNumberOfOrders, 5);
            FillStringGridWithDoubleData(dataGridViewBetterRes, TH, 6);
            FillStringGridWithDoubleData(dataGridViewBetterRes, TS, 7);
            FillStringGridWithDoubleData(dataGridViewBetterRes, builderCompany.SumTHAndTS(TH, TS), 8);
            FillStringGridWithDoubleData(dataGridViewBetterRes, totalOutcome, 9);

            label3.Text += MakeDecision();


        }
        private void FillStringGridWithIntData(DataGridView dataGridView, int[] array, int column)
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

        private int[] ReadIntInfoFromStringGrid(DataGridView dataGridView, int column)
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

        private string MakeDecision()
        {
            return "Наилучшим вариантом в заданных условиях будет выбрать " + intNumberOfOrders[index] + 
            " заказа(ов) по " + orderSizes[index] + " м2" + " с суммарными издержками $ " + totalOutcome[index];
        }

        private void graphicsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!LoginForm.isGuest)
                {
                    Graphics graphics = new Graphics();
                    graphics.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Это функциональность не доступна гостям!", "Внимание!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Внимание!");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDataForm udf = new UserDataForm();
            udf.Show();
        }
    }
}
