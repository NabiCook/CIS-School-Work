namespace Program_1
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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.colorsLbl = new System.Windows.Forms.Label();
            this.paintPriceLbl = new System.Windows.Forms.Label();
            this.coatsLbl = new System.Windows.Forms.Label();
            this.illuminateLbl = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.colorsBox = new System.Windows.Forms.TextBox();
            this.paintPriceBox = new System.Windows.Forms.TextBox();
            this.illuminateBox = new System.Windows.Forms.TextBox();
            this.coatsBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.totalArea = new System.Windows.Forms.Label();
            this.paintCost = new System.Windows.Forms.Label();
            this.coatsCost = new System.Windows.Forms.Label();
            this.laborCost = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.totalAreaLbl = new System.Windows.Forms.Label();
            this.paintCostLbl = new System.Windows.Forms.Label();
            this.coatsCostLbl = new System.Windows.Forms.Label();
            this.laborCostLbl = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(216, 9);
            this.welcomeLbl.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(163, 13);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome to My Mural Calculator!";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(25, 50);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(107, 13);
            this.widthLbl.TabIndex = 1;
            this.widthLbl.Text = "Enter the width (in ft):";
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(25, 80);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(111, 13);
            this.lengthLbl.TabIndex = 2;
            this.lengthLbl.Text = "Enter the length (in ft):";
            // 
            // colorsLbl
            // 
            this.colorsLbl.AutoSize = true;
            this.colorsLbl.Location = new System.Drawing.Point(25, 110);
            this.colorsLbl.Name = "colorsLbl";
            this.colorsLbl.Size = new System.Drawing.Size(90, 13);
            this.colorsLbl.TabIndex = 3;
            this.colorsLbl.Text = "Number of colors:";
            // 
            // paintPriceLbl
            // 
            this.paintPriceLbl.AutoSize = true;
            this.paintPriceLbl.Location = new System.Drawing.Point(25, 140);
            this.paintPriceLbl.Name = "paintPriceLbl";
            this.paintPriceLbl.Size = new System.Drawing.Size(70, 13);
            this.paintPriceLbl.TabIndex = 4;
            this.paintPriceLbl.Text = "Price of Paint";
            // 
            // coatsLbl
            // 
            this.coatsLbl.AutoSize = true;
            this.coatsLbl.Location = new System.Drawing.Point(25, 170);
            this.coatsLbl.Name = "coatsLbl";
            this.coatsLbl.Size = new System.Drawing.Size(125, 13);
            this.coatsLbl.TabIndex = 5;
            this.coatsLbl.Text = "Number of Coats (1 or 2):";
            // 
            // illuminateLbl
            // 
            this.illuminateLbl.AutoSize = true;
            this.illuminateLbl.Location = new System.Drawing.Point(25, 200);
            this.illuminateLbl.Name = "illuminateLbl";
            this.illuminateLbl.Size = new System.Drawing.Size(172, 13);
            this.illuminateLbl.TabIndex = 6;
            this.illuminateLbl.Text = "Illuminate Mural? (1 = Yes, 0 = No):";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(219, 47);
            this.widthBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(92, 20);
            this.widthBox.TabIndex = 7;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(219, 77);
            this.lengthBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(92, 20);
            this.lengthBox.TabIndex = 8;
            // 
            // colorsBox
            // 
            this.colorsBox.Location = new System.Drawing.Point(219, 107);
            this.colorsBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.colorsBox.Name = "colorsBox";
            this.colorsBox.Size = new System.Drawing.Size(92, 20);
            this.colorsBox.TabIndex = 9;
            // 
            // paintPriceBox
            // 
            this.paintPriceBox.Location = new System.Drawing.Point(219, 137);
            this.paintPriceBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.paintPriceBox.Name = "paintPriceBox";
            this.paintPriceBox.Size = new System.Drawing.Size(92, 20);
            this.paintPriceBox.TabIndex = 10;
            // 
            // illuminateBox
            // 
            this.illuminateBox.Location = new System.Drawing.Point(219, 197);
            this.illuminateBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.illuminateBox.Name = "illuminateBox";
            this.illuminateBox.Size = new System.Drawing.Size(92, 20);
            this.illuminateBox.TabIndex = 11;
            // 
            // coatsBox
            // 
            this.coatsBox.Location = new System.Drawing.Point(219, 167);
            this.coatsBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.coatsBox.Name = "coatsBox";
            this.coatsBox.Size = new System.Drawing.Size(92, 20);
            this.coatsBox.TabIndex = 11;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(124, 244);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(96, 27);
            this.calculateBtn.TabIndex = 12;
            this.calculateBtn.Text = "Calculate!";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalArea
            // 
            this.totalArea.AutoSize = true;
            this.totalArea.Location = new System.Drawing.Point(339, 224);
            this.totalArea.Name = "totalArea";
            this.totalArea.Size = new System.Drawing.Size(96, 13);
            this.totalArea.TabIndex = 13;
            this.totalArea.Text = "Total Area in sq. ft:";
            // 
            // paintCost
            // 
            this.paintCost.AutoSize = true;
            this.paintCost.Location = new System.Drawing.Point(339, 251);
            this.paintCost.Name = "paintCost";
            this.paintCost.Size = new System.Drawing.Size(72, 13);
            this.paintCost.TabIndex = 14;
            this.paintCost.Text = "Painting Cost:";
            // 
            // coatsCost
            // 
            this.coatsCost.AutoSize = true;
            this.coatsCost.Location = new System.Drawing.Point(339, 278);
            this.coatsCost.Name = "coatsCost";
            this.coatsCost.Size = new System.Drawing.Size(61, 13);
            this.coatsCost.TabIndex = 15;
            this.coatsCost.Text = "Coats Cost:";
            // 
            // laborCost
            // 
            this.laborCost.AutoSize = true;
            this.laborCost.Location = new System.Drawing.Point(339, 305);
            this.laborCost.Name = "laborCost";
            this.laborCost.Size = new System.Drawing.Size(61, 13);
            this.laborCost.TabIndex = 16;
            this.laborCost.Text = "Labor Cost:";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(339, 332);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(58, 13);
            this.totalCost.TabIndex = 17;
            this.totalCost.Text = "Total Cost:";
            // 
            // totalAreaLbl
            // 
            this.totalAreaLbl.Location = new System.Drawing.Point(454, 223);
            this.totalAreaLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.totalAreaLbl.Name = "totalAreaLbl";
            this.totalAreaLbl.Size = new System.Drawing.Size(95, 17);
            this.totalAreaLbl.TabIndex = 18;
            // 
            // paintCostLbl
            // 
            this.paintCostLbl.Location = new System.Drawing.Point(454, 250);
            this.paintCostLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.paintCostLbl.Name = "paintCostLbl";
            this.paintCostLbl.Size = new System.Drawing.Size(95, 17);
            this.paintCostLbl.TabIndex = 19;
            // 
            // coatsCostLbl
            // 
            this.coatsCostLbl.Location = new System.Drawing.Point(454, 277);
            this.coatsCostLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.coatsCostLbl.Name = "coatsCostLbl";
            this.coatsCostLbl.Size = new System.Drawing.Size(95, 17);
            this.coatsCostLbl.TabIndex = 20;
            // 
            // laborCostLbl
            // 
            this.laborCostLbl.Location = new System.Drawing.Point(454, 304);
            this.laborCostLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.laborCostLbl.Name = "laborCostLbl";
            this.laborCostLbl.Size = new System.Drawing.Size(95, 17);
            this.laborCostLbl.TabIndex = 21;
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.Location = new System.Drawing.Point(454, 331);
            this.totalCostLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(95, 17);
            this.totalCostLbl.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.laborCostLbl);
            this.Controls.Add(this.coatsCostLbl);
            this.Controls.Add(this.paintCostLbl);
            this.Controls.Add(this.totalAreaLbl);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.laborCost);
            this.Controls.Add(this.coatsCost);
            this.Controls.Add(this.paintCost);
            this.Controls.Add(this.totalArea);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.coatsBox);
            this.Controls.Add(this.illuminateBox);
            this.Controls.Add(this.paintPriceBox);
            this.Controls.Add(this.colorsBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.illuminateLbl);
            this.Controls.Add(this.coatsLbl);
            this.Controls.Add(this.paintPriceLbl);
            this.Controls.Add(this.colorsLbl);
            this.Controls.Add(this.lengthLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.Label colorsLbl;
        private System.Windows.Forms.Label paintPriceLbl;
        private System.Windows.Forms.Label coatsLbl;
        private System.Windows.Forms.Label illuminateLbl;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox colorsBox;
        private System.Windows.Forms.TextBox paintPriceBox;
        private System.Windows.Forms.TextBox illuminateBox;
        private System.Windows.Forms.TextBox coatsBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label totalArea;
        private System.Windows.Forms.Label paintCost;
        private System.Windows.Forms.Label coatsCost;
        private System.Windows.Forms.Label laborCost;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label totalAreaLbl;
        private System.Windows.Forms.Label paintCostLbl;
        private System.Windows.Forms.Label coatsCostLbl;
        private System.Windows.Forms.Label laborCostLbl;
        private System.Windows.Forms.Label totalCostLbl;
    }
}

