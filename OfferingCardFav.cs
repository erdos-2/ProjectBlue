﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectBlue.Model_Classes;

namespace ProjectBlue
{
    public partial class OfferingCardFav : UserControl
    {
        private Image _offeringImage;
        public Image OfferingImage
        {
            get { return _offeringImage; }
            set { _offeringImage = value; pbOfferingImage.Image = value; }
        }

        private string _offeringName;
        public string OfferingName
        {
            get { return _offeringName; }
            set { _offeringName = value; lblOfferingName.Text = value; }
        }
        
        private decimal _offeringPrice;
        public decimal OfferingPrice
        {
            get { return _offeringPrice; }
            set { _offeringPrice = value; lblOfferingPrice.Text = value.ToString() + " ETB"; }
        }

        public OfferingCardFav()
        {
            InitializeComponent();
        }

        public OfferingCardFav(Offering offering)
        {
            InitializeComponent();
            OfferingImage = offering.Image;
            OfferingName = offering.Name;
            OfferingPrice = offering.Price;
        }

        private void pbMoreVertIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add to Favorites\nRemove from Favorites");
        }
    }
}
