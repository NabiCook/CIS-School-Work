namespace Program2
{
    partial class Form1
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.carValueLbl = new System.Windows.Forms.Label();
            this.healthInsuranceLbl = new System.Windows.Forms.Label();
            this.carInsuranceLbl = new System.Windows.Forms.Label();
            this.smokeLbl = new System.Windows.Forms.Label();
            this.accidentLbl = new System.Windows.Forms.Label();
            this.healthCoverageLbl = new System.Windows.Forms.Label();
            this.carCoverageLbl = new System.Windows.Forms.Label();
            this.totalPolicyCostLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.smokeYes = new System.Windows.Forms.RadioButton();
            this.smokeNo = new System.Windows.Forms.RadioButton();
            this.accidentYes = new System.Windows.Forms.RadioButton();
            this.accidentNo = new System.Windows.Forms.RadioButton();
            this.healthInsuranceCombo = new System.Windows.Forms.ComboBox();
            this.carInsuranceCombo = new System.Windows.Forms.ComboBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.healthCostBox = new System.Windows.Forms.TextBox();
            this.carCostBox = new System.Windows.Forms.TextBox();
            this.totalCostBox = new System.Windows.Forms.TextBox();
            this.smokeGroup = new System.Windows.Forms.GroupBox();
            this.accidentGroup = new System.Windows.Forms.GroupBox();
            this.smokeGroup.SuspendLayout();
            this.accidentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(87, 18);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(212, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Cardinal Insurance Policy Calculator";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(62, 64);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(82, 13);
            this.ageLbl.TabIndex = 1;
            this.ageLbl.Text = "Enter Your Age:";
            // 
            // carValueLbl
            // 
            this.carValueLbl.AutoSize = true;
            this.carValueLbl.Location = new System.Drawing.Point(62, 105);
            this.carValueLbl.Name = "carValueLbl";
            this.carValueLbl.Size = new System.Drawing.Size(117, 13);
            this.carValueLbl.TabIndex = 2;
            this.carValueLbl.Text = "Estimated Value of Car:";
            // 
            // healthInsuranceLbl
            // 
            this.healthInsuranceLbl.AutoSize = true;
            this.healthInsuranceLbl.Location = new System.Drawing.Point(62, 143);
            this.healthInsuranceLbl.Name = "healthInsuranceLbl";
            this.healthInsuranceLbl.Size = new System.Drawing.Size(140, 13);
            this.healthInsuranceLbl.TabIndex = 3;
            this.healthInsuranceLbl.Text = "Health Insurance Coverage:";
            // 
            // carInsuranceLbl
            // 
            this.carInsuranceLbl.AutoSize = true;
            this.carInsuranceLbl.Location = new System.Drawing.Point(63, 180);
            this.carInsuranceLbl.Name = "carInsuranceLbl";
            this.carInsuranceLbl.Size = new System.Drawing.Size(125, 13);
            this.carInsuranceLbl.TabIndex = 4;
            this.carInsuranceLbl.Text = "Car Insurance Coverage:";
            // 
            // smokeLbl
            // 
            this.smokeLbl.AutoSize = true;
            this.smokeLbl.Location = new System.Drawing.Point(4, 29);
            this.smokeLbl.Name = "smokeLbl";
            this.smokeLbl.Size = new System.Drawing.Size(85, 13);
            this.smokeLbl.TabIndex = 5;
            this.smokeLbl.Text = "Do You Smoke?";
            // 
            // accidentLbl
            // 
            this.accidentLbl.AutoSize = true;
            this.accidentLbl.Location = new System.Drawing.Point(6, 28);
            this.accidentLbl.Name = "accidentLbl";
            this.accidentLbl.Size = new System.Drawing.Size(152, 13);
            this.accidentLbl.TabIndex = 6;
            this.accidentLbl.Text = "Car Accident in the Past Year?";
            // 
            // healthCoverageLbl
            // 
            this.healthCoverageLbl.AutoSize = true;
            this.healthCoverageLbl.Location = new System.Drawing.Point(48, 419);
            this.healthCoverageLbl.Name = "healthCoverageLbl";
            this.healthCoverageLbl.Size = new System.Drawing.Size(157, 13);
            this.healthCoverageLbl.TabIndex = 7;
            this.healthCoverageLbl.Text = "Health Coverage Cost per Year:";
            // 
            // carCoverageLbl
            // 
            this.carCoverageLbl.AutoSize = true;
            this.carCoverageLbl.Location = new System.Drawing.Point(48, 459);
            this.carCoverageLbl.Name = "carCoverageLbl";
            this.carCoverageLbl.Size = new System.Drawing.Size(142, 13);
            this.carCoverageLbl.TabIndex = 8;
            this.carCoverageLbl.Text = "Car Coverage Cost per Year:";
            // 
            // totalPolicyCostLbl
            // 
            this.totalPolicyCostLbl.AutoSize = true;
            this.totalPolicyCostLbl.Location = new System.Drawing.Point(48, 496);
            this.totalPolicyCostLbl.Name = "totalPolicyCostLbl";
            this.totalPolicyCostLbl.Size = new System.Drawing.Size(132, 13);
            this.totalPolicyCostLbl.TabIndex = 9;
            this.totalPolicyCostLbl.Text = "Total Policy Cost per Year:";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(106, 358);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(172, 32);
            this.calculateBtn.TabIndex = 10;
            this.calculateBtn.Text = "Calculate Policy Premiums";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // smokeYes
            // 
            this.smokeYes.AutoSize = true;
            this.smokeYes.Location = new System.Drawing.Point(199, 17);
            this.smokeYes.Name = "smokeYes";
            this.smokeYes.Size = new System.Drawing.Size(43, 17);
            this.smokeYes.TabIndex = 11;
            this.smokeYes.TabStop = true;
            this.smokeYes.Text = "Yes";
            this.smokeYes.UseVisualStyleBackColor = true;
            // 
            // smokeNo
            // 
            this.smokeNo.AutoSize = true;
            this.smokeNo.Location = new System.Drawing.Point(199, 41);
            this.smokeNo.Name = "smokeNo";
            this.smokeNo.Size = new System.Drawing.Size(39, 17);
            this.smokeNo.TabIndex = 12;
            this.smokeNo.TabStop = true;
            this.smokeNo.Text = "No";
            this.smokeNo.UseVisualStyleBackColor = true;
            // 
            // accidentYes
            // 
            this.accidentYes.AutoSize = true;
            this.accidentYes.Location = new System.Drawing.Point(199, 17);
            this.accidentYes.Name = "accidentYes";
            this.accidentYes.Size = new System.Drawing.Size(43, 17);
            this.accidentYes.TabIndex = 13;
            this.accidentYes.TabStop = true;
            this.accidentYes.Text = "Yes";
            this.accidentYes.UseVisualStyleBackColor = true;
            // 
            // accidentNo
            // 
            this.accidentNo.AutoSize = true;
            this.accidentNo.Location = new System.Drawing.Point(199, 41);
            this.accidentNo.Name = "accidentNo";
            this.accidentNo.Size = new System.Drawing.Size(39, 17);
            this.accidentNo.TabIndex = 14;
            this.accidentNo.TabStop = true;
            this.accidentNo.Text = "No";
            this.accidentNo.UseVisualStyleBackColor = true;
            // 
            // healthInsuranceCombo
            // 
            this.healthInsuranceCombo.FormattingEnabled = true;
            this.healthInsuranceCombo.Location = new System.Drawing.Point(213, 140);
            this.healthInsuranceCombo.Name = "healthInsuranceCombo";
            this.healthInsuranceCombo.Size = new System.Drawing.Size(100, 21);
            this.healthInsuranceCombo.TabIndex = 15;
            this.healthInsuranceCombo.Text = "Select";
            // 
            // carInsuranceCombo
            // 
            this.carInsuranceCombo.FormattingEnabled = true;
            this.carInsuranceCombo.Location = new System.Drawing.Point(213, 177);
            this.carInsuranceCombo.Name = "carInsuranceCombo";
            this.carInsuranceCombo.Size = new System.Drawing.Size(100, 21);
            this.carInsuranceCombo.TabIndex = 16;
            this.carInsuranceCombo.Text = "Select";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(213, 61);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 20);
            this.ageBox.TabIndex = 17;
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(213, 102);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(100, 20);
            this.valueBox.TabIndex = 18;
            // 
            // healthCostBox
            // 
            this.healthCostBox.Location = new System.Drawing.Point(231, 416);
            this.healthCostBox.Name = "healthCostBox";
            this.healthCostBox.ReadOnly = true;
            this.healthCostBox.Size = new System.Drawing.Size(100, 20);
            this.healthCostBox.TabIndex = 19;
            // 
            // carCostBox
            // 
            this.carCostBox.Location = new System.Drawing.Point(231, 456);
            this.carCostBox.Name = "carCostBox";
            this.carCostBox.ReadOnly = true;
            this.carCostBox.Size = new System.Drawing.Size(100, 20);
            this.carCostBox.TabIndex = 20;
            // 
            // totalCostBox
            // 
            this.totalCostBox.Location = new System.Drawing.Point(231, 493);
            this.totalCostBox.Name = "totalCostBox";
            this.totalCostBox.ReadOnly = true;
            this.totalCostBox.Size = new System.Drawing.Size(100, 20);
            this.totalCostBox.TabIndex = 21;
            // 
            // smokeGroup
            // 
            this.smokeGroup.Controls.Add(this.smokeNo);
            this.smokeGroup.Controls.Add(this.smokeYes);
            this.smokeGroup.Controls.Add(this.smokeLbl);
            this.smokeGroup.Location = new System.Drawing.Point(65, 204);
            this.smokeGroup.Name = "smokeGroup";
            this.smokeGroup.Size = new System.Drawing.Size(248, 68);
            this.smokeGroup.TabIndex = 22;
            this.smokeGroup.TabStop = false;
            // 
            // accidentGroup
            // 
            this.accidentGroup.Controls.Add(this.accidentNo);
            this.accidentGroup.Controls.Add(this.accidentYes);
            this.accidentGroup.Controls.Add(this.accidentLbl);
            this.accidentGroup.Location = new System.Drawing.Point(65, 278);
            this.accidentGroup.Name = "accidentGroup";
            this.accidentGroup.Size = new System.Drawing.Size(248, 65);
            this.accidentGroup.TabIndex = 23;
            this.accidentGroup.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 565);
            this.Controls.Add(this.accidentGroup);
            this.Controls.Add(this.smokeGroup);
            this.Controls.Add(this.totalCostBox);
            this.Controls.Add(this.carCostBox);
            this.Controls.Add(this.healthCostBox);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.carInsuranceCombo);
            this.Controls.Add(this.healthInsuranceCombo);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.totalPolicyCostLbl);
            this.Controls.Add(this.carCoverageLbl);
            this.Controls.Add(this.healthCoverageLbl);
            this.Controls.Add(this.carInsuranceLbl);
            this.Controls.Add(this.healthInsuranceLbl);
            this.Controls.Add(this.carValueLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "Form1";
            this.Text = "Insurance Policy Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.smokeGroup.ResumeLayout(false);
            this.smokeGroup.PerformLayout();
            this.accidentGroup.ResumeLayout(false);
            this.accidentGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label carValueLbl;
        private System.Windows.Forms.Label healthInsuranceLbl;
        private System.Windows.Forms.Label carInsuranceLbl;
        private System.Windows.Forms.Label smokeLbl;
        private System.Windows.Forms.Label accidentLbl;
        private System.Windows.Forms.Label healthCoverageLbl;
        private System.Windows.Forms.Label carCoverageLbl;
        private System.Windows.Forms.Label totalPolicyCostLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.RadioButton smokeYes;
        private System.Windows.Forms.RadioButton smokeNo;
        private System.Windows.Forms.RadioButton accidentYes;
        private System.Windows.Forms.RadioButton accidentNo;
        private System.Windows.Forms.ComboBox healthInsuranceCombo;
        private System.Windows.Forms.ComboBox carInsuranceCombo;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.TextBox healthCostBox;
        private System.Windows.Forms.TextBox carCostBox;
        private System.Windows.Forms.TextBox totalCostBox;
        private System.Windows.Forms.GroupBox smokeGroup;
        private System.Windows.Forms.GroupBox accidentGroup;
    }
}

