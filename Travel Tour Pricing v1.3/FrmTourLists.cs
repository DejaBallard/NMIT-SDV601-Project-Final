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
        private ClsTour _Tour;
        private readonly string[] _Sort = { "Name: A-Z","Name:Z-A","Date: Earliest","Date: Latest", "Price: Lowest","Price: Highest"};
        private IComparer<ClsTour>[] _Comparer = {new ClsNameASCComparer(),new ClsNameDSCComparer(), new ClsDateASCComparer(),new ClsDateDSCComparer(), new ClsPriceASCComparer(),new ClsPriceDSCComparer()};


        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES-------------------------------
        //
        //
        //
        //
        //-------------------------------------LOADING METHODS----------------------------------------------------


        public FrmTourLists()
        {
            InitializeComponent();
            try { ClsCompany.Retrive(); }
            catch { }
            cbxSortBy.DataSource = _Sort;
            cbxSortBy.SelectedIndex = 0;
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
                ClsCompany.TourList.Add(Convert.ToString(_Tour.TravelID), _Tour);
                updateDisplay();
                ClsCompany.Save();
            }

        }

        //Edits Selected Tour
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ClsTour lcTour = (ClsTour)lstTours.SelectedItem;
            editTour(lcTour);
            ClsCompany.Save();
        }

        //Deletes Selected Tour
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteTour();
            ClsCompany.Save();
        }

        //Searches For Tour
        private void btnEnter_Click(object sender, EventArgs e)
        {
        }

        //Sort by index change
        private void cbxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
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
            List<ClsTour> lcTourList = ClsCompany.TourList.Values.ToList<ClsTour>();
            lcTourList.Sort(_Comparer[cbxSortBy.SelectedIndex]);
            lstTours.DataSource = lcTourList;
        }

        //Delete Selected Tour
        private void deleteTour()
        {
            ClsTour lcTour = (ClsTour)lstTours.SelectedItem;
            DialogResult lcDialogDeleteStudent = MessageBox.Show("Are you sure you want to delete this tour? \n\nID: " + lcTour.TravelID + "\nName: " + lcTour.Name,"Delete Tour",MessageBoxButtons.YesNo);
            if (lcDialogDeleteStudent == DialogResult.Yes)
            {
                ClsCompany.TourList.Remove(Convert.ToString(lcTour.TravelID));
                updateDisplay();
            }
        }


        //-------------------------------------END OF FORM METHODS-------------------------------------------------
    }
}
// Coded By Deja Ballard 2018