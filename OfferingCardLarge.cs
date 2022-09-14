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
    public partial class OfferingCardLarge : UserControl
    {
        private Image _offeringImg;

        public Image OfferingImg
        {
            get { return _offeringImg; }
            set { _offeringImg = value; pbOfferingImg.Image = value; }
        }
        private string _offeringName;

        public string OfferingName
        {
            get { return _offeringName; }
            set { _offeringName = value; lblOfferingName.Text = value; }
        }
        private string _restaurantName;

        public string RestaurantName
        {
            get { return _restaurantName; }
            set { _restaurantName = value; lblRestaurantName.Text = value; }
        }

        private string _time;

        public string Time
        {
            get { return _time; }
            set { _time = value; lblTime.Text = value; }
        }

        public OfferingCardLarge()
        {
            InitializeComponent();
        }
    }
}
