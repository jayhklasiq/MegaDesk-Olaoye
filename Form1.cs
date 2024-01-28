using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Olaoye
{
    public partial class MegaDesk : Form
    {
        public MegaDesk()
        {
            InitializeComponent();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuoteForm = new AddQuote();
            viewAddQuoteForm.Tag = this;
            viewAddQuoteForm.Show(this);
            this.Hide();
        }

        private void DisplayQuote_Click(object sender, EventArgs e)
        {
            DisplayQuote viewDisplayQuoteForm = new DisplayQuote();
            viewDisplayQuoteForm.Tag = this;
            viewDisplayQuoteForm.Show(this);
            this.Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotesForm = new SearchQuotes();
            viewSearchQuotesForm.Tag = this;
            viewSearchQuotesForm.Show(this);
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
