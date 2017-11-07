namespace Hotel_Reservations
{
    partial class CreateFilesForm
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTheHotelsxmlFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTheHotelxmlFileInAWebBrowserWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTheRoominventoryxmlFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTheRoominventoryxmlFileInAWebBrowserWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadHotelFile = new System.Windows.Forms.Button();
            this.btnCreateListOfAllFiles = new System.Windows.Forms.Button();
            this.btnShowHotelList = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(21, 630);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "(status of last operation)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1555, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1555, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTheHotelsxmlFileToolStripMenuItem,
            this.displayTheHotelxmlFileInAWebBrowserWindowToolStripMenuItem,
            this.createTheRoominventoryxmlFileToolStripMenuItem,
            this.displayTheRoominventoryxmlFileInAWebBrowserWindowToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createTheHotelsxmlFileToolStripMenuItem
            // 
            this.createTheHotelsxmlFileToolStripMenuItem.Name = "createTheHotelsxmlFileToolStripMenuItem";
            this.createTheHotelsxmlFileToolStripMenuItem.Size = new System.Drawing.Size(392, 22);
            this.createTheHotelsxmlFileToolStripMenuItem.Text = "Create the hotels.xml file";
            this.createTheHotelsxmlFileToolStripMenuItem.Click += new System.EventHandler(this.createTheHotelsxmlFileToolStripMenuItem_Click);
            // 
            // displayTheHotelxmlFileInAWebBrowserWindowToolStripMenuItem
            // 
            this.displayTheHotelxmlFileInAWebBrowserWindowToolStripMenuItem.Name = "displayTheHotelxmlFileInAWebBrowserWindowToolStripMenuItem";
            this.displayTheHotelxmlFileInAWebBrowserWindowToolStripMenuItem.Size = new System.Drawing.Size(392, 22);
            this.displayTheHotelxmlFileInAWebBrowserWindowToolStripMenuItem.Text = "Display the hotel.xml file in a web browser window";
            this.displayTheHotelxmlFileInAWebBrowserWindowToolStripMenuItem.Click += new System.EventHandler(this.displayTheHotelxmlFileInAWebBrowserWindowToolStripMenuItem_Click);
            // 
            // createTheRoominventoryxmlFileToolStripMenuItem
            // 
            this.createTheRoominventoryxmlFileToolStripMenuItem.Name = "createTheRoominventoryxmlFileToolStripMenuItem";
            this.createTheRoominventoryxmlFileToolStripMenuItem.Size = new System.Drawing.Size(392, 22);
            this.createTheRoominventoryxmlFileToolStripMenuItem.Text = "Create the roominventory.xml file";
            this.createTheRoominventoryxmlFileToolStripMenuItem.Click += new System.EventHandler(this.createTheRoominventoryxmlFileToolStripMenuItem_Click);
            // 
            // displayTheRoominventoryxmlFileInAWebBrowserWindowToolStripMenuItem
            // 
            this.displayTheRoominventoryxmlFileInAWebBrowserWindowToolStripMenuItem.Name = "displayTheRoominventoryxmlFileInAWebBrowserWindowToolStripMenuItem";
            this.displayTheRoominventoryxmlFileInAWebBrowserWindowToolStripMenuItem.Size = new System.Drawing.Size(392, 22);
            this.displayTheRoominventoryxmlFileInAWebBrowserWindowToolStripMenuItem.Text = "Display the roominventory.xml file in a web browser window";
            this.displayTheRoominventoryxmlFileInAWebBrowserWindowToolStripMenuItem.Click += new System.EventHandler(this.displayTheRoominventoryxmlFileInAWebBrowserWindowToolStripMenuItem_Click);
            // 
            // btnLoadHotelFile
            // 
            this.btnLoadHotelFile.Location = new System.Drawing.Point(163, 110);
            this.btnLoadHotelFile.Name = "btnLoadHotelFile";
            this.btnLoadHotelFile.Size = new System.Drawing.Size(1184, 116);
            this.btnLoadHotelFile.TabIndex = 7;
            this.btnLoadHotelFile.Text = "Load Hotel File (Click this before clicking any other button)";
            this.btnLoadHotelFile.UseVisualStyleBackColor = true;
            this.btnLoadHotelFile.Click += new System.EventHandler(this.btnLoadHotelFile_Click);
            // 
            // btnCreateListOfAllFiles
            // 
            this.btnCreateListOfAllFiles.Location = new System.Drawing.Point(163, 287);
            this.btnCreateListOfAllFiles.Name = "btnCreateListOfAllFiles";
            this.btnCreateListOfAllFiles.Size = new System.Drawing.Size(1184, 116);
            this.btnCreateListOfAllFiles.TabIndex = 8;
            this.btnCreateListOfAllFiles.Text = "Create a list of all files, and display them in a browser";
            this.btnCreateListOfAllFiles.UseVisualStyleBackColor = true;
            this.btnCreateListOfAllFiles.Click += new System.EventHandler(this.btnCreateListOfAllFiles_Click);
            // 
            // btnShowHotelList
            // 
            this.btnShowHotelList.Location = new System.Drawing.Point(163, 436);
            this.btnShowHotelList.Name = "btnShowHotelList";
            this.btnShowHotelList.Size = new System.Drawing.Size(1184, 116);
            this.btnShowHotelList.TabIndex = 10;
            this.btnShowHotelList.Text = "Display entire hotel list in browser";
            this.btnShowHotelList.UseVisualStyleBackColor = true;
            this.btnShowHotelList.Click += new System.EventHandler(this.btnShowHotelList_Click);
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 671);
            this.Controls.Add(this.btnShowHotelList);
            this.Controls.Add(this.btnCreateListOfAllFiles);
            this.Controls.Add(this.btnLoadHotelFile);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Reservations 1.0";
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTheHotelsxmlFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTheHotelxmlFileInAWebBrowserWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTheRoominventoryxmlFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTheRoominventoryxmlFileInAWebBrowserWindowToolStripMenuItem;
        private System.Windows.Forms.Button btnLoadHotelFile;
        private System.Windows.Forms.Button btnCreateListOfAllFiles;
        private System.Windows.Forms.Button btnShowHotelList;
    }
}

