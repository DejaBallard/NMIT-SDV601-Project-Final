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
    public partial class FrmNewCost : Form
    {
        //-------------------------------------DECLARING OBJECTS AND VARIABLES-----------------------------------
        protected int _TotalDays;
        protected ClsCost _Cost;
        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES----------------------------
        //
        //
        //
        //-------------------------------------LOADING METHODS----------------------------------------------------
        public FrmNewCost()
        {
            InitializeComponent();
        }

        public bool ShowDialog(ClsCost prCost)
        {
            _Cost = prCost;
            _TotalDays = _Cost.Tour.TotalDays;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }
      
        //-------------------------------------END OF LOADING METHODS---------------------------------------------
        //
        //
        //
        //
        //-------------------------------------BUTTON METHODS----------------------------------------------------
        private void btnOkay_Click(object sender, EventArgs e)
        {
            saveData();
            DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //-------------------------------------END OF BUTTON METHODS---------------------------------------------
        //
        //
        //
        //
        //-------------------------------------FORM METHODS-----------------------------------------------------
        protected virtual void updateDisplay()
        {
            txtName.Text = _Cost.Name;
            txtDescription.Text = _Cost.Description;
            lblTotal.Text = ("Total: " + _Cost.TotalPrice);
            lblStartDate.Text = ("Start Date: " + _Cost.Tour.StartDate.ToShortDateString());
            lblEndDate.Text = ("End Date: " + _Cost.Tour.EndDate.ToShortDateString());
        }

        protected virtual void saveData()
        {
            _Cost.Name = txtName.Text;
            _Cost.Description = txtDescription.Text;
        }

        protected virtual  void btnCalculate_Click(object sender, EventArgs e)
        {

        }
        //-------------------------------------END OF FORM METHODS-----------------------------------------------

    }
}
//Coded by Deja Ballard 2018
