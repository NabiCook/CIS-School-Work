namespace Lab3
{
    partial class Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3));
            this.radiusSquareLbl = new System.Windows.Forms.Label();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.diameterLbl = new System.Windows.Forms.Label();
            this.surfaceAreaLbl = new System.Windows.Forms.Label();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.diameterBox = new System.Windows.Forms.TextBox();
            this.surfaceAreaBox = new System.Windows.Forms.TextBox();
            this.volumeBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusSquareLbl
            // 
            this.radiusSquareLbl.AutoSize = true;
            this.radiusSquareLbl.Location = new System.Drawing.Point(168, 61);
            this.radiusSquareLbl.Name = "radiusSquareLbl";
            this.radiusSquareLbl.Size = new System.Drawing.Size(87, 13);
            this.radiusSquareLbl.TabIndex = 0;
            this.radiusSquareLbl.Text = "Radius of sphere";
            // 
            // radiusBox
            // 
            this.radiusBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.radiusBox.Location = new System.Drawing.Point(261, 59);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(111, 20);
            this.radiusBox.TabIndex = 1;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(277, 85);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(68, 27);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // diameterLbl
            // 
            this.diameterLbl.AutoSize = true;
            this.diameterLbl.Location = new System.Drawing.Point(32, 199);
            this.diameterLbl.Name = "diameterLbl";
            this.diameterLbl.Size = new System.Drawing.Size(49, 13);
            this.diameterLbl.TabIndex = 3;
            this.diameterLbl.Text = "Diameter";
            // 
            // surfaceAreaLbl
            // 
            this.surfaceAreaLbl.AutoSize = true;
            this.surfaceAreaLbl.Location = new System.Drawing.Point(12, 253);
            this.surfaceAreaLbl.Name = "surfaceAreaLbl";
            this.surfaceAreaLbl.Size = new System.Drawing.Size(69, 13);
            this.surfaceAreaLbl.TabIndex = 4;
            this.surfaceAreaLbl.Text = "Surface Area";
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Location = new System.Drawing.Point(39, 306);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(42, 13);
            this.volumeLbl.TabIndex = 5;
            this.volumeLbl.Text = "Volume";
            // 
            // diameterBox
            // 
            this.diameterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterBox.Location = new System.Drawing.Point(87, 197);
            this.diameterBox.Name = "diameterBox";
            this.diameterBox.ReadOnly = true;
            this.diameterBox.Size = new System.Drawing.Size(116, 20);
            this.diameterBox.TabIndex = 6;
            // 
            // surfaceAreaBox
            // 
            this.surfaceAreaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfaceAreaBox.Location = new System.Drawing.Point(87, 251);
            this.surfaceAreaBox.Name = "surfaceAreaBox";
            this.surfaceAreaBox.ReadOnly = true;
            this.surfaceAreaBox.Size = new System.Drawing.Size(116, 20);
            this.surfaceAreaBox.TabIndex = 7;
            // 
            // volumeBox
            // 
            this.volumeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeBox.Location = new System.Drawing.Point(87, 304);
            this.volumeBox.Name = "volumeBox";
            this.volumeBox.ReadOnly = true;
            this.volumeBox.Size = new System.Drawing.Size(116, 20);
            this.volumeBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.volumeBox);
            this.Controls.Add(this.surfaceAreaBox);
            this.Controls.Add(this.diameterBox);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.surfaceAreaLbl);
            this.Controls.Add(this.diameterLbl);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.radiusBox);
            this.Controls.Add(this.radiusSquareLbl);
            this.Name = "Lab3";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiusSquareLbl;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label diameterLbl;
        private System.Windows.Forms.Label surfaceAreaLbl;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.TextBox diameterBox;
        private System.Windows.Forms.TextBox surfaceAreaBox;
        private System.Windows.Forms.TextBox volumeBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

