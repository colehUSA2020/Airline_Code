namespace Vande_Ven_Airline_System_GUI
{
    partial class HomeScreen
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
            this.welcomeGroupBox = new System.Windows.Forms.GroupBox();
            this.lookupReservationButton = new System.Windows.Forms.Button();
            this.createCustomerButton = new System.Windows.Forms.Button();
            this.bookReservationButton = new System.Windows.Forms.Button();
            this.homeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookupCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeGroupBox.SuspendLayout();
            this.homeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeGroupBox
            // 
            this.welcomeGroupBox.Controls.Add(this.lookupReservationButton);
            this.welcomeGroupBox.Controls.Add(this.createCustomerButton);
            this.welcomeGroupBox.Controls.Add(this.bookReservationButton);
            this.welcomeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeGroupBox.Location = new System.Drawing.Point(150, 118);
            this.welcomeGroupBox.Name = "welcomeGroupBox";
            this.welcomeGroupBox.Size = new System.Drawing.Size(183, 153);
            this.welcomeGroupBox.TabIndex = 8;
            this.welcomeGroupBox.TabStop = false;
            this.welcomeGroupBox.Text = "Welcome";
            // 
            // lookupReservationButton
            // 
            this.lookupReservationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lookupReservationButton.AutoSize = true;
            this.lookupReservationButton.BackColor = System.Drawing.Color.DimGray;
            this.lookupReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lookupReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupReservationButton.ForeColor = System.Drawing.Color.White;
            this.lookupReservationButton.Location = new System.Drawing.Point(6, 64);
            this.lookupReservationButton.Name = "lookupReservationButton";
            this.lookupReservationButton.Size = new System.Drawing.Size(171, 37);
            this.lookupReservationButton.TabIndex = 6;
            this.lookupReservationButton.Text = "Lookup Reservation";
            this.lookupReservationButton.UseVisualStyleBackColor = false;
            this.lookupReservationButton.Click += new System.EventHandler(this.LookupReservationButton_Click);
            // 
            // createCustomerButton
            // 
            this.createCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createCustomerButton.AutoSize = true;
            this.createCustomerButton.BackColor = System.Drawing.Color.DimGray;
            this.createCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCustomerButton.ForeColor = System.Drawing.Color.White;
            this.createCustomerButton.Location = new System.Drawing.Point(6, 21);
            this.createCustomerButton.Name = "createCustomerButton";
            this.createCustomerButton.Size = new System.Drawing.Size(171, 37);
            this.createCustomerButton.TabIndex = 4;
            this.createCustomerButton.Text = "Create Customer";
            this.createCustomerButton.UseVisualStyleBackColor = false;
            this.createCustomerButton.Click += new System.EventHandler(this.CreateCustomerButton_Click);
            // 
            // bookReservationButton
            // 
            this.bookReservationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookReservationButton.AutoSize = true;
            this.bookReservationButton.BackColor = System.Drawing.Color.DimGray;
            this.bookReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookReservationButton.ForeColor = System.Drawing.Color.White;
            this.bookReservationButton.Location = new System.Drawing.Point(6, 107);
            this.bookReservationButton.Name = "bookReservationButton";
            this.bookReservationButton.Size = new System.Drawing.Size(171, 37);
            this.bookReservationButton.TabIndex = 7;
            this.bookReservationButton.Text = "Book Reservation";
            this.bookReservationButton.UseVisualStyleBackColor = false;
            this.bookReservationButton.Click += new System.EventHandler(this.BookReservationButton_Click);
            // 
            // homeMenuStrip
            // 
            this.homeMenuStrip.BackColor = System.Drawing.Color.DimGray;
            this.homeMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.homeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.homeMenuStrip.Name = "homeMenuStrip";
            this.homeMenuStrip.Size = new System.Drawing.Size(484, 26);
            this.homeMenuStrip.TabIndex = 9;
            this.homeMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerToolStripMenuItem,
            this.lookupCustomerToolStripMenuItem,
            this.bookReservationToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // createCustomerToolStripMenuItem
            // 
            this.createCustomerToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
            this.createCustomerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.createCustomerToolStripMenuItem.Text = "Create Customer";
            this.createCustomerToolStripMenuItem.Click += new System.EventHandler(this.CreateCustomerToolStripMenuItem_Click);
            // 
            // lookupCustomerToolStripMenuItem
            // 
            this.lookupCustomerToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.lookupCustomerToolStripMenuItem.Name = "lookupCustomerToolStripMenuItem";
            this.lookupCustomerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.lookupCustomerToolStripMenuItem.Text = "Lookup Customer";
            // 
            // bookReservationToolStripMenuItem
            // 
            this.bookReservationToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.bookReservationToolStripMenuItem.Name = "bookReservationToolStripMenuItem";
            this.bookReservationToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.bookReservationToolStripMenuItem.Text = "Book Reservation";
            this.bookReservationToolStripMenuItem.Click += new System.EventHandler(this.BookReservationToolStripMenuItem_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(484, 417);
            this.Controls.Add(this.welcomeGroupBox);
            this.Controls.Add(this.homeMenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(500, 456);
            this.MinimumSize = new System.Drawing.Size(500, 456);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vande Ven Air Shuttle System";
            this.welcomeGroupBox.ResumeLayout(false);
            this.welcomeGroupBox.PerformLayout();
            this.homeMenuStrip.ResumeLayout(false);
            this.homeMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox welcomeGroupBox;
        private System.Windows.Forms.Button createCustomerButton;
        private System.Windows.Forms.Button bookReservationButton;
        private System.Windows.Forms.Button lookupReservationButton;
        private System.Windows.Forms.MenuStrip homeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookupCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReservationToolStripMenuItem;
    }
}

