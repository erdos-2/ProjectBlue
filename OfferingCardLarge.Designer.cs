namespace ProjectBlue
{
    partial class OfferingCardLarge
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblRestaurantName = new MaterialSkin.Controls.MaterialLabel();
            this.lblOfferingPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblOfferingName = new MaterialSkin.Controls.MaterialLabel();
            this.pbOfferingImg = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOfferingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblRestaurantName);
            this.materialCard1.Controls.Add(this.lblOfferingPrice);
            this.materialCard1.Controls.Add(this.lblOfferingName);
            this.materialCard1.Controls.Add(this.pbOfferingImg);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 2);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MaximumSize = new System.Drawing.Size(375, 150);
            this.materialCard1.MinimumSize = new System.Drawing.Size(375, 150);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(375, 150);
            this.materialCard1.TabIndex = 0;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Depth = 0;
            this.lblRestaurantName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRestaurantName.Location = new System.Drawing.Point(170, 97);
            this.lblRestaurantName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(124, 19);
            this.lblRestaurantName.TabIndex = 3;
            this.lblRestaurantName.Text = "Restaurant Name";
            // 
            // lblOfferingPrice
            // 
            this.lblOfferingPrice.AutoSize = true;
            this.lblOfferingPrice.Depth = 0;
            this.lblOfferingPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOfferingPrice.Location = new System.Drawing.Point(170, 58);
            this.lblOfferingPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOfferingPrice.Name = "lblOfferingPrice";
            this.lblOfferingPrice.Size = new System.Drawing.Size(98, 19);
            this.lblOfferingPrice.TabIndex = 2;
            this.lblOfferingPrice.Text = "Offering Price";
            // 
            // lblOfferingName
            // 
            this.lblOfferingName.AutoSize = true;
            this.lblOfferingName.Depth = 0;
            this.lblOfferingName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblOfferingName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblOfferingName.Location = new System.Drawing.Point(170, 14);
            this.lblOfferingName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOfferingName.Name = "lblOfferingName";
            this.lblOfferingName.Size = new System.Drawing.Size(132, 24);
            this.lblOfferingName.TabIndex = 1;
            this.lblOfferingName.Text = "Offering Name";
            // 
            // pbOfferingImg
            // 
            this.pbOfferingImg.BackColor = System.Drawing.Color.Silver;
            this.pbOfferingImg.Location = new System.Drawing.Point(5, 5);
            this.pbOfferingImg.Name = "pbOfferingImg";
            this.pbOfferingImg.Size = new System.Drawing.Size(140, 140);
            this.pbOfferingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOfferingImg.TabIndex = 0;
            this.pbOfferingImg.TabStop = false;
            // 
            // OfferingCardLarge
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.MaximumSize = new System.Drawing.Size(380, 155);
            this.MinimumSize = new System.Drawing.Size(380, 155);
            this.Name = "OfferingCardLarge";
            this.Size = new System.Drawing.Size(380, 155);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOfferingImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pbOfferingImg;
        private MaterialSkin.Controls.MaterialLabel lblRestaurantName;
        private MaterialSkin.Controls.MaterialLabel lblOfferingPrice;
        private MaterialSkin.Controls.MaterialLabel lblOfferingName;
    }
}
