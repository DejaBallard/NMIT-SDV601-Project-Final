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
    public partial class FrmTourLists : Form
    {
        private FrmTour _TourForm = new FrmTour();
        private ClsTour _Tour;

        public FrmTourLists()
        {
            InitializeComponent();
        }

        //Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Tour = new ClsTour();
            editTour();
            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
          
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
        }

        //Methods
        private void editTour()
        {
            if (_Tour != null && _TourForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
