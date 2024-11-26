namespace Lab4
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
            this.enterGPATxt = new System.Windows.Forms.Label();
            this.enterTestScoreTxt = new System.Windows.Forms.Label();
            this.admissionDecisionTxt = new System.Windows.Forms.Label();
            this.admitBtn = new System.Windows.Forms.Button();
            this.acceptedTxt = new System.Windows.Forms.Label();
            this.rejectedTxt = new System.Windows.Forms.Label();
            this.acceptedCount = new System.Windows.Forms.Label();
            this.rejectedCount = new System.Windows.Forms.Label();
            this.admissionDecision = new System.Windows.Forms.Label();
            this.gpaBox = new System.Windows.Forms.TextBox();
            this.admissionTestScoreBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterGPATxt
            // 
            this.enterGPATxt.AutoSize = true;
            this.enterGPATxt.Location = new System.Drawing.Point(28, 22);
            this.enterGPATxt.Name = "enterGPATxt";
            this.enterGPATxt.Size = new System.Drawing.Size(133, 13);
            this.enterGPATxt.TabIndex = 0;
            this.enterGPATxt.Text = "Enter grade point average:";
            // 
            // enterTestScoreTxt
            // 
            this.enterTestScoreTxt.AutoSize = true;
            this.enterTestScoreTxt.Location = new System.Drawing.Point(28, 71);
            this.enterTestScoreTxt.Name = "enterTestScoreTxt";
            this.enterTestScoreTxt.Size = new System.Drawing.Size(133, 13);
            this.enterTestScoreTxt.TabIndex = 1;
            this.enterTestScoreTxt.Text = "Enter admission test score:";
            // 
            // admissionDecisionTxt
            // 
            this.admissionDecisionTxt.AutoSize = true;
            this.admissionDecisionTxt.Location = new System.Drawing.Point(60, 113);
            this.admissionDecisionTxt.Name = "admissionDecisionTxt";
            this.admissionDecisionTxt.Size = new System.Drawing.Size(101, 13);
            this.admissionDecisionTxt.TabIndex = 2;
            this.admissionDecisionTxt.Text = "Admission Decision:";
            // 
            // admitBtn
            // 
            this.admitBtn.Location = new System.Drawing.Point(77, 153);
            this.admitBtn.Name = "admitBtn";
            this.admitBtn.Size = new System.Drawing.Size(115, 32);
            this.admitBtn.TabIndex = 3;
            this.admitBtn.Text = "Admit?";
            this.admitBtn.UseVisualStyleBackColor = true;
            this.admitBtn.Click += new System.EventHandler(this.admitBtn_Click);
            // 
            // acceptedTxt
            // 
            this.acceptedTxt.AutoSize = true;
            this.acceptedTxt.Location = new System.Drawing.Point(28, 211);
            this.acceptedTxt.Name = "acceptedTxt";
            this.acceptedTxt.Size = new System.Drawing.Size(56, 13);
            this.acceptedTxt.TabIndex = 4;
            this.acceptedTxt.Text = "Accepted:";
            // 
            // rejectedTxt
            // 
            this.rejectedTxt.AutoSize = true;
            this.rejectedTxt.Location = new System.Drawing.Point(28, 247);
            this.rejectedTxt.Name = "rejectedTxt";
            this.rejectedTxt.Size = new System.Drawing.Size(53, 13);
            this.rejectedTxt.TabIndex = 5;
            this.rejectedTxt.Text = "Rejected:";
            // 
            // acceptedCount
            // 
            this.acceptedCount.AutoSize = true;
            this.acceptedCount.Location = new System.Drawing.Point(100, 211);
            this.acceptedCount.Name = "acceptedCount";
            this.acceptedCount.Size = new System.Drawing.Size(31, 13);
            this.acceptedCount.TabIndex = 6;
            this.acceptedCount.Text = "none";
            // 
            // rejectedCount
            // 
            this.rejectedCount.AutoSize = true;
            this.rejectedCount.Location = new System.Drawing.Point(100, 247);
            this.rejectedCount.Name = "rejectedCount";
            this.rejectedCount.Size = new System.Drawing.Size(31, 13);
            this.rejectedCount.TabIndex = 7;
            this.rejectedCount.Text = "none";
            // 
            // admissionDecision
            // 
            this.admissionDecision.AutoSize = true;
            this.admissionDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionDecision.Location = new System.Drawing.Point(188, 113);
            this.admissionDecision.Name = "admissionDecision";
            this.admissionDecision.Size = new System.Drawing.Size(35, 13);
            this.admissionDecision.TabIndex = 8;
            this.admissionDecision.Text = "none";
            // 
            // gpaBox
            // 
            this.gpaBox.Location = new System.Drawing.Point(167, 19);
            this.gpaBox.Name = "gpaBox";
            this.gpaBox.Size = new System.Drawing.Size(72, 20);
            this.gpaBox.TabIndex = 9;
            // 
            // admissionTestScoreBox
            // 
            this.admissionTestScoreBox.Location = new System.Drawing.Point(167, 68);
            this.admissionTestScoreBox.Name = "admissionTestScoreBox";
            this.admissionTestScoreBox.Size = new System.Drawing.Size(72, 20);
            this.admissionTestScoreBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 280);
            this.Controls.Add(this.admissionTestScoreBox);
            this.Controls.Add(this.gpaBox);
            this.Controls.Add(this.admissionDecision);
            this.Controls.Add(this.rejectedCount);
            this.Controls.Add(this.acceptedCount);
            this.Controls.Add(this.rejectedTxt);
            this.Controls.Add(this.acceptedTxt);
            this.Controls.Add(this.admitBtn);
            this.Controls.Add(this.admissionDecisionTxt);
            this.Controls.Add(this.enterTestScoreTxt);
            this.Controls.Add(this.enterGPATxt);
            this.Name = "Form1";
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterGPATxt;
        private System.Windows.Forms.Label enterTestScoreTxt;
        private System.Windows.Forms.Label admissionDecisionTxt;
        private System.Windows.Forms.Button admitBtn;
        private System.Windows.Forms.Label acceptedTxt;
        private System.Windows.Forms.Label rejectedTxt;
        private System.Windows.Forms.Label acceptedCount;
        private System.Windows.Forms.Label rejectedCount;
        private System.Windows.Forms.Label admissionDecision;
        private System.Windows.Forms.TextBox gpaBox;
        private System.Windows.Forms.TextBox admissionTestScoreBox;
    }
}

