using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Travel_Tour_Pricing
{
    public partial class FrmStaff : Travel_Tour_Pricing.FrmNewCost
    {
        //-------------------------------------DECLARING OBJECTS AND VARIABLES-----------------------------------
        private decimal _TotalPrice;
        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES----------------------------
        //
        //
        //
        //-------------------------------------LOADING METHODS----------------------------------------------------
        public FrmStaff()
        {
            InitializeComponent();
        }
        //-------------------------------------END OF LOADING METHODS---------------------------------------------
        //
        //
        //
        //
        //-------------------------------------BUTTON METHODS----------------------------------------------------
        protected override void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal lcRate = Convert.ToDecimal(txtRate.Text);
            _TotalPrice = _Cost.CalculateCost(lcRate);
            lblTotal.Text = ("Total: " + _TotalPrice);
        }
        //-------------------------------------END OF BUTTON METHODS---------------------------------------------
        //
        //
        //
        //
        //-------------------------------------FORM METHODS-----------------------------------------------------
        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsStaff lcStaff = (ClsStaff)_Cost;
            txtRate.Text = Convert.ToString(lcStaff.Rate);
        }

        protected override void saveData()
        {
            base.saveData();
            ClsStaff lcStaff = (ClsStaff)_Cost;
           lcStaff.Rate = Convert.ToDecimal(txtRate.Text);
            lcStaff.TotalPrice = _TotalPrice;
        }
        //-------------------------------------END OF FORM METHODS-----------------------------------------------

    }
}
