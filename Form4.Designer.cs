namespace MegaDesk_Olaoye
{
    partial class ViewAllQuotes
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
            this.SuspendLayout();
            // 
            // ReturnToHome
            // 
            this.ReturnToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToHome.Location = new System.Drawing.Point(392, 289);
            this.ReturnToHome.Name = "ReturnToHome";
            this.ReturnToHome.Size = new System.Drawing.Size(80, 60);
            this.ReturnToHome.TabIndex = 1;
            this.ReturnToHome.Text = "Return to Home";
            this.ReturnToHome.UseVisualStyleBackColor = true;
            this.ReturnToHome.Click += new System.EventHandler(this.ReturnToHome_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.ReturnToHome);
            this.MaximizeBox = false;
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnToHome;
    }
}