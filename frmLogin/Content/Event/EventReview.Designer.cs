namespace FptEventWinApp
{
    partial class EventReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventReview));
            this.picBoxView = new System.Windows.Forms.PictureBox();
            this.linkLbNameEvt = new System.Windows.Forms.LinkLabel();
            this.pnTime = new System.Windows.Forms.Panel();
            this.lbEndAt = new System.Windows.Forms.Label();
            this.lbStartAt = new System.Windows.Forms.Label();
            this.pnContent = new System.Windows.Forms.Panel();
            this.lbbyUser = new System.Windows.Forms.Label();
            this.lbSmallDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxView)).BeginInit();
            this.pnTime.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxView
            // 
            this.picBoxView.BackColor = System.Drawing.Color.White;
            this.picBoxView.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxView.Image = ((System.Drawing.Image)(resources.GetObject("picBoxView.Image")));
            this.picBoxView.Location = new System.Drawing.Point(750, 0);
            this.picBoxView.MaximumSize = new System.Drawing.Size(250, 250);
            this.picBoxView.MinimumSize = new System.Drawing.Size(250, 250);
            this.picBoxView.Name = "picBoxView";
            this.picBoxView.Size = new System.Drawing.Size(250, 250);
            this.picBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxView.TabIndex = 0;
            this.picBoxView.TabStop = false;
            this.picBoxView.Click += new System.EventHandler(this.PicBoxView_Click);
            // 
            // linkLbNameEvt
            // 
            this.linkLbNameEvt.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLbNameEvt.AllowDrop = true;
            this.linkLbNameEvt.AutoSize = true;
            this.linkLbNameEvt.BackColor = System.Drawing.Color.Transparent;
            this.linkLbNameEvt.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLbNameEvt.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLbNameEvt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLbNameEvt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLbNameEvt.Location = new System.Drawing.Point(0, 0);
            this.linkLbNameEvt.MaximumSize = new System.Drawing.Size(414, 0);
            this.linkLbNameEvt.Name = "linkLbNameEvt";
            this.linkLbNameEvt.Padding = new System.Windows.Forms.Padding(3);
            this.linkLbNameEvt.Size = new System.Drawing.Size(121, 27);
            this.linkLbNameEvt.TabIndex = 2;
            this.linkLbNameEvt.TabStop = true;
            this.linkLbNameEvt.Text = "linkLbNameEvt";
            this.linkLbNameEvt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLbNameEvt_LinkClicked);
            // 
            // pnTime
            // 
            this.pnTime.BackColor = System.Drawing.Color.White;
            this.pnTime.Controls.Add(this.lbEndAt);
            this.pnTime.Controls.Add(this.lbStartAt);
            this.pnTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTime.Location = new System.Drawing.Point(0, 0);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(100, 250);
            this.pnTime.TabIndex = 3;
            // 
            // lbEndAt
            // 
            this.lbEndAt.AutoSize = true;
            this.lbEndAt.Location = new System.Drawing.Point(5, 100);
            this.lbEndAt.Name = "lbEndAt";
            this.lbEndAt.Size = new System.Drawing.Size(49, 15);
            this.lbEndAt.TabIndex = 3;
            this.lbEndAt.Text = "lbEndAt";
            // 
            // lbStartAt
            // 
            this.lbStartAt.AutoSize = true;
            this.lbStartAt.Location = new System.Drawing.Point(5, 12);
            this.lbStartAt.Name = "lbStartAt";
            this.lbStartAt.Size = new System.Drawing.Size(53, 15);
            this.lbStartAt.TabIndex = 3;
            this.lbStartAt.Text = "lbStartAt";
            // 
            // pnContent
            // 
            this.pnContent.AutoSize = true;
            this.pnContent.BackColor = System.Drawing.Color.White;
            this.pnContent.Controls.Add(this.lbbyUser);
            this.pnContent.Controls.Add(this.lbSmallDescription);
            this.pnContent.Controls.Add(this.linkLbNameEvt);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(100, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(650, 250);
            this.pnContent.TabIndex = 4;
            this.pnContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnContent_MouseClick);
            // 
            // lbbyUser
            // 
            this.lbbyUser.AutoSize = true;
            this.lbbyUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbbyUser.Location = new System.Drawing.Point(0, 48);
            this.lbbyUser.Name = "lbbyUser";
            this.lbbyUser.Padding = new System.Windows.Forms.Padding(3);
            this.lbbyUser.Size = new System.Drawing.Size(49, 21);
            this.lbbyUser.TabIndex = 4;
            this.lbbyUser.Text = "byUser";
            // 
            // lbSmallDescription
            // 
            this.lbSmallDescription.AllowDrop = true;
            this.lbSmallDescription.AutoSize = true;
            this.lbSmallDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSmallDescription.Location = new System.Drawing.Point(0, 27);
            this.lbSmallDescription.MaximumSize = new System.Drawing.Size(414, 0);
            this.lbSmallDescription.Name = "lbSmallDescription";
            this.lbSmallDescription.Padding = new System.Windows.Forms.Padding(3);
            this.lbSmallDescription.Size = new System.Drawing.Size(105, 21);
            this.lbSmallDescription.TabIndex = 3;
            this.lbSmallDescription.Text = "Small Description";
            // 
            // button1
            // 
            this.button1.Image = global::FptEventWinApp.Properties.Resources.edit_free_icon_font;
            this.button1.Location = new System.Drawing.Point(968, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EventReview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnTime);
            this.Controls.Add(this.picBoxView);
            this.Name = "EventReview";
            this.Size = new System.Drawing.Size(1000, 250);
            this.Load += new System.EventHandler(this.EventReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxView)).EndInit();
            this.pnTime.ResumeLayout(false);
            this.pnTime.PerformLayout();
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnTime;
        private System.Windows.Forms.Panel pnContent;
        public System.Windows.Forms.Label lbEndAt;
        public System.Windows.Forms.Label lbStartAt;
        public System.Windows.Forms.LinkLabel linkLbNameEvt;
        public System.Windows.Forms.Label lbSmallDescription;
        public System.Windows.Forms.Label lbbyUser;
        public System.Windows.Forms.PictureBox picBoxView;
        private System.Windows.Forms.Button button1;
    }
}
