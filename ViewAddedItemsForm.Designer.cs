namespace ProjectBlue
{
    partial class ViewAddedItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAddedItemsForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.flpMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.restaurantCardNoImage1 = new ProjectBlue.RestaurantCardNoImage();
            this.menuItemCard1 = new ProjectBlue.MenuItemCard();
            this.menuItemCard2 = new ProjectBlue.MenuItemCard();
            this.menuItemCard3 = new ProjectBlue.MenuItemCard();
            this.restaurantCardImage1 = new ProjectBlue.RestaurantCardImage();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flpMenuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.restaurantCardImage1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(470, 637);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.restaurantCardNoImage1);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.flpMenuItems);
            this.panel1.Location = new System.Drawing.Point(488, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 624);
            this.panel1.TabIndex = 2;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(477, 236);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(49, 19);
            this.materialLabel5.TabIndex = 51;
            this.materialLabel5.Text = "Cancel";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel4.Location = new System.Drawing.Point(554, 236);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(36, 19);
            this.materialLabel4.TabIndex = 50;
            this.materialLabel4.Text = "Save";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Offerings";
            // 
            // flpMenuItems
            // 
            this.flpMenuItems.AutoScroll = true;
            this.flpMenuItems.Controls.Add(this.menuItemCard1);
            this.flpMenuItems.Controls.Add(this.menuItemCard2);
            this.flpMenuItems.Controls.Add(this.menuItemCard3);
            this.flpMenuItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenuItems.Location = new System.Drawing.Point(24, 299);
            this.flpMenuItems.Name = "flpMenuItems";
            this.flpMenuItems.Size = new System.Drawing.Size(569, 320);
            this.flpMenuItems.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurants";
            // 
            // restaurantCardNoImage1
            // 
            this.restaurantCardNoImage1.Address = "Bole Atlas";
            this.restaurantCardNoImage1.BackColor = System.Drawing.Color.Transparent;
            this.restaurantCardNoImage1.Location = new System.Drawing.Point(20, 15);
            this.restaurantCardNoImage1.MaximumSize = new System.Drawing.Size(575, 205);
            this.restaurantCardNoImage1.MinimumSize = new System.Drawing.Size(575, 205);
            this.restaurantCardNoImage1.Name = "restaurantCardNoImage1";
            this.restaurantCardNoImage1.PhoneNumber = "+251 91 030 5070";
            this.restaurantCardNoImage1.RestaurantName = "Atmosphere";
            this.restaurantCardNoImage1.ServiceOptions = "Dine-in, Takeaway, Delivery";
            this.restaurantCardNoImage1.Size = new System.Drawing.Size(575, 205);
            this.restaurantCardNoImage1.TabIndex = 52;
            this.restaurantCardNoImage1.WorkingHours = "8:00 AM - 9:00 AM";
            // 
            // menuItemCard1
            // 
            this.menuItemCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuItemCard1.Location = new System.Drawing.Point(3, 3);
            this.menuItemCard1.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.menuItemCard1.MaximumSize = new System.Drawing.Size(220, 295);
            this.menuItemCard1.MinimumSize = new System.Drawing.Size(220, 295);
            this.menuItemCard1.Name = "menuItemCard1";
            this.menuItemCard1.OfferingImage = ((System.Drawing.Image)(resources.GetObject("menuItemCard1.OfferingImage")));
            this.menuItemCard1.OfferingName = "Special Hummus";
            this.menuItemCard1.Price = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.menuItemCard1.Size = new System.Drawing.Size(220, 295);
            this.menuItemCard1.TabIndex = 0;
            // 
            // menuItemCard2
            // 
            this.menuItemCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuItemCard2.Location = new System.Drawing.Point(246, 3);
            this.menuItemCard2.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.menuItemCard2.MaximumSize = new System.Drawing.Size(220, 295);
            this.menuItemCard2.MinimumSize = new System.Drawing.Size(220, 295);
            this.menuItemCard2.Name = "menuItemCard2";
            this.menuItemCard2.OfferingImage = ((System.Drawing.Image)(resources.GetObject("menuItemCard2.OfferingImage")));
            this.menuItemCard2.OfferingName = "Crispy Chicken";
            this.menuItemCard2.Price = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.menuItemCard2.Size = new System.Drawing.Size(220, 295);
            this.menuItemCard2.TabIndex = 1;
            // 
            // menuItemCard3
            // 
            this.menuItemCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuItemCard3.Location = new System.Drawing.Point(489, 3);
            this.menuItemCard3.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.menuItemCard3.MaximumSize = new System.Drawing.Size(220, 295);
            this.menuItemCard3.MinimumSize = new System.Drawing.Size(220, 295);
            this.menuItemCard3.Name = "menuItemCard3";
            this.menuItemCard3.OfferingImage = ((System.Drawing.Image)(resources.GetObject("menuItemCard3.OfferingImage")));
            this.menuItemCard3.OfferingName = "Napoletana";
            this.menuItemCard3.Price = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.menuItemCard3.Size = new System.Drawing.Size(220, 295);
            this.menuItemCard3.TabIndex = 2;
            // 
            // restaurantCardImage1
            // 
            this.restaurantCardImage1.Address = "Bole Atlas";
            this.restaurantCardImage1.BackColor = System.Drawing.SystemColors.Control;
            this.restaurantCardImage1.Location = new System.Drawing.Point(14, 14);
            this.restaurantCardImage1.Margin = new System.Windows.Forms.Padding(14);
            this.restaurantCardImage1.MaximumSize = new System.Drawing.Size(417, 175);
            this.restaurantCardImage1.MinimumSize = new System.Drawing.Size(417, 175);
            this.restaurantCardImage1.Name = "restaurantCardImage1";
            this.restaurantCardImage1.PhoneNumber = "+251 91 030 5070";
            this.restaurantCardImage1.RestaurantImage = ((System.Drawing.Image)(resources.GetObject("restaurantCardImage1.RestaurantImage")));
            this.restaurantCardImage1.RestaurantName = "Atmosphere";
            this.restaurantCardImage1.Size = new System.Drawing.Size(417, 175);
            this.restaurantCardImage1.TabIndex = 1;
            // 
            // ViewAddedItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1129, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAddedItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 8;
            this.Text = "ViewAddedItemsForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpMenuItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpMenuItems;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Label label1;
        private MenuItemCard menuItemCard1;
        private MenuItemCard menuItemCard2;
        private MenuItemCard menuItemCard3;
        private RestaurantCardNoImage restaurantCardNoImage1;
        private RestaurantCardImage restaurantCardImage1;
    }
}