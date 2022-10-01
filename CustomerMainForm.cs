using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProjectBlue
{
    public partial class CustomerMainForm : MaterialForm
    {
        public CustomerMainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);

            lblGreeting.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            greet();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(lblGreeting.Text);
        }

        private void greet()
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            TimeSpan midnight = new TimeSpan(0, 0, 0);
            TimeSpan noon = new TimeSpan(12, 0, 0);
            TimeSpan sunset = new TimeSpan(18, 0, 0);
            // if it is later than midnight and earlier than noon
            if (TimeSpan.Compare(currentTime, midnight) >= 0 && TimeSpan.Compare(currentTime, noon) < 0)
            {
                lblGreeting.Text = "Good Morning";
                // fetch breakfast offerings and add to flpMealOfTheDay
            }
            // if it is later than noon and earlier than sunset
            else if (TimeSpan.Compare(currentTime, sunset) < 0)
            {
                lblGreeting.Text = "Good Afternoon";
                // fetch lunch offerings and add to flpMealOfTheDay
            }
            // if it is later than sunset and earlier than midnight
            else
            {
                lblGreeting.Text = "Good Evening";
                // fetch dinner offerings and add to flpMealOfTheDay
            }
        }
    }
}
