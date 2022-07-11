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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.btnDay.Click += new System.EventHandler(this.BtnDay_Click);
            this.btnDay.MouseLeave += new System.EventHandler(this.BtnDay_MouseLeave);
            this.btnDay.MouseHover += new System.EventHandler(this.BtnDay_MouseHover);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(154, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(154, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(154, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 3;
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(39, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 5);
            this.label5.TabIndex = 5;
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(39, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 5);
            this.label4.TabIndex = 6;
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(39, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 5);
            this.label6.TabIndex = 7;
            this.label6.Visible = false;
            // 
            // DayBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDay);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(212, 143);
            this.MinimumSize = new System.Drawing.Size(54, 54);
            this.Name = "DayBox";
            this.Size = new System.Drawing.Size(210, 141);
            this.Load += new System.EventHandler(this.DayBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}
