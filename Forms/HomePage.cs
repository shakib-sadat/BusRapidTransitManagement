using BusRapidTransitManagement.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusRapidTransitManagement.Forms
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.GetTotalTicketSales() - managerDataAccess.GetTotalSalary() > 0)
            {
                Profitlabel.Text = "Profit = " + Convert.ToString(managerDataAccess.GetTotalTicketSales() - managerDataAccess.GetTotalSalary());
            }
            else
                Profitlabel.Text = "Loss = " + Convert.ToString(managerDataAccess.GetTotalTicketSales() - managerDataAccess.GetTotalSalary());

            TicketSelllabel.Text = "Total Ticket Sell = " + Convert.ToString(managerDataAccess.GetTotalTicketSales());
            TotalSalarylabel.Text = "Total Stuff Salary = " + Convert.ToString(managerDataAccess.GetTotalSalary());

            TicketSellCountlabel.Text = "Total Tickets Sale Profit Today: "+Convert.ToString(managerDataAccess.CalculateTicketSaleByDate(DateTime.Today.ToString("M/dd/yyyy")));
        }

        private void Profitlabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalSalarylabel_Click(object sender, EventArgs e)
        {

        }
    }
}
