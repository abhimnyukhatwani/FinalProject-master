using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace income
{
    public partial class IncomeByCounty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TableDD.Visible = false;
            if (IsPostBack == true)
                TableDD.Visible = true;
        }

        protected void incomeSearch_Click(object sender, EventArgs e)
        {
            income icn = new income();
            getChartData(icn.getIncome(int.Parse(yearDD.Text), Counties.Text));
            incomeLS.DataSource = icn.getIncome(int.Parse(yearDD.Text), Counties.Text);
            incomeLS.DataBind();
            getChartType();

        }

     
        private void getChartType() {
            foreach (int chartType in Enum.GetValues(typeof(SeriesChartType))){
                ListItem ls = new ListItem(Enum.GetName(typeof(SeriesChartType), chartType), chartType.ToString());
                ChartListDD.Items.Add(ls);
            }
        }

        private void getChartData(Dictionary<String, int> inc) {
            Series series = incomeChart.Series["Series1"];
            foreach (KeyValuePair<String, int> kvp in inc) {
                series.Points.AddXY(kvp.Key.ToString(), kvp.Value.ToString());
            }
            
        }

        protected void ChartListDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            incomeChart.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), ChartListDD.SelectedValue);
            income icn = new income();
            getChartData(icn.getIncome(int.Parse(yearDD.Text), Counties.Text));

        }
    }
}