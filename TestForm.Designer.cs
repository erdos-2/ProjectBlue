namespace ProjectBlue
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.offeringCardMedium1 = new ProjectBlue.OfferingCardMedium();
            this.offeringCardMedium2 = new ProjectBlue.OfferingCardMedium();
            this.offeringCardMedium3 = new ProjectBlue.OfferingCardMedium();
            this.btnRight = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.btnLeft = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.offeringCardMedium1);
            this.flowLayoutPanel1.Controls.Add(this.offeringCardMedium2);
            this.flowLayoutPanel1.Controls.Add(this.offeringCardMedium3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(75, 215);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(974, 180);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // offeringCardMedium1
            // 
            this.offeringCardMedium1.Location = new System.Drawing.Point(3, 3);
            this.offeringCardMedium1.MaximumSize = new System.Drawing.Size(380, 155);
            this.offeringCardMedium1.MinimumSize = new System.Drawing.Size(380, 155);
            this.offeringCardMedium1.Name = "offeringCardMedium1";
            this.offeringCardMedium1.OfferingImg = ((System.Drawing.Image)(resources.GetObject("offeringCardMedium1.OfferingImg")));
            this.offeringCardMedium1.OfferingName = "Lasagna";
            this.offeringCardMedium1.OfferingPrice = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.offeringCardMedium1.RestaurantName = "Trattoria Gusto";
            this.offeringCardMedium1.Size = new System.Drawing.Size(380, 155);
            this.offeringCardMedium1.TabIndex = 0;
            // 
            // offeringCardMedium2
            // 
            this.offeringCardMedium2.Location = new System.Drawing.Point(389, 3);
            this.offeringCardMedium2.MaximumSize = new System.Drawing.Size(380, 155);
            this.offeringCardMedium2.MinimumSize = new System.Drawing.Size(380, 155);
            this.offeringCardMedium2.Name = "offeringCardMedium2";
            this.offeringCardMedium2.OfferingImg = ((System.Drawing.Image)(resources.GetObject("offeringCardMedium2.OfferingImg")));
            this.offeringCardMedium2.OfferingName = "Crispy Chicken";
            this.offeringCardMedium2.OfferingPrice = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.offeringCardMedium2.RestaurantName = "Sapore Restaurant";
            this.offeringCardMedium2.Size = new System.Drawing.Size(380, 155);
            this.offeringCardMedium2.TabIndex = 1;
            // 
            // offeringCardMedium3
            // 
            this.offeringCardMedium3.Location = new System.Drawing.Point(775, 3);
            this.offeringCardMedium3.MaximumSize = new System.Drawing.Size(380, 155);
            this.offeringCardMedium3.MinimumSize = new System.Drawing.Size(380, 155);
            this.offeringCardMedium3.Name = "offeringCardMedium3";
            this.offeringCardMedium3.OfferingImg = ((System.Drawing.Image)(resources.GetObject("offeringCardMedium3.OfferingImg")));
            this.offeringCardMedium3.OfferingName = "Special Hummus";
            this.offeringCardMedium3.OfferingPrice = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.offeringCardMedium3.RestaurantName = "Atmosphere Restaurant";
            this.offeringCardMedium3.Size = new System.Drawing.Size(380, 155);
            this.offeringCardMedium3.TabIndex = 2;
            // 
            // btnRight
            // 
            this.btnRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRight.Depth = 0;
            this.btnRight.Icon = ((System.Drawing.Image)(resources.GetObject("btnRight.Icon")));
            this.btnRight.Location = new System.Drawing.Point(1063, 277);
            this.btnRight.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(56, 56);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "materialFloatingActionButton1";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLeft.Depth = 0;
            this.btnLeft.Icon = ((System.Drawing.Image)(resources.GetObject("btnLeft.Icon")));
            this.btnLeft.Location = new System.Drawing.Point(6, 277);
            this.btnLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(56, 56);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "materialFloatingActionButton2";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 611);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private OfferingCardMedium offeringCardMedium1;
        private OfferingCardMedium offeringCardMedium2;
        private OfferingCardMedium offeringCardMedium3;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnRight;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnLeft;
    }
}