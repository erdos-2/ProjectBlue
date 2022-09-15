using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProjectBlue
{
    public partial class TestForm : MaterialForm
    {
        public TestForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Teal700, TextShade.WHITE);

            flowLayoutPanel1.HorizontalScroll.Visible = false;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int change = flowLayoutPanel1.HorizontalScroll.SmallChange * 15;
            flowLayoutPanel1.AutoScrollPosition = new Point(flowLayoutPanel1.HorizontalScroll.Value - change, 0);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int change = flowLayoutPanel1.HorizontalScroll.SmallChange * 15;
            flowLayoutPanel1.AutoScrollPosition = new Point(flowLayoutPanel1.HorizontalScroll.Value + change, 0);
        }
    }
}
