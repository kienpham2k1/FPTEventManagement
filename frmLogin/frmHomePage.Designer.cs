//namespace frmHomePage
//{
    partial class frmHomePage
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
            pnContent = new System.Windows.Forms.Panel();
            pnNavigation = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // pnContent
            // 
            pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnContent.Location = new System.Drawing.Point(0, 56);
            pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnContent.Name = "pnContent";
            pnContent.Size = new System.Drawing.Size(1884, 905);
            pnContent.TabIndex = 3;
            // 
            // pnNavigation
            // 
            pnNavigation.BackColor = System.Drawing.Color.White;
            pnNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            pnNavigation.Location = new System.Drawing.Point(0, 0);
            pnNavigation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnNavigation.Name = "pnNavigation";
            pnNavigation.Size = new System.Drawing.Size(1884, 56);
            pnNavigation.TabIndex = 2;
            // 
            // frmHomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1884, 961);
            Controls.Add(pnContent);
            Controls.Add(pnNavigation);
            Name = "frmHomePage";
            Text = "frmHomePage";
            ResumeLayout(false);

        }

        #endregion

        public static System.Windows.Forms.Panel pnContent;
        public static System.Windows.Forms.Panel pnNavigation;
    }
//}