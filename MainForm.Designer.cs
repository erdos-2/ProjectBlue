namespace ProjectBlue
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbHome = new System.Windows.Forms.TabPage();
            this.tbSearch = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbFavorites = new System.Windows.Forms.TabPage();
            this.tbOrders = new System.Windows.Forms.TabPage();
            this.tbAccount = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tbHome);
            this.materialTabControl1.Controls.Add(this.tbSearch);
            this.materialTabControl1.Controls.Add(this.tbFavorites);
            this.materialTabControl1.Controls.Add(this.tbOrders);
            this.materialTabControl1.Controls.Add(this.tbAccount);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1058, 561);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tbHome
            // 
            this.tbHome.BackColor = System.Drawing.Color.White;
            this.tbHome.ImageKey = "home_FILL0_wght400_GRAD0_opsz48.png";
            this.tbHome.Location = new System.Drawing.Point(4, 39);
            this.tbHome.Name = "tbHome";
            this.tbHome.Padding = new System.Windows.Forms.Padding(3);
            this.tbHome.Size = new System.Drawing.Size(1050, 518);
            this.tbHome.TabIndex = 0;
            this.tbHome.Text = "Home";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.ImageKey = "search_FILL0_wght400_GRAD0_opsz48.png";
            this.tbSearch.Location = new System.Drawing.Point(4, 39);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearch.Size = new System.Drawing.Size(1050, 518);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.Text = "Search";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "star_FILL0_wght400_GRAD0_opsz48.png");
            this.imageList1.Images.SetKeyName(1, "account_circle_FILL0_wght400_GRAD0_opsz48.png");
            this.imageList1.Images.SetKeyName(2, "list_alt_FILL0_wght400_GRAD0_opsz48.png");
            this.imageList1.Images.SetKeyName(3, "search_FILL0_wght400_GRAD0_opsz48.png");
            this.imageList1.Images.SetKeyName(4, "home_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // tbFavorites
            // 
            this.tbFavorites.BackColor = System.Drawing.Color.White;
            this.tbFavorites.ImageKey = "star_FILL0_wght400_GRAD0_opsz48.png";
            this.tbFavorites.Location = new System.Drawing.Point(4, 39);
            this.tbFavorites.Name = "tbFavorites";
            this.tbFavorites.Padding = new System.Windows.Forms.Padding(3);
            this.tbFavorites.Size = new System.Drawing.Size(1050, 518);
            this.tbFavorites.TabIndex = 2;
            this.tbFavorites.Text = "Favorites";
            // 
            // tbOrders
            // 
            this.tbOrders.BackColor = System.Drawing.Color.White;
            this.tbOrders.ImageKey = "list_alt_FILL0_wght400_GRAD0_opsz48.png";
            this.tbOrders.Location = new System.Drawing.Point(4, 39);
            this.tbOrders.Name = "tbOrders";
            this.tbOrders.Size = new System.Drawing.Size(1050, 518);
            this.tbOrders.TabIndex = 3;
            this.tbOrders.Text = "Orders";
            // 
            // tbAccount
            // 
            this.tbAccount.BackColor = System.Drawing.Color.White;
            this.tbAccount.ImageKey = "account_circle_FILL0_wght400_GRAD0_opsz48.png";
            this.tbAccount.Location = new System.Drawing.Point(4, 39);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(1050, 518);
            this.tbAccount.TabIndex = 4;
            this.tbAccount.Text = "Account";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 628);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enbila";
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tbHome;
        private System.Windows.Forms.TabPage tbSearch;
        private System.Windows.Forms.TabPage tbFavorites;
        private System.Windows.Forms.TabPage tbOrders;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tbAccount;
    }
}

