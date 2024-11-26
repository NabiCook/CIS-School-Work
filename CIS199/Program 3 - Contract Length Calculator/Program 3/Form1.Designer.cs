namespace Program_3
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.providerLbl = new System.Windows.Forms.Label();
            this.businessLbl = new System.Windows.Forms.Label();
            this.ContractLengthLbl = new System.Windows.Forms.Label();
            this.providerComBox = new System.Windows.Forms.ComboBox();
            this.businessComBox = new System.Windows.Forms.ComboBox();
            this.shippingProviderLbl = new System.Windows.Forms.Label();
            this.initialPriceLbl = new System.Windows.Forms.Label();
            this.companyDiscountLbl = new System.Windows.Forms.Label();
            this.lengthDiscountLbl = new System.Windows.Forms.Label();
            this.finalPriceLbl = new System.Windows.Forms.Label();
            this.providerBox = new System.Windows.Forms.TextBox();
            this.initialContractBox = new System.Windows.Forms.TextBox();
            this.companyDiscountBox = new System.Windows.Forms.TextBox();
            this.lengthDiscountBox = new System.Windows.Forms.TextBox();
            this.finalPriceBox = new System.Windows.Forms.TextBox();
            this.contractLengthBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(140, 244);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(153, 32);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(152, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(141, 13);
            this.title.TabIndex = 1;
            this.title.Text = "Shipping Contract Calculator";
            // 
            // providerLbl
            // 
            this.providerLbl.AutoSize = true;
            this.providerLbl.Location = new System.Drawing.Point(58, 89);
            this.providerLbl.Name = "providerLbl";
            this.providerLbl.Size = new System.Drawing.Size(49, 13);
            this.providerLbl.TabIndex = 2;
            this.providerLbl.Text = "Provider:";
            // 
            // businessLbl
            // 
            this.businessLbl.AutoSize = true;
            this.businessLbl.Location = new System.Drawing.Point(58, 130);
            this.businessLbl.Name = "businessLbl";
            this.businessLbl.Size = new System.Drawing.Size(52, 13);
            this.businessLbl.TabIndex = 3;
            this.businessLbl.Text = "Business:";
            // 
            // ContractLengthLbl
            // 
            this.ContractLengthLbl.AutoSize = true;
            this.ContractLengthLbl.Location = new System.Drawing.Point(58, 178);
            this.ContractLengthLbl.Name = "ContractLengthLbl";
            this.ContractLengthLbl.Size = new System.Drawing.Size(86, 13);
            this.ContractLengthLbl.TabIndex = 4;
            this.ContractLengthLbl.Text = "Contract Length:";
            // 
            // providerComBox
            // 
            this.providerComBox.FormattingEnabled = true;
            this.providerComBox.Location = new System.Drawing.Point(172, 72);
            this.providerComBox.Name = "providerComBox";
            this.providerComBox.Size = new System.Drawing.Size(144, 21);
            this.providerComBox.TabIndex = 5;
            // 
            // businessComBox
            // 
            this.businessComBox.FormattingEnabled = true;
            this.businessComBox.Location = new System.Drawing.Point(172, 122);
            this.businessComBox.Name = "businessComBox";
            this.businessComBox.Size = new System.Drawing.Size(144, 21);
            this.businessComBox.TabIndex = 6;
            // 
            // shippingProviderLbl
            // 
            this.shippingProviderLbl.AutoSize = true;
            this.shippingProviderLbl.Location = new System.Drawing.Point(58, 340);
            this.shippingProviderLbl.Name = "shippingProviderLbl";
            this.shippingProviderLbl.Size = new System.Drawing.Size(93, 13);
            this.shippingProviderLbl.TabIndex = 8;
            this.shippingProviderLbl.Text = "Shipping Provider:";
            // 
            // initialPriceLbl
            // 
            this.initialPriceLbl.AutoSize = true;
            this.initialPriceLbl.Location = new System.Drawing.Point(58, 383);
            this.initialPriceLbl.Name = "initialPriceLbl";
            this.initialPriceLbl.Size = new System.Drawing.Size(104, 13);
            this.initialPriceLbl.TabIndex = 9;
            this.initialPriceLbl.Text = "Initial Contract Price:";
            // 
            // companyDiscountLbl
            // 
            this.companyDiscountLbl.AutoSize = true;
            this.companyDiscountLbl.Location = new System.Drawing.Point(58, 424);
            this.companyDiscountLbl.Name = "companyDiscountLbl";
            this.companyDiscountLbl.Size = new System.Drawing.Size(99, 13);
            this.companyDiscountLbl.TabIndex = 10;
            this.companyDiscountLbl.Text = "Company Discount:";
            // 
            // lengthDiscountLbl
            // 
            this.lengthDiscountLbl.AutoSize = true;
            this.lengthDiscountLbl.Location = new System.Drawing.Point(58, 462);
            this.lengthDiscountLbl.Name = "lengthDiscountLbl";
            this.lengthDiscountLbl.Size = new System.Drawing.Size(88, 13);
            this.lengthDiscountLbl.TabIndex = 11;
            this.lengthDiscountLbl.Text = "Length Discount:";
            // 
            // finalPriceLbl
            // 
            this.finalPriceLbl.AutoSize = true;
            this.finalPriceLbl.Location = new System.Drawing.Point(85, 504);
            this.finalPriceLbl.Name = "finalPriceLbl";
            this.finalPriceLbl.Size = new System.Drawing.Size(59, 13);
            this.finalPriceLbl.TabIndex = 12;
            this.finalPriceLbl.Text = "Final Price:";
            // 
            // providerBox
            // 
            this.providerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.providerBox.Location = new System.Drawing.Point(193, 337);
            this.providerBox.Name = "providerBox";
            this.providerBox.ReadOnly = true;
            this.providerBox.Size = new System.Drawing.Size(123, 20);
            this.providerBox.TabIndex = 13;
            // 
            // initialContractBox
            // 
            this.initialContractBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialContractBox.Location = new System.Drawing.Point(193, 381);
            this.initialContractBox.Name = "initialContractBox";
            this.initialContractBox.ReadOnly = true;
            this.initialContractBox.Size = new System.Drawing.Size(123, 20);
            this.initialContractBox.TabIndex = 14;
            // 
            // companyDiscountBox
            // 
            this.companyDiscountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyDiscountBox.Location = new System.Drawing.Point(193, 422);
            this.companyDiscountBox.Name = "companyDiscountBox";
            this.companyDiscountBox.ReadOnly = true;
            this.companyDiscountBox.Size = new System.Drawing.Size(123, 20);
            this.companyDiscountBox.TabIndex = 15;
            // 
            // lengthDiscountBox
            // 
            this.lengthDiscountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthDiscountBox.Location = new System.Drawing.Point(193, 455);
            this.lengthDiscountBox.Name = "lengthDiscountBox";
            this.lengthDiscountBox.ReadOnly = true;
            this.lengthDiscountBox.Size = new System.Drawing.Size(123, 20);
            this.lengthDiscountBox.TabIndex = 16;
            // 
            // finalPriceBox
            // 
            this.finalPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalPriceBox.Location = new System.Drawing.Point(193, 497);
            this.finalPriceBox.Name = "finalPriceBox";
            this.finalPriceBox.ReadOnly = true;
            this.finalPriceBox.Size = new System.Drawing.Size(123, 20);
            this.finalPriceBox.TabIndex = 17;
            // 
            // contractLengthBox
            // 
            this.contractLengthBox.Location = new System.Drawing.Point(174, 176);
            this.contractLengthBox.Name = "contractLengthBox";
            this.contractLengthBox.Size = new System.Drawing.Size(141, 20);
            this.contractLengthBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 617);
            this.Controls.Add(this.contractLengthBox);
            this.Controls.Add(this.finalPriceBox);
            this.Controls.Add(this.lengthDiscountBox);
            this.Controls.Add(this.companyDiscountBox);
            this.Controls.Add(this.initialContractBox);
            this.Controls.Add(this.providerBox);
            this.Controls.Add(this.finalPriceLbl);
            this.Controls.Add(this.lengthDiscountLbl);
            this.Controls.Add(this.companyDiscountLbl);
            this.Controls.Add(this.initialPriceLbl);
            this.Controls.Add(this.shippingProviderLbl);
            this.Controls.Add(this.businessComBox);
            this.Controls.Add(this.providerComBox);
            this.Controls.Add(this.ContractLengthLbl);
            this.Controls.Add(this.businessLbl);
            this.Controls.Add(this.providerLbl);
            this.Controls.Add(this.title);
            this.Controls.Add(this.calculateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label providerLbl;
        private System.Windows.Forms.Label businessLbl;
        private System.Windows.Forms.Label ContractLengthLbl;
        private System.Windows.Forms.ComboBox providerComBox;
        private System.Windows.Forms.ComboBox businessComBox;
        private System.Windows.Forms.Label shippingProviderLbl;
        private System.Windows.Forms.Label initialPriceLbl;
        private System.Windows.Forms.Label companyDiscountLbl;
        private System.Windows.Forms.Label lengthDiscountLbl;
        private System.Windows.Forms.Label finalPriceLbl;
        private System.Windows.Forms.TextBox providerBox;
        private System.Windows.Forms.TextBox initialContractBox;
        private System.Windows.Forms.TextBox companyDiscountBox;
        private System.Windows.Forms.TextBox lengthDiscountBox;
        private System.Windows.Forms.TextBox finalPriceBox;
        private System.Windows.Forms.TextBox contractLengthBox;
    }
}

