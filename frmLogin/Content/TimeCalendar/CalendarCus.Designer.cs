namespace FptEventWinApp
{
    partial class CalendarCus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarCus));
            this.pnMonth = new System.Windows.Forms.Panel();
            this.lbMonth = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.pnDayInWeek = new System.Windows.Forms.Panel();
            this.lbSat = new System.Windows.Forms.Label();
            this.lbFri = new System.Windows.Forms.Label();
            this.lbThus = new System.Windows.Forms.Label();
            this.lbWed = new System.Windows.Forms.Label();
            this.lbTus = new System.Windows.Forms.Label();
            this.lbMon = new System.Windows.Forms.Label();
            this.lbSun = new System.Windows.Forms.Label();
            this.pnDayNow = new System.Windows.Forms.Panel();
            this.linkLbNow = new System.Windows.Forms.LinkLabel();
            this.flpDays = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMonth.SuspendLayout();
            this.pnDayInWeek.SuspendLayout();
            this.pnDayNow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMonth
            // 
            this.pnMonth.BackColor = System.Drawing.Color.White;
            this.pnMonth.Controls.Add(this.lbMonth);
            this.pnMonth.Controls.Add(this.btnNext);
            this.pnMonth.Controls.Add(this.btnPre);
            this.pnMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMonth.Location = new System.Drawing.Point(0, 0);
            this.pnMonth.Name = "pnMonth";
            this.pnMonth.Size = new System.Drawing.Size(380, 40);
            this.pnMonth.TabIndex = 0;
            // 
            // lbMonth
            // 
            this.lbMonth.BackColor = System.Drawing.Color.White;
            this.lbMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMonth.Location = new System.Drawing.Point(75, 0);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(230, 40);
            this.lbMonth.TabIndex = 2;
            this.lbMonth.Text = "lbMonth";
            this.lbMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(305, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 40);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.White;
            this.btnPre.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPre.FlatAppearance.BorderSize = 0;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Image = ((System.Drawing.Image)(resources.GetObject("btnPre.Image")));
            this.btnPre.Location = new System.Drawing.Point(0, 0);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 40);
            this.btnPre.TabIndex = 0;
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.BtnPre_Click);
            // 
            // pnDayInWeek
            // 
            this.pnDayInWeek.BackColor = System.Drawing.Color.White;
            this.pnDayInWeek.Controls.Add(this.lbSat);
            this.pnDayInWeek.Controls.Add(this.lbFri);
            this.pnDayInWeek.Controls.Add(this.lbThus);
            this.pnDayInWeek.Controls.Add(this.lbWed);
            this.pnDayInWeek.Controls.Add(this.lbTus);
            this.pnDayInWeek.Controls.Add(this.lbMon);
            this.pnDayInWeek.Controls.Add(this.lbSun);
            this.pnDayInWeek.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDayInWeek.Location = new System.Drawing.Point(0, 40);
            this.pnDayInWeek.Name = "pnDayInWeek";
            this.pnDayInWeek.Size = new System.Drawing.Size(380, 35);
            this.pnDayInWeek.TabIndex = 0;
            // 
            // lbSat
            // 
            this.lbSat.BackColor = System.Drawing.Color.White;
            this.lbSat.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSat.Location = new System.Drawing.Point(324, 0);
            this.lbSat.Name = "lbSat";
            this.lbSat.Size = new System.Drawing.Size(54, 35);
            this.lbSat.TabIndex = 6;
            this.lbSat.Text = "Sat";
            this.lbSat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFri
            // 
            this.lbFri.BackColor = System.Drawing.Color.White;
            this.lbFri.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbFri.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFri.Location = new System.Drawing.Point(270, 0);
            this.lbFri.Name = "lbFri";
            this.lbFri.Size = new System.Drawing.Size(54, 35);
            this.lbFri.TabIndex = 5;
            this.lbFri.Text = "Fri";
            this.lbFri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThus
            // 
            this.lbThus.BackColor = System.Drawing.Color.White;
            this.lbThus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbThus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbThus.Location = new System.Drawing.Point(216, 0);
            this.lbThus.Name = "lbThus";
            this.lbThus.Size = new System.Drawing.Size(54, 35);
            this.lbThus.TabIndex = 4;
            this.lbThus.Text = "Thus";
            this.lbThus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWed
            // 
            this.lbWed.BackColor = System.Drawing.Color.White;
            this.lbWed.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbWed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWed.Location = new System.Drawing.Point(162, 0);
            this.lbWed.Name = "lbWed";
            this.lbWed.Size = new System.Drawing.Size(54, 35);
            this.lbWed.TabIndex = 3;
            this.lbWed.Text = "Wed";
            this.lbWed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTus
            // 
            this.lbTus.BackColor = System.Drawing.Color.White;
            this.lbTus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTus.Location = new System.Drawing.Point(108, 0);
            this.lbTus.Name = "lbTus";
            this.lbTus.Size = new System.Drawing.Size(54, 35);
            this.lbTus.TabIndex = 2;
            this.lbTus.Text = "Tus";
            this.lbTus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMon
            // 
            this.lbMon.BackColor = System.Drawing.Color.White;
            this.lbMon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMon.Location = new System.Drawing.Point(54, 0);
            this.lbMon.Name = "lbMon";
            this.lbMon.Size = new System.Drawing.Size(54, 35);
            this.lbMon.TabIndex = 1;
            this.lbMon.Text = "Mon";
            this.lbMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSun
            // 
            this.lbSun.BackColor = System.Drawing.Color.White;
            this.lbSun.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSun.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSun.Location = new System.Drawing.Point(0, 0);
            this.lbSun.Name = "lbSun";
            this.lbSun.Size = new System.Drawing.Size(54, 35);
            this.lbSun.TabIndex = 0;
            this.lbSun.Text = "Sun";
            this.lbSun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDayNow
            // 
            this.pnDayNow.BackColor = System.Drawing.Color.White;
            this.pnDayNow.Controls.Add(this.linkLbNow);
            this.pnDayNow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDayNow.Location = new System.Drawing.Point(0, 399);
            this.pnDayNow.Name = "pnDayNow";
            this.pnDayNow.Size = new System.Drawing.Size(380, 35);
            this.pnDayNow.TabIndex = 0;
            // 
            // linkLbNow
            // 
            this.linkLbNow.BackColor = System.Drawing.Color.White;
            this.linkLbNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLbNow.LinkColor = System.Drawing.Color.Black;
            this.linkLbNow.Location = new System.Drawing.Point(0, 0);
            this.linkLbNow.Name = "linkLbNow";
            this.linkLbNow.Size = new System.Drawing.Size(380, 35);
            this.linkLbNow.TabIndex = 0;
            this.linkLbNow.TabStop = true;
            this.linkLbNow.Text = "Time now";
            this.linkLbNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpDays
            // 
            this.flpDays.BackColor = System.Drawing.Color.White;
            this.flpDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDays.Location = new System.Drawing.Point(0, 75);
            this.flpDays.Name = "flpDays";
            this.flpDays.Size = new System.Drawing.Size(380, 324);
            this.flpDays.TabIndex = 1;
            // 
            // CalendarCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpDays);
            this.Controls.Add(this.pnDayInWeek);
            this.Controls.Add(this.pnDayNow);
            this.Controls.Add(this.pnMonth);
            this.Name = "CalendarCus";
            this.Size = new System.Drawing.Size(380, 434);
            this.pnMonth.ResumeLayout(false);
            this.pnDayInWeek.ResumeLayout(false);
            this.pnDayNow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMonth;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Panel pnDayInWeek;
        private System.Windows.Forms.Label lbSat;
        private System.Windows.Forms.Label lbFri;
        private System.Windows.Forms.Label lbThus;
        private System.Windows.Forms.Label lbWed;
        private System.Windows.Forms.Label lbTus;
        private System.Windows.Forms.Label lbMon;
        private System.Windows.Forms.Label lbSun;
        private System.Windows.Forms.Panel pnDayNow;
        private System.Windows.Forms.FlowLayoutPanel flpDays;
        private System.Windows.Forms.LinkLabel linkLbNow;
    }
}
