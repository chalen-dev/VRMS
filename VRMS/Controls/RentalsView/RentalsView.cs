using System;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System.Controls
{
    public partial class RentalsView : System.Windows.Forms.UserControl
    {
        public RentalsView()
        {
            InitializeComponent();
        }

        // Placeholders to prevent errors from the Designer's Button references
        private void BtnNewRental_Click(object sender, EventArgs e) { }
        private void BtnReturn_Click(object sender, EventArgs e) { }
        private void BtnViewDetails_Click(object sender, EventArgs e) { }
    }
}