using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk_Olaoye
{
    public partial class AddQuote : Form
    {
        private Desk myDesk = new Desk(0, 0, 0, SurfaceMaterial.Laminate);

        public AddQuote()
        {
            InitializeComponent();
            surfaceMaterial.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            rushDays.DataSource = Enum.GetValues(typeof(RushOrderOption));

            myDesk = new Desk(0, 0, 0, SurfaceMaterial.Laminate);
        }

        private void CloseForm()
        {
            MegaDesk returnToHomeScreen = (MegaDesk)Tag;
            returnToHomeScreen.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void CustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void width_ValueChanged(object sender, EventArgs e)
        {
            //myDesk.SetWidth((int)width.Value);


            if (int.TryParse(width.Value.ToString(), out int widthValue))
            {
                int result = myDesk.SetWidth(widthValue);

                if (result == -1)
                {
                    // Handle validation error, e.g., display a message to the user
                    MessageBox.Show($"Width must be between {Desk.MinWidth} and {Desk.MaxWidth} inches.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle parsing error, e.g., display a message to the user
                MessageBox.Show("Width must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void depth_ValueChanged(object sender, EventArgs e)
        {
            //myDesk.SetDepth((int)depth.Value);

            if (int.TryParse(depth.Value.ToString(), out int depthValue))
            {
                int result = myDesk.SetDepth(depthValue);

                if (result == -1)
                {
                    // Handle validation error, e.g., display a message to the user
                    MessageBox.Show($"Depth must be between {Desk.MinDepth} and {Desk.MaxDepth} inches.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle parsing error, e.g., display a message to the user
                MessageBox.Show("Depth must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    

        private void drawerNum_ValueChanged(object sender, EventArgs e)
        {
            //myDesk.NumberOfDrawers = (int)drawerNum.Value;


            if (int.TryParse(drawerNum.Value.ToString(), out int drawerNumber))
            {
                int result = myDesk.SetNumberOfDrawers(drawerNumber);

                if (result == -1)
                {
                    // Handle validation error, e.g., display a message to the user
                    MessageBox.Show($"Drawer number musb be between {Desk.MinDrawers} and {Desk.MaxDrawers}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle parsing error, e.g., display a message to the user
                MessageBox.Show("Number of drawers must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void surfaceMaterial_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            surfaceMaterial.SelectedItem = myDesk.SurfaceMaterial;
        }

        private void rushDays_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            rushDays.SelectedItem = myDesk.RushOrderOption;
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        public void SubmitQuote_Click(object sender, EventArgs e)
        {
            // Create a new Desk instance
            Desk desk = new Desk(0, 0, 0, SurfaceMaterial.Laminate);

            // Assign the desk to myDesk
            Desk myDesk = desk;

            // Show a message box indicating that the quote is added
            MessageBox.Show("Quote Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CloseForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

    }
}
