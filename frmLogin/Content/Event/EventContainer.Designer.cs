namespace FptEventWinApp
{
    partial class EventContainer
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
            this.pnContentNewest = new System.Windows.Forms.Panel();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnContentNewest
            // 
            this.pnContentNewest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnContentNewest.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnContentNewest.Location = new System.Drawing.Point(1484, 0);
            this.pnContentNewest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContentNewest.Name = "pnContentNewest";
            this.pnContentNewest.Size = new System.Drawing.Size(400, 905);
            this.pnContentNewest.TabIndex = 0;
            // 
            // flpContent
            // 
            this.flpContent.AutoScroll = true;
            this.flpContent.AutoSize = true;
            this.flpContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContent.Location = new System.Drawing.Point(400, 0);
            this.flpContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(1084, 905);
            this.flpContent.TabIndex = 1;
            // 
            // panelFilter
            // 
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(400, 905);
            this.panelFilter.TabIndex = 0;
            // 
            // EventContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.pnContentNewest);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventContainer";
            this.Size = new System.Drawing.Size(1884, 905);
            this.Load += new System.EventHandler(this.ListEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnContentNewest;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
        private System.Windows.Forms.Panel panelFilter;
    }
}
