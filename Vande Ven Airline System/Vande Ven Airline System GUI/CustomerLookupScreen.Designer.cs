namespace Vande_Ven_Airline_System_GUI
{
    partial class CustomerLookupScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customer_ID_Radio_Button = new System.Windows.Forms.RadioButton();
            this.customer_Lookup_Group_Box = new System.Windows.Forms.GroupBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.zipGroupBox = new System.Windows.Forms.GroupBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.credit_Card_Radio_Button = new System.Windows.Forms.RadioButton();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reservation_ID_Radio_Button = new System.Windows.Forms.RadioButton();
            this.customerSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.homeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDBDataSet = new Vande_Ven_Airline_System_GUI.AirlineDBDataSet();
            this.customerTableAdapter = new Vande_Ven_Airline_System_GUI.AirlineDBDataSetTableAdapters.CustomerTableAdapter();
            this.customer_Lookup_Group_Box.SuspendLayout();
            this.zipGroupBox.SuspendLayout();
            this.nameGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.homeMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_ID_Radio_Button
            // 
            this.customer_ID_Radio_Button.AutoSize = true;
            this.customer_ID_Radio_Button.Location = new System.Drawing.Point(6, 22);
            this.customer_ID_Radio_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customer_ID_Radio_Button.Name = "customer_ID_Radio_Button";
            this.customer_ID_Radio_Button.Size = new System.Drawing.Size(120, 17);
            this.customer_ID_Radio_Button.TabIndex = 0;
            this.customer_ID_Radio_Button.TabStop = true;
            this.customer_ID_Radio_Button.Text = "Search Customer ID";
            this.customer_ID_Radio_Button.UseVisualStyleBackColor = true;
            this.customer_ID_Radio_Button.CheckedChanged += new System.EventHandler(this.Customer_ID_Radio_Button_CheckedChanged);
            // 
            // customer_Lookup_Group_Box
            // 
            this.customer_Lookup_Group_Box.Controls.Add(this.showAllButton);
            this.customer_Lookup_Group_Box.Controls.Add(this.zipGroupBox);
            this.customer_Lookup_Group_Box.Controls.Add(this.credit_Card_Radio_Button);
            this.customer_Lookup_Group_Box.Controls.Add(this.nameGroupBox);
            this.customer_Lookup_Group_Box.Controls.Add(this.reservation_ID_Radio_Button);
            this.customer_Lookup_Group_Box.Controls.Add(this.customer_ID_Radio_Button);
            this.customer_Lookup_Group_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_Lookup_Group_Box.Location = new System.Drawing.Point(12, 31);
            this.customer_Lookup_Group_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customer_Lookup_Group_Box.Name = "customer_Lookup_Group_Box";
            this.customer_Lookup_Group_Box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customer_Lookup_Group_Box.Size = new System.Drawing.Size(460, 187);
            this.customer_Lookup_Group_Box.TabIndex = 1;
            this.customer_Lookup_Group_Box.TabStop = false;
            this.customer_Lookup_Group_Box.Text = "Search Method";
            // 
            // showAllButton
            // 
            this.showAllButton.BackColor = System.Drawing.Color.DimGray;
            this.showAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllButton.ForeColor = System.Drawing.Color.White;
            this.showAllButton.Location = new System.Drawing.Point(6, 143);
            this.showAllButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(115, 37);
            this.showAllButton.TabIndex = 23;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // zipGroupBox
            // 
            this.zipGroupBox.Controls.Add(this.zipCodeTextBox);
            this.zipGroupBox.Controls.Add(this.zipLabel);
            this.zipGroupBox.Location = new System.Drawing.Point(253, 128);
            this.zipGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zipGroupBox.Name = "zipGroupBox";
            this.zipGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zipGroupBox.Size = new System.Drawing.Size(200, 52);
            this.zipGroupBox.TabIndex = 22;
            this.zipGroupBox.TabStop = false;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(70, 19);
            this.zipCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(115, 20);
            this.zipCodeTextBox.TabIndex = 6;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(14, 18);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(50, 13);
            this.zipLabel.TabIndex = 4;
            this.zipLabel.Text = "Zip Code";
            // 
            // credit_Card_Radio_Button
            // 
            this.credit_Card_Radio_Button.AutoSize = true;
            this.credit_Card_Radio_Button.Location = new System.Drawing.Point(253, 22);
            this.credit_Card_Radio_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.credit_Card_Radio_Button.Name = "credit_Card_Radio_Button";
            this.credit_Card_Radio_Button.Size = new System.Drawing.Size(154, 17);
            this.credit_Card_Radio_Button.TabIndex = 21;
            this.credit_Card_Radio_Button.TabStop = true;
            this.credit_Card_Radio_Button.Text = "Search Credit Card Number";
            this.credit_Card_Radio_Button.UseVisualStyleBackColor = true;
            this.credit_Card_Radio_Button.CheckedChanged += new System.EventHandler(this.Credit_Card_Radio_Button_CheckedChanged);
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.label1);
            this.nameGroupBox.Controls.Add(this.lastNameTextBox);
            this.nameGroupBox.Controls.Add(this.firstNameTextBox);
            this.nameGroupBox.Controls.Add(this.label2);
            this.nameGroupBox.Location = new System.Drawing.Point(253, 47);
            this.nameGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameGroupBox.Size = new System.Drawing.Size(200, 72);
            this.nameGroupBox.TabIndex = 20;
            this.nameGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(70, 45);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(70, 15);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // reservation_ID_Radio_Button
            // 
            this.reservation_ID_Radio_Button.AutoSize = true;
            this.reservation_ID_Radio_Button.Location = new System.Drawing.Point(6, 47);
            this.reservation_ID_Radio_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reservation_ID_Radio_Button.Name = "reservation_ID_Radio_Button";
            this.reservation_ID_Radio_Button.Size = new System.Drawing.Size(133, 17);
            this.reservation_ID_Radio_Button.TabIndex = 1;
            this.reservation_ID_Radio_Button.TabStop = true;
            this.reservation_ID_Radio_Button.Text = "Search Reservation ID";
            this.reservation_ID_Radio_Button.UseVisualStyleBackColor = true;
            this.reservation_ID_Radio_Button.CheckedChanged += new System.EventHandler(this.Reservation_ID_Radio_Button_CheckedChanged);
            // 
            // customerSearchTextBox
            // 
            this.customerSearchTextBox.Location = new System.Drawing.Point(6, 30);
            this.customerSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerSearchTextBox.Name = "customerSearchTextBox";
            this.customerSearchTextBox.Size = new System.Drawing.Size(229, 20);
            this.customerSearchTextBox.TabIndex = 2;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.customerSearchTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 224);
            this.searchGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchGroupBox.Size = new System.Drawing.Size(372, 71);
            this.searchGroupBox.TabIndex = 3;
            this.searchGroupBox.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.ForestGreen;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(241, 21);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(115, 37);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.CustomerSearchButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Firebrick;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(757, 569);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(115, 37);
            this.homeButton.TabIndex = 19;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
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
            this.homeMenuStrip.Size = new System.Drawing.Size(884, 26);
            this.homeMenuStrip.TabIndex = 22;
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
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.searchDataGridView.Location = new System.Drawing.Point(12, 302);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.searchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataGridView.Size = new System.Drawing.Size(860, 253);
            this.searchDataGridView.TabIndex = 23;
            this.searchDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchDataGridView_CellDoubleClick);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.airlineDBDataSet;
            // 
            // airlineDBDataSet
            // 
            this.airlineDBDataSet.DataSetName = "AirlineDBDataSet";
            this.airlineDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerLookupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.homeMenuStrip);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.customer_Lookup_Group_Box);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "CustomerLookupScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Lookup Menu";
            this.customer_Lookup_Group_Box.ResumeLayout(false);
            this.customer_Lookup_Group_Box.PerformLayout();
            this.zipGroupBox.ResumeLayout(false);
            this.zipGroupBox.PerformLayout();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.homeMenuStrip.ResumeLayout(false);
            this.homeMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton customer_ID_Radio_Button;
        private System.Windows.Forms.GroupBox customer_Lookup_Group_Box;
        private System.Windows.Forms.RadioButton reservation_ID_Radio_Button;
        private System.Windows.Forms.TextBox customerSearchTextBox;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton credit_Card_Radio_Button;
        private System.Windows.Forms.GroupBox zipGroupBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.MenuStrip homeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private AirlineDBDataSet airlineDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private AirlineDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    }
}