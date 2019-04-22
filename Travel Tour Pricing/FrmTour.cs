using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Tour_Pricing
{
    public partial class FrmTour : Form
    {
        //Declaring
        private ClsTour _Tour;
        

        public FrmTour()
        {
            InitializeComponent();
        }

        private void FrmTour_Load(object sender, EventArgs e)
        {

        }

        public DialogResult ShowDialog(ClsTour prTour)
        {
            _Tour = prTour;
            updateDisplay();
            return ShowDialog();
        }
        private void updateDisplay()
        {
            txtID.Text = _Tour.TravelID;
            txtName.Text = _Tour.Name;
            dtpStartDate.Value = _Tour.StartDate;
            dtpEndDate.Value = _Tour.EndDate;
            //type
            nudDistance.Value = _Tour.Distance;
            nudMaxPeople.Value = _Tour.MaxPeople;
            nudMarkUp.Value = _Tour.MarkUp;

        }

    }
}
