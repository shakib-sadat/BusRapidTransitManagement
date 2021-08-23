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
    public partial class Counters_stuff_ : UserControl
    {
        public Counters_stuff_()
        {
            InitializeComponent();
        }

        public void UpdateGridView()
        {
            StuffDataAccess stuffDataAccess = new StuffDataAccess();
            if (stuffDataAccess.GetDestinationsStuff() != null)
                CountersStuffdataGridView.DataSource = stuffDataAccess.GetDestinationsStuff();
        }
        private void Counters_stuff__Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }
    }
}
