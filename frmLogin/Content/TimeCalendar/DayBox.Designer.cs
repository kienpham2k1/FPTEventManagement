namespace FptEventWinApp
{
    partial class DayBox
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
            this.btnDay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDay
            // 
            this.btnDay.BackColor = System.Drawing.Color.White;
            this.btnDay.FlatAppearance.BorderSize = 0;
            this.btnDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDay.Location = new System.Drawing.Point(0, 0);
            this.btnDay.Margin = new System.Windows.Forms.Padding(0);
            this.btnDay.MaximumSize = new System.Drawing.Size(212, 143);
            this.btnDay.MinimumSize = new System.Drawing.Size(54, 54);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(54, 54);
            this.btnDay.TabIndex = 0;
            this.btnDay.Text = "Day";
            this.btnDay.UseVisualStyleBackColor = false;
            this.btnDay.MouseLeave += new System.EventHandler(this.BtnDay_MouseLeave);
            this.btnDay.MouseHover += new System.EventHandler(this.BtnDay_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // DayBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDay);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(212, 143);
            this.MinimumSize = new System.Drawing.Size(54, 54);
            this.Name = "DayBox";
            this.Size = new System.Drawing.Size(212, 143);
            this.Load += new System.EventHandler(this.DayBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Label label1;
    }
}
