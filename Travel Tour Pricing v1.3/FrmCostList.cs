using System;
using System.Windows.Forms;

namespace Travel_Tour_Pricing
{
    public partial class FrmCostList : Form
    {
        public FrmCostList()
        {
            InitializeComponent();
        }

        private void FrmCostList_Load(object sender, EventArgs e)
        {
            lstCostAvailble.Items.Add("Driver\t120\t Tim Smith");
            lstCostAvailble.Items.Add("Driver\t120\tJoe Mill");
            lstCostAvailble.Items.Add("Hiker\t150\tBrooke Hill");
            lstCostAvailble.Items.Add("Guide\t200\tJohn Tim");

            lstStaffAdded.Items.Add("Driver\t100\tFred Smith");
            lstStaffAdded.Items.Add("Guide\t14,000\tSue Anne");
        }
    }
}
