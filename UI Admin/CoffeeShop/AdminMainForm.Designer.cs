namespace CoffeeShop
{
    partial class AdminMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnTransaction = new System.Windows.Forms.Button();
            this.BtnInventoryReport = new System.Windows.Forms.Button();
            this.BtnSalesReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 89);
            this.panel1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(597, 32);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(106, 16);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date And Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back, Admin";
            // 
            // BtnInventory
            // 
            this.BtnInventory.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventory.ForeColor = System.Drawing.Color.White;
            this.BtnInventory.Location = new System.Drawing.Point(43, 189);
            this.BtnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(203, 112);
            this.BtnInventory.TabIndex = 3;
            this.BtnInventory.Text = "Inventory ";
            this.BtnInventory.UseVisualStyleBackColor = false;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "What Would You Like to Manage Today";
            // 
            // BtnUser
            // 
            this.BtnUser.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUser.ForeColor = System.Drawing.Color.White;
            this.BtnUser.Location = new System.Drawing.Point(301, 189);
            this.BtnUser.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(203, 112);
            this.BtnUser.TabIndex = 5;
            this.BtnUser.Text = "User";
            this.BtnUser.UseVisualStyleBackColor = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Location = new System.Drawing.Point(547, 189);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(203, 112);
            this.BtnMenu.TabIndex = 6;
            this.BtnMenu.Text = "Menu Items";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnTransaction
            // 
            this.BtnTransaction.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnTransaction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransaction.ForeColor = System.Drawing.Color.White;
            this.BtnTransaction.Location = new System.Drawing.Point(43, 337);
            this.BtnTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTransaction.Name = "BtnTransaction";
            this.BtnTransaction.Size = new System.Drawing.Size(203, 112);
            this.BtnTransaction.TabIndex = 7;
            this.BtnTransaction.Text = "Transaction";
            this.BtnTransaction.UseVisualStyleBackColor = false;
            this.BtnTransaction.Click += new System.EventHandler(this.BtnTransaction_Click);
            // 
            // BtnInventoryReport
            // 
            this.BtnInventoryReport.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnInventoryReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventoryReport.ForeColor = System.Drawing.Color.White;
            this.BtnInventoryReport.Location = new System.Drawing.Point(301, 337);
            this.BtnInventoryReport.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInventoryReport.Name = "BtnInventoryReport";
            this.BtnInventoryReport.Size = new System.Drawing.Size(203, 112);
            this.BtnInventoryReport.TabIndex = 8;
            this.BtnInventoryReport.Text = "Inventory Report";
            this.BtnInventoryReport.UseVisualStyleBackColor = false;
            this.BtnInventoryReport.Click += new System.EventHandler(this.BtnInventoryReport_Click);
            // 
            // BtnSalesReport
            // 
            this.BtnSalesReport.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnSalesReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalesReport.ForeColor = System.Drawing.Color.White;
            this.BtnSalesReport.Location = new System.Drawing.Point(547, 337);
            this.BtnSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalesReport.Name = "BtnSalesReport";
            this.BtnSalesReport.Size = new System.Drawing.Size(203, 112);
            this.BtnSalesReport.TabIndex = 9;
            this.BtnSalesReport.Text = "Sales Report";
            this.BtnSalesReport.UseVisualStyleBackColor = false;
            this.BtnSalesReport.Click += new System.EventHandler(this.BtnSalesReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(669, 477);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(81, 31);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(791, 535);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.BtnSalesReport);
            this.Controls.Add(this.BtnInventoryReport);
            this.Controls.Add(this.BtnTransaction);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnTransaction;
        private System.Windows.Forms.Button BtnInventoryReport;
        private System.Windows.Forms.Button BtnSalesReport;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timer1;
    }
}