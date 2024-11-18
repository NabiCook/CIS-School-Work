namespace Lab2
{
    partial class Lab2
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.tipLabel15 = new System.Windows.Forms.Label();
            this.tipLabel18 = new System.Windows.Forms.Label();
            this.tipLabel20 = new System.Windows.Forms.Label();
            this.priceInputBox = new System.Windows.Forms.TextBox();
            this.calcTipBtn = new System.Windows.Forms.Button();
            this.tipAmount15 = new System.Windows.Forms.Label();
            this.tipAmount18 = new System.Windows.Forms.Label();
            this.tipAmount20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(12, 17);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(122, 16);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Enter Price of meal:";
            // 
            // tipLabel15
            // 
            this.tipLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipLabel15.AutoSize = true;
            this.tipLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel15.Location = new System.Drawing.Point(101, 47);
            this.tipLabel15.Name = "tipLabel15";
            this.tipLabel15.Size = new System.Drawing.Size(33, 16);
            this.tipLabel15.TabIndex = 1;
            this.tipLabel15.Text = "15%";
            // 
            // tipLabel18
            // 
            this.tipLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipLabel18.AutoSize = true;
            this.tipLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel18.Location = new System.Drawing.Point(101, 77);
            this.tipLabel18.Name = "tipLabel18";
            this.tipLabel18.Size = new System.Drawing.Size(33, 16);
            this.tipLabel18.TabIndex = 2;
            this.tipLabel18.Text = "18%";
            // 
            // tipLabel20
            // 
            this.tipLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipLabel20.AutoSize = true;
            this.tipLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel20.Location = new System.Drawing.Point(101, 107);
            this.tipLabel20.Name = "tipLabel20";
            this.tipLabel20.Size = new System.Drawing.Size(33, 16);
            this.tipLabel20.TabIndex = 3;
            this.tipLabel20.Text = "20%";
            // 
            // priceInputBox
            // 
            this.priceInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceInputBox.Location = new System.Drawing.Point(140, 16);
            this.priceInputBox.Name = "priceInputBox";
            this.priceInputBox.Size = new System.Drawing.Size(78, 20);
            this.priceInputBox.TabIndex = 4;
            // 
            // calcTipBtn
            // 
            this.calcTipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.calcTipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcTipBtn.Location = new System.Drawing.Point(61, 157);
            this.calcTipBtn.Name = "calcTipBtn";
            this.calcTipBtn.Size = new System.Drawing.Size(112, 32);
            this.calcTipBtn.TabIndex = 8;
            this.calcTipBtn.Text = "Calculate Tip";
            this.calcTipBtn.UseVisualStyleBackColor = true;
            this.calcTipBtn.Click += new System.EventHandler(this.calcTipBtn_Click);
            // 
            // tipAmount15
            // 
            this.tipAmount15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipAmount15.BackColor = System.Drawing.SystemColors.Control;
            this.tipAmount15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipAmount15.Location = new System.Drawing.Point(140, 46);
            this.tipAmount15.Name = "tipAmount15";
            this.tipAmount15.Size = new System.Drawing.Size(78, 20);
            this.tipAmount15.TabIndex = 9;
            // 
            // tipAmount18
            // 
            this.tipAmount18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipAmount18.BackColor = System.Drawing.SystemColors.Control;
            this.tipAmount18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipAmount18.Location = new System.Drawing.Point(140, 76);
            this.tipAmount18.Name = "tipAmount18";
            this.tipAmount18.Size = new System.Drawing.Size(78, 20);
            this.tipAmount18.TabIndex = 10;
            // 
            // tipAmount20
            // 
            this.tipAmount20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipAmount20.BackColor = System.Drawing.SystemColors.Control;
            this.tipAmount20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipAmount20.Location = new System.Drawing.Point(140, 106);
            this.tipAmount20.Name = "tipAmount20";
            this.tipAmount20.Size = new System.Drawing.Size(78, 20);
            this.tipAmount20.TabIndex = 11;
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.tipAmount20);
            this.Controls.Add(this.tipAmount18);
            this.Controls.Add(this.tipAmount15);
            this.Controls.Add(this.calcTipBtn);
            this.Controls.Add(this.priceInputBox);
            this.Controls.Add(this.tipLabel20);
            this.Controls.Add(this.tipLabel18);
            this.Controls.Add(this.tipLabel15);
            this.Controls.Add(this.priceLabel);
            this.Name = "Lab2";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label tipLabel15;
        private System.Windows.Forms.Label tipLabel18;
        private System.Windows.Forms.Label tipLabel20;
        private System.Windows.Forms.TextBox priceInputBox;
        private System.Windows.Forms.Button calcTipBtn;
        private System.Windows.Forms.Label tipAmount15;
        private System.Windows.Forms.Label tipAmount18;
        private System.Windows.Forms.Label tipAmount20;
    }
}

