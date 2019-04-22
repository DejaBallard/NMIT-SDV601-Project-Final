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
    public partial class FrmVehicle : FrmNewCost
    {
        //-------------------------------------DECLARING OBJECTS AND VARIABLES-----------------------------------
        private decimal _TotalPrice;
        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES----------------------------
        //
        //
        //
        //-------------------------------------LOADING METHODS----------------------------------------------------
        public FrmVehicle()
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
            decimal lcKmCharge = Convert.ToDecimal(txtCharge.Text);
           _TotalPrice = _Cost.CalculateCost(lcKmCharge);
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
            ClsVehicle lcVehicle = (ClsVehicle)_Cost;
            txtCharge.Text = Convert.ToString(lcVehicle.KmCharge);
        }

        protected override void saveData()
        {
            base.saveData();
            ClsVehicle lcVehicle = (ClsVehicle)_Cost;
            lcVehicle.KmCharge = Convert.ToDecimal(txtCharge.Text);
            lcVehicle.TotalPrice = _TotalPrice;
        }
        //-------------------------------------END OF FORM METHODS------------------------------------------------
    }
}
