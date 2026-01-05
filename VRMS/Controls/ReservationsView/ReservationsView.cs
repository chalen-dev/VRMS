using System;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System.Controls
{
    public partial class ReservationsView : UserControl
    {
        public ReservationsView()
        {
            InitializeComponent();
        }

        // Placeholders for button clicks and grid events
        private void BtnNewReservation_Click(object sender, EventArgs e) { }
        private void BtnCancel_Click(object sender, EventArgs e) { }
        private void DgvReservations_SelectionChanged(object sender, EventArgs e) { }
    }
}