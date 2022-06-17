namespace FptEventWinApp
{
    partial class NavigationGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationGuest));
            this.btnTimeSchedule = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnViewNotify = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewFollow = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimeSchedule
            // 
            this.btnTimeSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTimeSchedule.FlatAppearance.BorderSize = 0;
            this.btnTimeSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeSchedule.Image = global::FptEventWinApp.Properties.Resources.calendar;
            this.btnTimeSchedule.Location = new System.Drawing.Point(550, 0);
            this.btnTimeSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimeSchedule.Name = "btnTimeSchedule";
            this.btnTimeSchedule.Size = new System.Drawing.Size(150, 56);
            this.btnTimeSchedule.TabIndex = 0;
            this.btnTimeSchedule.Text = " ";
            this.btnTimeSchedule.UseVisualStyleBackColor = true;
            this.btnTimeSchedule.Click += new System.EventHandler(this.btnOpenTimeSchedule_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::FptEventWinApp.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(400, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 56);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = " ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnGoHomePage_Click);
            // 
            // btnViewNotify
            // 
            this.btnViewNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewNotify.FlatAppearance.BorderSize = 0;
            this.btnViewNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewNotify.Image = ((System.Drawing.Image)(resources.GetObject("btnViewNotify.Image")));
            this.btnViewNotify.Location = new System.Drawing.Point(1669, 0);
            this.btnViewNotify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewNotify.Name = "btnViewNotify";
            this.btnViewNotify.Size = new System.Drawing.Size(70, 56);
            this.btnViewNotify.TabIndex = 3;
            this.btnViewNotify.Text = " ";
            this.btnViewNotify.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(1739, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(70, 56);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = " ";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::FptEventWinApp.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(56, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 56);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = " ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnViewFollow
            // 
            this.btnViewFollow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewFollow.FlatAppearance.BorderSize = 0;
            this.btnViewFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFollow.Image = ((System.Drawing.Image)(resources.GetObject("btnViewFollow.Image")));
            this.btnViewFollow.Location = new System.Drawing.Point(1599, 0);
            this.btnViewFollow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewFollow.Name = "btnViewFollow";
            this.btnViewFollow.Size = new System.Drawing.Size(70, 56);
            this.btnViewFollow.TabIndex = 6;
            this.btnViewFollow.Text = " ";
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.ErrorImage = null;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(56, 56);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Location = new System.Drawing.Point(126, 0);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 56);
            this.txtSearch.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Image = global::FptEventWinApp.Properties.Resources.power_free_icon_font;
            this.btnExit.Location = new System.Drawing.Point(1809, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 56);
            this.btnExit.TabIndex = 9;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // NavigationGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnViewFollow);
            this.Controls.Add(this.btnViewNotify);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTimeSchedule);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.logo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NavigationGuest";
            this.Size = new System.Drawing.Size(1884, 56);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimeSchedule;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnViewNotify;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewFollow;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExit;
    }
}
