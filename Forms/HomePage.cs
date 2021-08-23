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
            BusInfo_Manager_ busInfo_Manager_ = new BusInfo_Manager_();
            
            

            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.GetTotalTicketSales() - managerDataAccess.GetTotalSalary() > 0)
            {
                Profitlabel.Text = "" + Convert.ToString(managerDataAccess.GetTotalTicketSales() - managerDataAccess.GetTotalSalary());
            }
            else
                Profitlabel.Text = "" + Convert.ToString(managerDataAccess.GetTotalTicketSales() - managerDataAccess.GetTotalSalary());

            TicketSelllabel.Text = "" + Convert.ToString(managerDataAccess.GetTotalTicketSales());
            TotalSalarylabel.Text = "" + Convert.ToString(managerDataAccess.GetTotalSalary());

            TicketSellCountlabel.Text = ""+Convert.ToString(managerDataAccess.CalculateTicketSaleByDate(DateTime.Today.ToString("M/dd/yyyy")));
            
            
        }

        private void Profitlabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalSalarylabel_Click(object sender, EventArgs e)
        {

        }

        private void Buslabel_Click(object sender, EventArgs e)
        {

        }
    }
}
