using System;
using System.Windows.Forms;
using VRMS.Enums; // Ensure you have this using statement

namespace Vehicle_Rental_Management_System.Controls
{
    public partial class CustomersView : UserControl
    {
        public CustomersView()
        {
            InitializeComponent();
            SetupComboBox();
        }

        private void SetupComboBox()
        {
            
            cbCustomerType.DataSource = Enum.GetValues(typeof(CustomerType));

            
            cbCustomerType.SelectedIndex = 0;
        }
    }
}