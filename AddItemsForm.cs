using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBlue
{
    public partial class AddItemsForm : Form
    {
        ManagerMainForm managerMainForm1;
        public AddItemsForm(ManagerMainForm managerMainForm1)
        {
            InitializeComponent();

            this.managerMainForm1 = managerMainForm1;
        }

        private void cardAddRestaurant_Click(object sender, EventArgs e)
        {
            AddRestaurantForm addRestaurantForm1 = new AddRestaurantForm();
            managerMainForm1.LoadForm(addRestaurantForm1);
        }

        private void cardAddOffering_Click(object sender, EventArgs e)
        {
            AddOfferingForm addOfferingForm1 = new AddOfferingForm();
            managerMainForm1.LoadForm(addOfferingForm1);
        }
    }
}
