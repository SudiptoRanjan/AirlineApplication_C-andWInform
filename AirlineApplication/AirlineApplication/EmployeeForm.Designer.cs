namespace AirlineApplication
{
    partial class EmployeeForm
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.viewAirportBtn = new System.Windows.Forms.Button();
            this.viewAirplanesBtn = new System.Windows.Forms.Button();
            this.empSearchBtn = new System.Windows.Forms.Button();
            this.employeeSearchTextBox = new System.Windows.Forms.TextBox();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.viewPassengers = new System.Windows.Forms.Button();
            this.viewFlights = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(48, 415);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 42);
            this.logoutBtn.TabIndex = 40;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // viewAirportBtn
            // 
            this.viewAirportBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAirportBtn.Location = new System.Drawing.Point(24, 263);
            this.viewAirportBtn.Name = "viewAirportBtn";
            this.viewAirportBtn.Size = new System.Drawing.Size(99, 48);
            this.viewAirportBtn.TabIndex = 39;
            this.viewAirportBtn.Text = "View Airports";
            this.viewAirportBtn.UseVisualStyleBackColor = true;
            this.viewAirportBtn.Click += new System.EventHandler(this.viewAirportBtn_Click);
            // 
            // viewAirplanesBtn
            // 
            this.viewAirplanesBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAirplanesBtn.Location = new System.Drawing.Point(24, 206);
            this.viewAirplanesBtn.Name = "viewAirplanesBtn";
            this.viewAirplanesBtn.Size = new System.Drawing.Size(99, 44);
            this.viewAirplanesBtn.TabIndex = 38;
            this.viewAirplanesBtn.Text = "View Airplanes";
            this.viewAirplanesBtn.UseVisualStyleBackColor = true;
            this.viewAirplanesBtn.Click += new System.EventHandler(this.viewAirplanesBtn_Click);
            // 
            // empSearchBtn
            // 
            this.empSearchBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empSearchBtn.Location = new System.Drawing.Point(257, 29);
            this.empSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.empSearchBtn.Name = "empSearchBtn";
            this.empSearchBtn.Size = new System.Drawing.Size(91, 30);
            this.empSearchBtn.TabIndex = 37;
            this.empSearchBtn.Text = "Search";
            this.empSearchBtn.UseVisualStyleBackColor = true;
            this.empSearchBtn.Click += new System.EventHandler(this.empSearchBtn_Click);
            // 
            // employeeSearchTextBox
            // 
            this.employeeSearchTextBox.Location = new System.Drawing.Point(471, 35);
            this.employeeSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeSearchTextBox.Name = "employeeSearchTextBox";
            this.employeeSearchTextBox.Size = new System.Drawing.Size(123, 20);
            this.employeeSearchTextBox.TabIndex = 36;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Items.AddRange(new object[] {
            "Flight",
            "Airplanes",
            "Airport",
            "Passengers"});
            this.employeeComboBox.Location = new System.Drawing.Point(361, 35);
            this.employeeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(82, 21);
            this.employeeComboBox.TabIndex = 35;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(163, 78);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(653, 380);
            this.dataGridView2.TabIndex = 34;
            // 
            // viewPassengers
            // 
            this.viewPassengers.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPassengers.Location = new System.Drawing.Point(24, 146);
            this.viewPassengers.Name = "viewPassengers";
            this.viewPassengers.Size = new System.Drawing.Size(99, 53);
            this.viewPassengers.TabIndex = 32;
            this.viewPassengers.Text = "View Passengers";
            this.viewPassengers.UseVisualStyleBackColor = true;
            this.viewPassengers.Click += new System.EventHandler(this.viewPassengers_Click);
            // 
            // viewFlights
            // 
            this.viewFlights.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFlights.Location = new System.Drawing.Point(24, 78);
            this.viewFlights.Name = "viewFlights";
            this.viewFlights.Size = new System.Drawing.Size(99, 49);
            this.viewFlights.TabIndex = 31;
            this.viewFlights.Text = "View Flights";
            this.viewFlights.UseVisualStyleBackColor = true;
            this.viewFlights.Click += new System.EventHandler(this.viewFlights_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(841, 487);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.viewAirportBtn);
            this.Controls.Add(this.viewAirplanesBtn);
            this.Controls.Add(this.empSearchBtn);
            this.Controls.Add(this.employeeSearchTextBox);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.viewPassengers);
            this.Controls.Add(this.viewFlights);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button viewAirportBtn;
        private System.Windows.Forms.Button viewAirplanesBtn;
        private System.Windows.Forms.Button empSearchBtn;
        private System.Windows.Forms.TextBox employeeSearchTextBox;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button viewPassengers;
        private System.Windows.Forms.Button viewFlights;
    }
}