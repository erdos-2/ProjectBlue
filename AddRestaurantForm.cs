using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProjectBlue
{
    public partial class AddRestaurantForm : KryptonForm
    {
        ManagerMainForm managerMainForm1;
        public AddRestaurantForm(ManagerMainForm managerMainForm1)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);

            this.managerMainForm1 = managerMainForm1;
        }

        private void pbGoBack_Click(object sender, EventArgs e)
        {
            managerMainForm1.LoadForm(new AddItemsForm(managerMainForm1));
        }
    }
}
