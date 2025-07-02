namespace Prog2Start
{
    partial class FurnitureForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            couchToolStripMenuItem = new ToolStripMenuItem();
            deskChairToolStripMenuItem = new ToolStripMenuItem();
            furnitureListView = new ListView();
            typeColumn = new ColumnHeader();
            weightHeader = new ColumnHeader();
            categoryHeader = new ColumnHeader();
            detailsButton = new Button();
            clearButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, createToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(345, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(107, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(107, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(107, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { couchToolStripMenuItem, deskChairToolStripMenuItem });
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(48, 20);
            createToolStripMenuItem.Text = "Insert";
            // 
            // couchToolStripMenuItem
            // 
            couchToolStripMenuItem.Name = "couchToolStripMenuItem";
            couchToolStripMenuItem.Size = new Size(130, 22);
            couchToolStripMenuItem.Text = "Couch";
            couchToolStripMenuItem.Click += couchToolStripMenuItem_Click;
            // 
            // deskChairToolStripMenuItem
            // 
            deskChairToolStripMenuItem.Name = "deskChairToolStripMenuItem";
            deskChairToolStripMenuItem.Size = new Size(130, 22);
            deskChairToolStripMenuItem.Text = "Desk Chair";
            deskChairToolStripMenuItem.Click += deskChairToolStripMenuItem_Click;
            // 
            // furnitureListView
            // 
            furnitureListView.Columns.AddRange(new ColumnHeader[] { typeColumn, weightHeader, categoryHeader });
            furnitureListView.Location = new Point(17, 38);
            furnitureListView.MultiSelect = false;
            furnitureListView.Name = "furnitureListView";
            furnitureListView.Size = new Size(306, 292);
            furnitureListView.TabIndex = 1;
            furnitureListView.UseCompatibleStateImageBehavior = false;
            furnitureListView.View = View.Details;
            // 
            // typeColumn
            // 
            typeColumn.Text = "Furniture Type";
            typeColumn.Width = 100;
            // 
            // weightHeader
            // 
            weightHeader.Text = "Weight";
            weightHeader.Width = 100;
            // 
            // categoryHeader
            // 
            categoryHeader.Text = "Category";
            categoryHeader.Width = 100;
            // 
            // detailsButton
            // 
            detailsButton.Location = new Point(127, 343);
            detailsButton.Name = "detailsButton";
            detailsButton.Size = new Size(75, 23);
            detailsButton.TabIndex = 2;
            detailsButton.Text = "Details";
            detailsButton.UseVisualStyleBackColor = true;
            detailsButton.Click += detailsButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(240, 343);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(71, 27);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // FurnitureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 406);
            Controls.Add(clearButton);
            Controls.Add(detailsButton);
            Controls.Add(furnitureListView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FurnitureForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Furniture Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem couchToolStripMenuItem;
        private ToolStripMenuItem deskChairToolStripMenuItem;
        private ListView furnitureListView;
        private ColumnHeader typeColumn;
        private ColumnHeader weightHeader;
        private ColumnHeader categoryHeader;
        private Button detailsButton;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private Button clearButton;
    }
}
