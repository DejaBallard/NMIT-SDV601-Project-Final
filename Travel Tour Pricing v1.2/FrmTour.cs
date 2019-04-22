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
        //-------------------------------------DECLARING OBJECTS AND VARIABLES------------------------------------
        private int _DomesticDayPrice = 100;
        private int _InternationalDayPrice = 200;

        private int _TotalDays = 0;
        private decimal _CurrentPrice = 0;
        private decimal _MarkUpPrice = 0;
        private decimal _PricePerPerson = 0;
        private string[] _TypeList = { "Domestic", "International" };

        private ClsTour _Tour;
        private ClsCost _Cost;


        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES-----------------------------
        //
        //
        //
        //-------------------------------------LOADING METHODS----------------------------------------------------

        public FrmTour()
        {
            InitializeComponent();
            cboxType.DataSource = _TypeList;
            cboxCosts.DataSource = ClsCost.CostType;
            

        }
        public bool ShowDialog(ClsTour prTour)
        {
            _Tour = prTour;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }
        private void FrmTour_Load(object sender, EventArgs e)
        {
            gboxCosts.Hide();
            cboxType.SelectedIndex = 0;
            loadToolTips();
        }
        private void loadToolTips()
        {
            ToolTip.SetToolTip(lblTravelID, "Unique identifier for the tour");
            ToolTip.SetToolTip(lblName, "Name of tour");
            ToolTip.SetToolTip(lblStartDate, "Start date of tour");
            ToolTip.SetToolTip(lblEndDate, "End date of tour");
            ToolTip.SetToolTip(lblType, "Domestic price per day: " + _DomesticDayPrice+ "\n" +"International price per day: " +_InternationalDayPrice);
            ToolTip.SetToolTip(lblMaxPeople, "Max amount of customers");
            ToolTip.SetToolTip(lblMarkUp, "Percentage of price mark up");
        }

        //-------------------------------------END OF LOADING METHODS---------------------------------------------
        //
        //
        //
        //
        //-------------------------------------BUTTON METHODS----------------------------------------------------

        //Shows Costs Lists
        private void btnEnableCosts_Click(object sender, EventArgs e)
        {
            gboxCosts.Show();
        }

        //Calculate All Costs
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (isObjectsNull() == true)
            { MessageBox.Show("One item hasn't been filled"); }
            else
            if (txtID.Enabled && ClsCompany.TourList.ContainsKey(txtID.Text))
                MessageBox.Show("Tour with this Travel ID already exists.\n\n Travel ID: " + txtID.Text, "Duplicate Travel ID");
           else

            {
                int lcTotalDays = calculateNumberOfDays();
                _CurrentPrice = calculatePriceByType(lcTotalDays);
                _CurrentPrice = calculatePriceByPeople(_CurrentPrice);
                LoopUpdatingCosts(lcTotalDays);
                _MarkUpPrice = calculateMarkUp(_CurrentPrice);
                _PricePerPerson = (_MarkUpPrice / nudMaxPeople.Value);
                saveData();
                updateDisplay();
            }
        }

        private void LoopUpdatingCosts(int prTotalDays)
        {
            try
            {
                foreach (ClsCost _Cost in _Tour.CostList)
                _CurrentPrice += _Cost.UpdateCostFromTour(prTotalDays, nudDistance.Value);
            }
            catch { }
        }

        //Closes Tour Form
        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (isObjectsNull() == true)
            {
                MessageBox.Show("One item hasn't been filled");
            }
            else
            {
                if (txtID.Enabled && ClsCompany.TourList.ContainsKey(txtID.Text))
                    MessageBox.Show("Tour with this Travel ID already exists.\n\n Travel ID: " + txtID.Text, "Duplicate Travel ID");
                else
                {
                    saveData();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        //Adds New Cost
        private void btnNewCost_Click(object sender, EventArgs e)
        {
            saveData();
            _Cost = ClsCost.NewCost(cboxCosts.SelectedIndex, _Tour);
            if (_Cost != null && _Cost.VeiwEdit())
            {
                _Tour.CostList.Add(_Cost);
                try
                {
                    _CurrentPrice += _Cost.UpdateCostFromTour(_Tour.TotalDays, nudDistance.Value);
                }
                catch { }
                _MarkUpPrice = calculateMarkUp(_CurrentPrice);
                _PricePerPerson = (_MarkUpPrice / nudMaxPeople.Value);
                saveData();
                updateDisplay();
            }
        }

        //Edit Selected Cost
        private void btnEditCost_Click(object sender, EventArgs e)
        {
            saveData();
            ClsCost lcCost = (ClsCost)lstCost.SelectedItem;
            if ((ClsCost)lstCost.SelectedItem != null)
            editCost(lcCost);
            else
            { MessageBox.Show("Please select a cost before editing"); }
        }
        
        //Deletes Selected Cost
        private void btnDeleteCost_Click(object sender, EventArgs e)
        {

        }


        //-------------------------------------END OF BUTTON METHODS---------------------------------------------
        //
        //
        //
        //
        //-------------------------------------FORM METHODS----------------------------------------------------


        //Updating Tour Display
        private void updateDisplay()
        {
            txtID.Text = _Tour.TravelID;
            txtName.Text = _Tour.Name;
            dtpStartDate.Value = _Tour.StartDate;
            dtpEndDate.Value = _Tour.EndDate;
            cboxType.SelectedIndex = _Tour.TypeIndex;
            nudDistance.Value = _Tour.Distance;
            nudMaxPeople.Value = Convert.ToDecimal(_Tour.MaxPeople);
            nudMarkUp.Value = _Tour.MarkUp;
            lblCost.Text = ("$ " + _Tour.TotalPrice);
            lblTotalCost.Text = ("$ " + _Tour.TotalPriceWithMarkUp);
            lblPerPerson.Text = ("$ " + _Tour.PricePerPerson);
            txtID.Enabled = string.IsNullOrEmpty(_Tour.TravelID);
            lstCost.DataSource = null;
            lstCost.DataSource = _Tour.CostList;
        }

        //Saving Tour Information To Class
        private void saveData()
        {
            calculateNumberOfDays();
            _Tour.TravelID = txtID.Text;
            _Tour.Name = txtName.Text;
            _Tour.StartDate = dtpStartDate.Value;
            _Tour.EndDate = dtpEndDate.Value;
            _Tour.TotalDays = _TotalDays;
            _Tour.TypeIndex = cboxType.SelectedIndex;
            _Tour.Distance = nudDistance.Value;
            _Tour.MaxPeople = Convert.ToInt32(nudMaxPeople.Value);
            _Tour.MarkUp = nudMarkUp.Value;
            _Tour.TotalPrice = Convert.ToDecimal(_CurrentPrice);
            _Tour.TotalPriceWithMarkUp = Convert.ToDecimal(_MarkUpPrice);
            _Tour.PricePerPerson = Convert.ToDecimal(_PricePerPerson);
        }

        //Calculate Costs
        private int calculateNumberOfDays()
        {
            _TotalDays = (dtpEndDate.Value - dtpStartDate.Value).Days;
            return _TotalDays;
        }
        private decimal calculatePriceByType(int prDays)
        {
            if (cboxType.SelectedIndex == 0)
            {
                return (prDays *= _DomesticDayPrice);
            }
            else
            {
                return (prDays *= _InternationalDayPrice);
            }
        }
        private decimal calculatePriceByPeople(decimal prDayPrice)
        {
            return (prDayPrice *= nudMaxPeople.Value);
        }
        private decimal calculateMarkUp(decimal prPrice)
        {
            return (prPrice + ((prPrice* nudMarkUp.Value) / 100));
        }

        //Is Any Variable Null
        private bool isObjectsNull()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            { return true; }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            { return true; }
            else if (dtpStartDate.Value == dtpEndDate.Value)
            { return true; }
            else if (nudDistance.Value == 0)
            { return true; }
            else if (nudMaxPeople.Value == 0)
            { return true; }
            else if (nudMarkUp.Value == 0)
            { return true; }
            else
            { return false; }

        }

        //EditCost
        private void editCost(ClsCost prCost)

        {
            _CurrentPrice -= prCost.TotalPrice;
            if (prCost != null && prCost.VeiwEdit())
            {
                try
                {
                    _CurrentPrice += prCost.UpdateCostFromTour(_Tour.TotalDays, nudDistance.Value);
                }
                catch { }
                _MarkUpPrice = calculateMarkUp(_CurrentPrice);
                _PricePerPerson = (_MarkUpPrice / nudMaxPeople.Value);
                saveData();
                updateDisplay();
            }
            //if edit is canceled, readd old cost price
            else
            { _CurrentPrice += prCost.TotalPrice; }
        }

        //-------------------------------------END OF FORM METHODS------------------------------------------------
    }
}
// Coded By Deja Ballard 2018
