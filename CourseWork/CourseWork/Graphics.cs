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
    public partial class Graphics : Form
    {
        public Graphics()
        {
            InitializeComponent();
        }

        private void Graphics_Load(object sender, EventArgs e)
        {
            ShowOutcomesOnGraphic(outcomesTHandTSchart);
            ShowTotalOutcomesOnGraphic(totalOutcomesChart);
        }

        private void ShowOutcomesOnGraphic(Chart chart)
        {
            for (int i = 0; i < ResultsForm.totalOutcome.Length; i++)
            {
                if (ResultsForm.totalOutcome[i] != 0)
                {
                    chart.Series[0].Points.AddXY(ResultsForm.orderSizes[i], ResultsForm.TH[i]);
                    chart.Series[1].Points.AddXY(ResultsForm.orderSizes[i], ResultsForm.TS[i]);
                    chart.Series[2].Points.AddXY(ResultsForm.orderSizes[i], ResultsForm.sumTHandTS[i]);
                }
            }
        }

        private void ShowTotalOutcomesOnGraphic(Chart chart)
        {
            for (int i = 0; i < ResultsForm.totalOutcome.Length; i++)
            {
                chart.Series[0].Points.AddXY(ResultsForm.orderSizes[i], ResultsForm.totalOutcome[i]);
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResultsForm rf = new ResultsForm();
            rf.Show();
        }

    }
}
