namespace jlu119_PRG455D_FP
{
    partial class mainFrm
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
            this.depctyLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.makePurchaseBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchFlightBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.depCityCmb = new System.Windows.Forms.ComboBox();
            this.desCityCmb = new System.Windows.Forms.ComboBox();
            this.depDateCmb = new System.Windows.Forms.ComboBox();
            this.sqlFlightGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMainBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.helpFlightsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.helpPurchaseBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.helpReceiptsBtn = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sqlFlightGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depctyLbl
            // 
            this.depctyLbl.AutoSize = true;
            this.depctyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depctyLbl.Location = new System.Drawing.Point(330, 86);
            this.depctyLbl.Name = "depctyLbl";
            this.depctyLbl.Size = new System.Drawing.Size(115, 20);
            this.depctyLbl.TabIndex = 2;
            this.depctyLbl.Text = "Departure City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Departure Date:";
            // 
            // makePurchaseBtn
            // 
            this.makePurchaseBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.makePurchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.makePurchaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePurchaseBtn.Location = new System.Drawing.Point(462, 181);
            this.makePurchaseBtn.Name = "makePurchaseBtn";
            this.makePurchaseBtn.Size = new System.Drawing.Size(150, 35);
            this.makePurchaseBtn.TabIndex = 7;
            this.makePurchaseBtn.Text = "Make Purchase";
            this.makePurchaseBtn.UseVisualStyleBackColor = false;
            this.makePurchaseBtn.Click += new System.EventHandler(this.makePurchaseBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(331, 36);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(438, 29);
            this.titleLbl.TabIndex = 12;
            this.titleLbl.Text = "Jiacheng Airline Reservation System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search Results:";
            // 
            // searchFlightBtn
            // 
            this.searchFlightBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchFlightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFlightBtn.Location = new System.Drawing.Point(474, 217);
            this.searchFlightBtn.Name = "searchFlightBtn";
            this.searchFlightBtn.Size = new System.Drawing.Size(150, 35);
            this.searchFlightBtn.TabIndex = 17;
            this.searchFlightBtn.Text = "Search Flights";
            this.searchFlightBtn.UseVisualStyleBackColor = false;
            this.searchFlightBtn.Click += new System.EventHandler(this.searchFlightBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // depCityCmb
            // 
            this.depCityCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depCityCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depCityCmb.FormattingEnabled = true;
            this.depCityCmb.Items.AddRange(new object[] {
            "Calgary International Airport (YYC)",
            "Toronto Pearson International Airport (YYZ)",
            "Vancouver International Airport (YVR)",
            "Winnipeg International Airport (YWG)"});
            this.depCityCmb.Location = new System.Drawing.Point(474, 86);
            this.depCityCmb.Name = "depCityCmb";
            this.depCityCmb.Size = new System.Drawing.Size(293, 24);
            this.depCityCmb.TabIndex = 19;
            // 
            // desCityCmb
            // 
            this.desCityCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desCityCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desCityCmb.FormattingEnabled = true;
            this.desCityCmb.Items.AddRange(new object[] {
            "Calgary International Airport (YYC)",
            "Toronto Pearson International Airport (YYZ)",
            "Vancouver International Airport (YVR)",
            "Winnipeg International Airport (YWG)"});
            this.desCityCmb.Location = new System.Drawing.Point(474, 126);
            this.desCityCmb.Name = "desCityCmb";
            this.desCityCmb.Size = new System.Drawing.Size(293, 24);
            this.desCityCmb.TabIndex = 20;
            // 
            // depDateCmb
            // 
            this.depDateCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depDateCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDateCmb.FormattingEnabled = true;
            this.depDateCmb.Items.AddRange(new object[] {
            "2024-10-12",
            "2024-10-13",
            "2024-10-14"});
            this.depDateCmb.Location = new System.Drawing.Point(474, 166);
            this.depDateCmb.Name = "depDateCmb";
            this.depDateCmb.Size = new System.Drawing.Size(293, 24);
            this.depDateCmb.TabIndex = 21;
            // 
            // sqlFlightGrid
            // 
            this.sqlFlightGrid.AllowUserToAddRows = false;
            this.sqlFlightGrid.AllowUserToDeleteRows = false;
            this.sqlFlightGrid.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.sqlFlightGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlFlightGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqlFlightGrid.Location = new System.Drawing.Point(19, 60);
            this.sqlFlightGrid.Name = "sqlFlightGrid";
            this.sqlFlightGrid.ReadOnly = true;
            this.sqlFlightGrid.Size = new System.Drawing.Size(1043, 105);
            this.sqlFlightGrid.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.makePurchaseBtn);
            this.groupBox1.Controls.Add(this.sqlFlightGrid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1078, 231);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpBtn
            // 
            this.helpBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMainBtn,
            this.helpFlightsBtn,
            this.helpPurchaseBtn,
            this.helpReceiptsBtn});
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(44, 20);
            this.helpBtn.Text = "Help";
            // 
            // helpMainBtn
            // 
            this.helpMainBtn.Name = "helpMainBtn";
            this.helpMainBtn.Size = new System.Drawing.Size(182, 22);
            this.helpMainBtn.Text = "Main Interface";
            this.helpMainBtn.Click += new System.EventHandler(this.helpMainBtn_Click);
            // 
            // helpFlightsBtn
            // 
            this.helpFlightsBtn.Name = "helpFlightsBtn";
            this.helpFlightsBtn.Size = new System.Drawing.Size(182, 22);
            this.helpFlightsBtn.Text = "Searching for Flights";
            this.helpFlightsBtn.Click += new System.EventHandler(this.helpFlightsBtn_Click);
            // 
            // helpPurchaseBtn
            // 
            this.helpPurchaseBtn.Name = "helpPurchaseBtn";
            this.helpPurchaseBtn.Size = new System.Drawing.Size(182, 22);
            this.helpPurchaseBtn.Text = "Making a Purchase";
            this.helpPurchaseBtn.Click += new System.EventHandler(this.helpPurchaseBtn_Click);
            // 
            // helpReceiptsBtn
            // 
            this.helpReceiptsBtn.Name = "helpReceiptsBtn";
            this.helpReceiptsBtn.Size = new System.Drawing.Size(182, 22);
            this.helpReceiptsBtn.Text = "Viewing Receipts";
            this.helpReceiptsBtn.Click += new System.EventHandler(this.helpReceiptsBtn_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 515);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.searchFlightBtn);
            this.Controls.Add(this.depctyLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.depDateCmb);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.depCityCmb);
            this.Controls.Add(this.desCityCmb);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainFrm";
            this.Text = "jlu119 PRG455D FP Airline Reservation System";
            ((System.ComponentModel.ISupportInitialize)(this.sqlFlightGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depctyLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button makePurchaseBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchFlightBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox depCityCmb;
        private System.Windows.Forms.ComboBox desCityCmb;
        private System.Windows.Forms.ComboBox depDateCmb;
        private System.Windows.Forms.DataGridView sqlFlightGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpBtn;
        private System.Windows.Forms.ToolStripMenuItem helpMainBtn;
        private System.Windows.Forms.ToolStripMenuItem helpFlightsBtn;
        private System.Windows.Forms.ToolStripMenuItem helpPurchaseBtn;
        private System.Windows.Forms.ToolStripMenuItem helpReceiptsBtn;
    }
}

