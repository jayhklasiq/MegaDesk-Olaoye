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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ReturnToHome_Click(object sender, EventArgs e)
        {
            MegaDesk returnToHomeScreen = (MegaDesk)Tag;
            returnToHomeScreen.Show();
            this.Close();
        }
    }
}
