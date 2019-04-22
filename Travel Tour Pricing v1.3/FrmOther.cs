using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Travel_Tour_Pricing
{
    public partial class FrmOther : Travel_Tour_Pricing.FrmNewCost
    {
        //-------------------------------------DECLARING OBJECTS AND VARIABLES-----------------------------------
        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES----------------------------
        //
        //
        //
        //-------------------------------------LOADING METHODS----------------------------------------------------
        public FrmOther()
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
            lblTotal.Text = ("Total: " + txtCost.Text);
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
            ClsOther lcOther = (ClsOther)_Cost;
            txtCost.Text = Convert.ToString(lcOther.TotalPrice);
        }

        protected override void saveData()
        {
          base.saveData();
        ClsOther lcOther = (ClsOther)_Cost;
        lcOther.TotalPrice = Convert.ToDecimal(txtCost.Text);
        }
    //-------------------------------------END OF FORM METHODS-----------------------------------------------
}
}
