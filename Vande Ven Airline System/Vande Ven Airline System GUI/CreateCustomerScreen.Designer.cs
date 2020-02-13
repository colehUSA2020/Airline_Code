namespace Vande_Ven_Airline_System_GUI
{
    partial class CreateCustomerScreen
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDBDataSet = new Vande_Ven_Airline_System_GUI.AirlineDBDataSet();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.customerSubmitButton = new System.Windows.Forms.Button();
            this.customerGroupBox1 = new System.Windows.Forms.GroupBox();
            this.customerGroupBox2 = new System.Windows.Forms.GroupBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.creditCardTextBox = new System.Windows.Forms.TextBox();
            this.creditCardlabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.stateListBox = new System.Windows.Forms.ListBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.homeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerTableAdapter = new Vande_Ven_Airline_System_GUI.AirlineDBDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Vande_Ven_Airline_System_GUI.AirlineDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet)).BeginInit();
            this.customerGroupBox1.SuspendLayout();
            this.customerGroupBox2.SuspendLayout();
            this.homeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 18);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(6, 37);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 1;
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
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(118, 18);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(121, 37);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // customerSubmitButton
            // 
            this.customerSubmitButton.BackColor = System.Drawing.Color.ForestGreen;
            this.customerSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSubmitButton.ForeColor = System.Drawing.Color.White;
            this.customerSubmitButton.Location = new System.Drawing.Point(351, 343);
            this.customerSubmitButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.customerSubmitButton.Name = "customerSubmitButton";
            this.customerSubmitButton.Size = new System.Drawing.Size(115, 37);
            this.customerSubmitButton.TabIndex = 14;
            this.customerSubmitButton.Text = "Submit";
            this.customerSubmitButton.UseVisualStyleBackColor = false;
            this.customerSubmitButton.Click += new System.EventHandler(this.CustomerSubmitButton_Click);
            // 
            // customerGroupBox1
            // 
            this.customerGroupBox1.Controls.Add(this.firstNameLabel);
            this.customerGroupBox1.Controls.Add(this.firstNameTextBox);
            this.customerGroupBox1.Controls.Add(this.lastNameLabel);
            this.customerGroupBox1.Controls.Add(this.lastNameTextBox);
            this.customerGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGroupBox1.Location = new System.Drawing.Point(10, 27);
            this.customerGroupBox1.Name = "customerGroupBox1";
            this.customerGroupBox1.Size = new System.Drawing.Size(265, 75);
            this.customerGroupBox1.TabIndex = 15;
            this.customerGroupBox1.TabStop = false;
            // 
            // customerGroupBox2
            // 
            this.customerGroupBox2.Controls.Add(this.zipCodeTextBox);
            this.customerGroupBox2.Controls.Add(this.zipCodeLabel);
            this.customerGroupBox2.Controls.Add(this.creditCardTextBox);
            this.customerGroupBox2.Controls.Add(this.creditCardlabel);
            this.customerGroupBox2.Controls.Add(this.phoneTextBox);
            this.customerGroupBox2.Controls.Add(this.phoneLabel);
            this.customerGroupBox2.Controls.Add(this.stateListBox);
            this.customerGroupBox2.Controls.Add(this.stateLabel);
            this.customerGroupBox2.Controls.Add(this.cityTextBox);
            this.customerGroupBox2.Controls.Add(this.cityLabel);
            this.customerGroupBox2.Controls.Add(this.addressTextBox);
            this.customerGroupBox2.Controls.Add(this.addressLabel);
            this.customerGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGroupBox2.Location = new System.Drawing.Point(10, 108);
            this.customerGroupBox2.Name = "customerGroupBox2";
            this.customerGroupBox2.Size = new System.Drawing.Size(460, 230);
            this.customerGroupBox2.TabIndex = 16;
            this.customerGroupBox2.TabStop = false;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(9, 143);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(97, 20);
            this.zipCodeTextBox.TabIndex = 25;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeLabel.Location = new System.Drawing.Point(6, 125);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(50, 13);
            this.zipCodeLabel.TabIndex = 24;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // creditCardTextBox
            // 
            this.creditCardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CCNumber", true));
            this.creditCardTextBox.Location = new System.Drawing.Point(286, 143);
            this.creditCardTextBox.Name = "creditCardTextBox";
            this.creditCardTextBox.Size = new System.Drawing.Size(141, 20);
            this.creditCardTextBox.TabIndex = 23;
            // 
            // creditCardlabel
            // 
            this.creditCardlabel.AutoSize = true;
            this.creditCardlabel.Location = new System.Drawing.Point(283, 125);
            this.creditCardlabel.Name = "creditCardlabel";
            this.creditCardlabel.Size = new System.Drawing.Size(99, 13);
            this.creditCardlabel.TabIndex = 22;
            this.creditCardlabel.Text = "Credit Card Number";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PhoneNumber", true));
            this.phoneTextBox.Location = new System.Drawing.Point(286, 83);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(118, 20);
            this.phoneTextBox.TabIndex = 21;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(283, 65);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneLabel.TabIndex = 20;
            this.phoneLabel.Text = "Phone Number";
            // 
            // stateListBox
            // 
            this.stateListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "State", true));
            this.stateListBox.FormattingEnabled = true;
            this.stateListBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateListBox.Location = new System.Drawing.Point(121, 83);
            this.stateListBox.Name = "stateListBox";
            this.stateListBox.Size = new System.Drawing.Size(120, 82);
            this.stateListBox.TabIndex = 19;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(118, 65);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(32, 13);
            this.stateLabel.TabIndex = 18;
            this.stateLabel.Text = "State";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(9, 83);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(97, 20);
            this.cityTextBox.TabIndex = 17;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(6, 65);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 16;
            this.cityLabel.Text = "City";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Street", true));
            this.addressTextBox.Location = new System.Drawing.Point(6, 28);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(421, 20);
            this.addressTextBox.TabIndex = 15;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(6, 9);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(73, 13);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "StreetAddress";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Firebrick;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(216, 343);
            this.backButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 37);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Home";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.HomeButton_Click);
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
            this.homeMenuStrip.TabIndex = 18;
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
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.ReservationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vande_Ven_Airline_System_GUI.AirlineDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CreateCustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(484, 417);
            this.Controls.Add(this.homeMenuStrip);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.customerGroupBox2);
            this.Controls.Add(this.customerGroupBox1);
            this.Controls.Add(this.customerSubmitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(500, 456);
            this.MinimumSize = new System.Drawing.Size(500, 456);
            this.Name = "CreateCustomerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Customer Menu";
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet)).EndInit();
            this.customerGroupBox1.ResumeLayout(false);
            this.customerGroupBox1.PerformLayout();
            this.customerGroupBox2.ResumeLayout(false);
            this.customerGroupBox2.PerformLayout();
            this.homeMenuStrip.ResumeLayout(false);
            this.homeMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button customerSubmitButton;
        private System.Windows.Forms.GroupBox customerGroupBox1;
        private System.Windows.Forms.GroupBox customerGroupBox2;
        private System.Windows.Forms.TextBox creditCardTextBox;
        private System.Windows.Forms.Label creditCardlabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.ListBox stateListBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.MenuStrip homeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private AirlineDBDataSet airlineDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private AirlineDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private AirlineDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    }
}