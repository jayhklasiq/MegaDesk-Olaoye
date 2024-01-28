namespace MegaDesk_Olaoye
{
    partial class AddQuote
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
            this.ReturnToHome = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.Label();
            this.CustName = new System.Windows.Forms.TextBox();
            this.DeskWidth = new System.Windows.Forms.Label();
            this.DeskDepth = new System.Windows.Forms.Label();
            this.NumberOfDrawer = new System.Windows.Forms.Label();
            this.DesktopSurfaceMaterial = new System.Windows.Forms.Label();
            this.RushOrderDays = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.QuoteDate = new System.Windows.Forms.Label();
            this.SubmitQuote = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.drawerNum = new System.Windows.Forms.NumericUpDown();
            this.surfaceMaterial = new System.Windows.Forms.ComboBox();
            this.rushDays = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnToHome
            // 
            this.ReturnToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToHome.Location = new System.Drawing.Point(392, 289);
            this.ReturnToHome.Name = "ReturnToHome";
            this.ReturnToHome.Size = new System.Drawing.Size(80, 60);
            this.ReturnToHome.TabIndex = 0;
            this.ReturnToHome.Text = "Return to Home";
            this.ReturnToHome.UseVisualStyleBackColor = true;
            this.ReturnToHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(13, 13);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(192, 23);
            this.CustomerName.TabIndex = 1;
            this.CustomerName.Text = "Full Name (First & Last Only)";
            // 
            // CustName
            // 
            this.CustName.BackColor = System.Drawing.SystemColors.Window;
            this.CustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.Location = new System.Drawing.Point(222, 12);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(250, 26);
            this.CustName.TabIndex = 2;
            this.CustName.TextChanged += new System.EventHandler(this.CustName_TextChanged);
            // 
            // DeskWidth
            // 
            this.DeskWidth.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidth.Location = new System.Drawing.Point(13, 54);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(192, 23);
            this.DeskWidth.TabIndex = 3;
            this.DeskWidth.Text = "Desk Width (inch only)";
            this.DeskWidth.Click += new System.EventHandler(this.label1_Click);
            // 
            // DeskDepth
            // 
            this.DeskDepth.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepth.Location = new System.Drawing.Point(13, 95);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(192, 23);
            this.DeskDepth.TabIndex = 5;
            this.DeskDepth.Text = "Desk Depth (inch only)";
            // 
            // NumberOfDrawer
            // 
            this.NumberOfDrawer.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDrawer.Location = new System.Drawing.Point(13, 136);
            this.NumberOfDrawer.Name = "NumberOfDrawer";
            this.NumberOfDrawer.Size = new System.Drawing.Size(192, 23);
            this.NumberOfDrawer.TabIndex = 7;
            this.NumberOfDrawer.Text = "Number of Drawer (max = 7)";
            // 
            // DesktopSurfaceMaterial
            // 
            this.DesktopSurfaceMaterial.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesktopSurfaceMaterial.Location = new System.Drawing.Point(13, 177);
            this.DesktopSurfaceMaterial.Name = "DesktopSurfaceMaterial";
            this.DesktopSurfaceMaterial.Size = new System.Drawing.Size(192, 23);
            this.DesktopSurfaceMaterial.TabIndex = 9;
            this.DesktopSurfaceMaterial.Text = "Surface Material";
            // 
            // RushOrderDays
            // 
            this.RushOrderDays.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderDays.Location = new System.Drawing.Point(13, 215);
            this.RushOrderDays.Name = "RushOrderDays";
            this.RushOrderDays.Size = new System.Drawing.Size(192, 23);
            this.RushOrderDays.TabIndex = 11;
            this.RushOrderDays.Text = "Rush Order";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(222, 258);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(250, 22);
            this.date.TabIndex = 14;
            this.date.Value = new System.DateTime(2024, 1, 26, 19, 53, 35, 0);
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // QuoteDate
            // 
            this.QuoteDate.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteDate.Location = new System.Drawing.Point(12, 262);
            this.QuoteDate.Name = "QuoteDate";
            this.QuoteDate.Size = new System.Drawing.Size(192, 23);
            this.QuoteDate.TabIndex = 15;
            this.QuoteDate.Text = "Date of Quote";
            // 
            // SubmitQuote
            // 
            this.SubmitQuote.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitQuote.Location = new System.Drawing.Point(105, 304);
            this.SubmitQuote.Name = "SubmitQuote";
            this.SubmitQuote.Size = new System.Drawing.Size(145, 45);
            this.SubmitQuote.TabIndex = 16;
            this.SubmitQuote.Text = "Submit Quote";
            this.SubmitQuote.UseVisualStyleBackColor = true;
            this.SubmitQuote.Click += new System.EventHandler(this.SubmitQuote_Click);
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(222, 54);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(249, 23);
            this.width.TabIndex = 17;
            this.width.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            this.width.Validated += new System.EventHandler(this.width_ValueChanged);
            // 
            // depth
            // 
            this.depth.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.Location = new System.Drawing.Point(223, 95);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(249, 23);
            this.depth.TabIndex = 18;
            this.depth.ValueChanged += new System.EventHandler(this.depth_ValueChanged);
            // 
            // drawerNum
            // 
            this.drawerNum.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerNum.Location = new System.Drawing.Point(223, 136);
            this.drawerNum.Name = "drawerNum";
            this.drawerNum.Size = new System.Drawing.Size(249, 23);
            this.drawerNum.TabIndex = 19;
            this.drawerNum.ValueChanged += new System.EventHandler(this.drawerNum_ValueChanged);
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterial.FormattingEnabled = true;
            this.surfaceMaterial.Location = new System.Drawing.Point(223, 179);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(249, 24);
            this.surfaceMaterial.TabIndex = 20;
            this.surfaceMaterial.SelectedIndexChanged += new System.EventHandler(this.surfaceMaterial_SelectedIndexChanged_1);
            // 
            // rushDays
            // 
            this.rushDays.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDays.FormattingEnabled = true;
            this.rushDays.Location = new System.Drawing.Point(222, 215);
            this.rushDays.Name = "rushDays";
            this.rushDays.Size = new System.Drawing.Size(249, 24);
            this.rushDays.TabIndex = 21;
            this.rushDays.SelectedIndexChanged += new System.EventHandler(this.rushDays_SelectedIndexChanged_1);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.rushDays);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.drawerNum);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.SubmitQuote);
            this.Controls.Add(this.QuoteDate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.RushOrderDays);
            this.Controls.Add(this.DesktopSurfaceMaterial);
            this.Controls.Add(this.NumberOfDrawer);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.ReturnToHome);
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnToHome;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Label DeskWidth;
        private System.Windows.Forms.Label DeskDepth;
        private System.Windows.Forms.Label NumberOfDrawer;
        private System.Windows.Forms.Label DesktopSurfaceMaterial;
        private System.Windows.Forms.Label RushOrderDays;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label QuoteDate;
        private System.Windows.Forms.Button SubmitQuote;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.NumericUpDown drawerNum;
        private System.Windows.Forms.ComboBox surfaceMaterial;
        private System.Windows.Forms.ComboBox rushDays;
    }
}