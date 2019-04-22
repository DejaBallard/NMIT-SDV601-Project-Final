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
        //-------------------------------------DECLARING OBJECTS AND VARIABLES------------------------------------

        private DateTime _TodaysDate = DateTime.Now;
        private FrmTour _TourForm = new FrmTour();
        private ClsTour _Tour;


        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES-------------------------------
        //
        //
        //
        //
        //-------------------------------------LOADING METHODS----------------------------------------------------


        public FrmTourLists()
        {
            InitializeComponent();
            updateDisplay();
        }


        //-------------------------------------END OF LOADING METHODS----------------------------------------------
        //
        //
        //
        //
        //-------------------------------------BUTTON METHODS----------------------------------------------------

        //Adds New Tour
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Tour = new ClsTour();
            if (_Tour != null && _Tour.VeiwEdit())
            {
                ClsCompany.TourList.Add(_Tour.TravelID, _Tour);
                updateDisplay();
            }

        }

        //Edits Selected Tour
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ClsTour lcTour = (ClsTour)lstTours.SelectedItem;
            editTour(lcTour);
        }

        //Deletes Selected Tour
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteTour();
        }

        //Searches For Tour
        private void btnEnter_Click(object sender, EventArgs e)
        {
        }


        //--------------------------------------END OF BUTTON METHODS---------------------------------------------
        //
        //
        //
        //
        //-------------------------------------FORM METHODS------------------------------------------------------


        //Opens Form Tour
        private void editTour(ClsTour prTour)
        {

            if (prTour != null && prTour.VeiwEdit())
            {                
                updateDisplay();
            }
        }

        //Updates List With Tours
        private void updateDisplay()
        {
            lblDate.Text = ("Todays Date: " + _TodaysDate.Date.ToShortDateString());
            lstTours.DataSource = null;
            lstTours.DataSource = ClsCompany.TourList.Values.ToList<ClsTour>();
        }

        //Delete Selected Tour
        private void deleteTour()
        {
            ClsTour lcTour = (ClsTour)lstTours.SelectedItem;
            DialogResult lcDialogDeleteStudent = MessageBox.Show("Are you sure you want to delete this tour? \n\nID: " + lcTour.TravelID + "\nName: " + lcTour.Name,"Delete Tour",MessageBoxButtons.YesNo);
            if (lcDialogDeleteStudent == DialogResult.Yes)
            {
                ClsCompany.TourList.Remove(lcTour.TravelID);
                updateDisplay();
            }
        }

        //-------------------------------------END OF FORM METHODS-------------------------------------------------
    }
}
// Coded By Deja Ballard 2018