namespace Travel_Tour_Pricing
{
    partial class FrmTour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTravelID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.lblMaxPeople = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblMarkUp = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstCost = new System.Windows.Forms.ListBox();
            this.btnNewCost = new System.Windows.Forms.Button();
            this.btnEditCost = new System.Windows.Forms.Button();
            this.btnDeleteCost = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboxCosts = new System.Windows.Forms.ComboBox();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPeople = new System.Windows.Forms.NumericUpDown();
            this.nudMarkUp = new System.Windows.Forms.NumericUpDown();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPerPerson = new System.Windows.Forms.Label();
            this.gboxCosts = new System.Windows.Forms.GroupBox();
            this.btnEnableCosts = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkUp)).BeginInit();
            this.gboxCosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(170, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 29);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "QWN18";
            // 
            // lblTravelID
            // 
            this.lblTravelID.AutoSize = true;
            this.lblTravelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelID.Location = new System.Drawing.Point(12, 59);
            this.lblTravelID.Name = "lblTravelID";
            this.lblTravelID.Size = new System.Drawing.Size(84, 24);
            this.lblTravelID.TabIndex = 2;
            this.lblTravelID.Text = "Travel ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(12, 129);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(89, 24);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(12, 164);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(88, 24);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(170, 129);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 29);
            this.dtpStartDate.TabIndex = 6;
            this.dtpStartDate.Value = new System.DateTime(2018, 5, 10, 0, 0, 0, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(170, 160);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 29);
            this.dtpEndDate.TabIndex = 7;
            this.dtpEndDate.Value = new System.DateTime(2018, 5, 17, 0, 0, 0, 0);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(12, 198);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 24);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type";
            // 
            // cboxType
            // 
            this.cboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Location = new System.Drawing.Point(170, 195);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(200, 32);
            this.cboxType.TabIndex = 9;
            // 
            // lblMaxPeople
            // 
            this.lblMaxPeople.AutoSize = true;
            this.lblMaxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPeople.Location = new System.Drawing.Point(12, 271);
            this.lblMaxPeople.Name = "lblMaxPeople";
            this.lblMaxPeople.Size = new System.Drawing.Size(132, 24);
            this.lblMaxPeople.TabIndex = 13;
            this.lblMaxPeople.Text = "Max Customer";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(12, 236);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(82, 24);
            this.lblDistance.TabIndex = 16;
            this.lblDistance.Text = "Distance";
            // 
            // lblMarkUp
            // 
            this.lblMarkUp.AutoSize = true;
            this.lblMarkUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkUp.Location = new System.Drawing.Point(12, 306);
            this.lblMarkUp.Name = "lblMarkUp";
            this.lblMarkUp.Size = new System.Drawing.Size(80, 24);
            this.lblMarkUp.TabIndex = 17;
            this.lblMarkUp.Text = "Mark Up";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(170, 339);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 33);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate Price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnOkay
            // 
            this.btnOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkay.Location = new System.Drawing.Point(251, 504);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(119, 48);
            this.btnOkay.TabIndex = 24;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(170, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 29);
            this.txtName.TabIndex = 26;
            this.txtName.Text = "Queenstown May 2018";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 33);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tour Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 33);
            this.label10.TabIndex = 31;
            this.label10.Text = "Cost Details";
            // 
            // lstCost
            // 
            this.lstCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCost.FormattingEnabled = true;
            this.lstCost.ItemHeight = 18;
            this.lstCost.Location = new System.Drawing.Point(22, 82);
            this.lstCost.Name = "lstCost";
            this.lstCost.Size = new System.Drawing.Size(300, 400);
            this.lstCost.TabIndex = 32;
            // 
            // btnNewCost
            // 
            this.btnNewCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCost.Location = new System.Drawing.Point(328, 124);
            this.btnNewCost.Name = "btnNewCost";
            this.btnNewCost.Size = new System.Drawing.Size(152, 46);
            this.btnNewCost.TabIndex = 35;
            this.btnNewCost.Text = "New Cost";
            this.btnNewCost.UseVisualStyleBackColor = true;
            this.btnNewCost.Click += new System.EventHandler(this.btnNewCost_Click);
            // 
            // btnEditCost
            // 
            this.btnEditCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCost.Location = new System.Drawing.Point(328, 176);
            this.btnEditCost.Name = "btnEditCost";
            this.btnEditCost.Size = new System.Drawing.Size(152, 46);
            this.btnEditCost.TabIndex = 36;
            this.btnEditCost.Text = "Edit Cost";
            this.btnEditCost.UseVisualStyleBackColor = true;
            this.btnEditCost.Click += new System.EventHandler(this.btnEditCost_Click);
            // 
            // btnDeleteCost
            // 
            this.btnDeleteCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCost.Location = new System.Drawing.Point(328, 228);
            this.btnDeleteCost.Name = "btnDeleteCost";
            this.btnDeleteCost.Size = new System.Drawing.Size(152, 46);
            this.btnDeleteCost.TabIndex = 37;
            this.btnDeleteCost.Text = "Delete Cost";
            this.btnDeleteCost.UseVisualStyleBackColor = true;
            this.btnDeleteCost.Click += new System.EventHandler(this.btnDeleteCost_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 24);
            this.label11.TabIndex = 38;
            this.label11.Text = "Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 24);
            this.label12.TabIndex = 39;
            this.label12.Text = "Cost Per Customer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 24);
            this.label13.TabIndex = 40;
            this.label13.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(174, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 24);
            this.label14.TabIndex = 41;
            this.label14.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(105, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 24);
            this.label15.TabIndex = 42;
            this.label15.Text = "Cost";
            // 
            // cboxCosts
            // 
            this.cboxCosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCosts.FormattingEnabled = true;
            this.cboxCosts.Location = new System.Drawing.Point(328, 85);
            this.cboxCosts.Name = "cboxCosts";
            this.cboxCosts.Size = new System.Drawing.Size(152, 32);
            this.cboxCosts.TabIndex = 43;
            // 
            // nudDistance
            // 
            this.nudDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDistance.Location = new System.Drawing.Point(170, 234);
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(200, 29);
            this.nudDistance.TabIndex = 44;
            this.nudDistance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMaxPeople
            // 
            this.nudMaxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxPeople.Location = new System.Drawing.Point(170, 269);
            this.nudMaxPeople.Name = "nudMaxPeople";
            this.nudMaxPeople.Size = new System.Drawing.Size(200, 29);
            this.nudMaxPeople.TabIndex = 45;
            this.nudMaxPeople.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudMarkUp
            // 
            this.nudMarkUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMarkUp.Location = new System.Drawing.Point(170, 304);
            this.nudMarkUp.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMarkUp.Name = "nudMarkUp";
            this.nudMarkUp.Size = new System.Drawing.Size(200, 29);
            this.nudMarkUp.TabIndex = 46;
            this.nudMarkUp.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(295, 410);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(75, 24);
            this.lblCost.TabIndex = 47;
            this.lblCost.Text = "$30,100";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPerPerson
            // 
            this.lblPerPerson.AutoSize = true;
            this.lblPerPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerPerson.Location = new System.Drawing.Point(295, 458);
            this.lblPerPerson.Name = "lblPerPerson";
            this.lblPerPerson.Size = new System.Drawing.Size(75, 24);
            this.lblPerPerson.TabIndex = 48;
            this.lblPerPerson.Text = "$03,100";
            this.lblPerPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gboxCosts
            // 
            this.gboxCosts.Controls.Add(this.lstCost);
            this.gboxCosts.Controls.Add(this.btnDeleteCost);
            this.gboxCosts.Controls.Add(this.btnEditCost);
            this.gboxCosts.Controls.Add(this.btnNewCost);
            this.gboxCosts.Controls.Add(this.cboxCosts);
            this.gboxCosts.Controls.Add(this.label14);
            this.gboxCosts.Controls.Add(this.label15);
            this.gboxCosts.Controls.Add(this.label10);
            this.gboxCosts.Controls.Add(this.label13);
            this.gboxCosts.Location = new System.Drawing.Point(397, 0);
            this.gboxCosts.Name = "gboxCosts";
            this.gboxCosts.Size = new System.Drawing.Size(486, 499);
            this.gboxCosts.TabIndex = 49;
            this.gboxCosts.TabStop = false;
            // 
            // btnEnableCosts
            // 
            this.btnEnableCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableCosts.Location = new System.Drawing.Point(12, 504);
            this.btnEnableCosts.Name = "btnEnableCosts";
            this.btnEnableCosts.Size = new System.Drawing.Size(233, 48);
            this.btnEnableCosts.TabIndex = 50;
            this.btnEnableCosts.Text = "Enable Extra Costs";
            this.btnEnableCosts.UseVisualStyleBackColor = true;
            this.btnEnableCosts.Click += new System.EventHandler(this.btnEnableCosts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Cost Including Mark Up";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(295, 434);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(75, 24);
            this.lblTotalCost.TabIndex = 52;
            this.lblTotalCost.Text = "$30,100";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 564);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnableCosts);
            this.Controls.Add(this.lblPerPerson);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.nudMarkUp);
            this.Controls.Add(this.nudMaxPeople);
            this.Controls.Add(this.nudDistance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblMarkUp);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblMaxPeople);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTravelID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.gboxCosts);
            this.Name = "FrmTour";
            this.Load += new System.EventHandler(this.FrmTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkUp)).EndInit();
            this.gboxCosts.ResumeLayout(false);
            this.gboxCosts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTravelID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.Label lblMaxPeople;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblMarkUp;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstCost;
        private System.Windows.Forms.Button btnNewCost;
        private System.Windows.Forms.Button btnEditCost;
        private System.Windows.Forms.Button btnDeleteCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboxCosts;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.NumericUpDown nudMaxPeople;
        private System.Windows.Forms.NumericUpDown nudMarkUp;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPerPerson;
        private System.Windows.Forms.GroupBox gboxCosts;
        private System.Windows.Forms.Button btnEnableCosts;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCost;
    }
}