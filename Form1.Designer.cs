namespace MegaDesk_Olaoye
{
    partial class MegaDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MegaDesk));
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.DisplayQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteButton.Location = new System.Drawing.Point(12, 12);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(150, 40);
            this.AddQuoteButton.TabIndex = 0;
            this.AddQuoteButton.Text = "Add &New Quote";
            this.AddQuoteButton.UseVisualStyleBackColor = true;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuote_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(12, 150);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 40);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotes.Location = new System.Drawing.Point(12, 104);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(150, 40);
            this.SearchQuotes.TabIndex = 2;
            this.SearchQuotes.Text = "&Search Quotes";
            this.SearchQuotes.UseVisualStyleBackColor = true;
            this.SearchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // DisplayQuote
            // 
            this.DisplayQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayQuote.Location = new System.Drawing.Point(12, 58);
            this.DisplayQuote.Name = "DisplayQuote";
            this.DisplayQuote.Size = new System.Drawing.Size(150, 40);
            this.DisplayQuote.TabIndex = 3;
            this.DisplayQuote.Text = "&View Quotes";
            this.DisplayQuote.UseVisualStyleBackColor = true;
            this.DisplayQuote.Click += new System.EventHandler(this.DisplayQuote_Click);
            // 
            // MegaDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.DisplayQuote);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddQuoteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MegaDesk";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Button DisplayQuote;
    }
}

