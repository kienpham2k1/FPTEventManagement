namespace FptEventWinApp
{
    partial class TimeScheduleContainer
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
            this.pnMonthCalendar = new System.Windows.Forms.Panel();
            this.calendarCus1 = new FptEventWinApp.CalendarCus();
            this.pnControls = new System.Windows.Forms.Panel();
            pnContent = new System.Windows.Forms.Panel();
            flpDisplayDays = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.btnViewByWeek = new System.Windows.Forms.Button();
            this.btnViewByMotnh = new System.Windows.Forms.Button();
            this.pnMonthCalendar.SuspendLayout();
            this.pnControls.SuspendLayout();
            pnContent.SuspendLayout();
            flpDisplayDays.SuspendLayout();
            this.pnDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMonthCalendar
            // 
            this.pnMonthCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.pnMonthCalendar.Controls.Add(this.calendarCus1);
            this.pnMonthCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMonthCalendar.Location = new System.Drawing.Point(0, 0);
            this.pnMonthCalendar.Name = "pnMonthCalendar";
            this.pnMonthCalendar.Size = new System.Drawing.Size(400, 905);
            this.pnMonthCalendar.TabIndex = 0;
            // 
            // calendarCus1
            // 
            this.calendarCus1.BackColor = System.Drawing.Color.White;
            this.calendarCus1.Location = new System.Drawing.Point(10, 45);
            this.calendarCus1.Name = "calendarCus1";
            this.calendarCus1.Size = new System.Drawing.Size(380, 434);
            this.calendarCus1.TabIndex = 0;
            // 
            // pnControls
            // 
            this.pnControls.Controls.Add(pnContent);
            this.pnControls.Controls.Add(this.pnDisplay);
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControls.Location = new System.Drawing.Point(400, 0);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(1484, 905);
            this.pnControls.TabIndex = 1;
            // 
            // pnContent
            // 
            pnContent.Controls.Add(flpDisplayDays);
            pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnContent.Location = new System.Drawing.Point(0, 45);
            pnContent.Name = "pnContent";
            pnContent.Size = new System.Drawing.Size(1484, 860);
            pnContent.TabIndex = 4;
            // 
            // flpDisplayDays
            // 
            flpDisplayDays.Controls.Add(this.button1);
            flpDisplayDays.Location = new System.Drawing.Point(0, 0);
            flpDisplayDays.Name = "flpDisplayDays";
            flpDisplayDays.Size = new System.Drawing.Size(1484, 860);
            flpDisplayDays.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "----";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnDisplay
            // 
            this.pnDisplay.BackColor = System.Drawing.Color.White;
            this.pnDisplay.Controls.Add(this.btnAddNewEvent);
            this.pnDisplay.Controls.Add(this.btnViewByWeek);
            this.pnDisplay.Controls.Add(this.btnViewByMotnh);
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(1484, 45);
            this.pnDisplay.TabIndex = 2;
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.BackColor = System.Drawing.Color.White;
            this.btnAddNewEvent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewEvent.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAddNewEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAddNewEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAddNewEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewEvent.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(212, 45);
            this.btnAddNewEvent.TabIndex = 2;
            this.btnAddNewEvent.Text = "Add New Event";
            this.btnAddNewEvent.UseVisualStyleBackColor = false;
            // 
            // btnViewByWeek
            // 
            this.btnViewByWeek.BackColor = System.Drawing.Color.White;
            this.btnViewByWeek.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnViewByWeek.FlatAppearance.BorderSize = 0;
            this.btnViewByWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewByWeek.Location = new System.Drawing.Point(1304, 0);
            this.btnViewByWeek.Name = "btnViewByWeek";
            this.btnViewByWeek.Size = new System.Drawing.Size(90, 45);
            this.btnViewByWeek.TabIndex = 0;
            this.btnViewByWeek.Text = "Week";
            this.btnViewByWeek.UseVisualStyleBackColor = false;
            this.btnViewByWeek.Visible = false;
            this.btnViewByWeek.Click += new System.EventHandler(this.BtnViewByWeek_Click);
            // 
            // btnViewByMotnh
            // 
            this.btnViewByMotnh.BackColor = System.Drawing.Color.White;
            this.btnViewByMotnh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnViewByMotnh.FlatAppearance.BorderSize = 0;
            this.btnViewByMotnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewByMotnh.Location = new System.Drawing.Point(1394, 0);
            this.btnViewByMotnh.Name = "btnViewByMotnh";
            this.btnViewByMotnh.Size = new System.Drawing.Size(90, 45);
            this.btnViewByMotnh.TabIndex = 1;
            this.btnViewByMotnh.Text = "Motnh";
            this.btnViewByMotnh.UseVisualStyleBackColor = false;
            this.btnViewByMotnh.Visible = false;
            this.btnViewByMotnh.Click += new System.EventHandler(this.BtnViewByMotnh_Click);
            // 
            // TimeScheduleContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.pnMonthCalendar);
            this.Name = "TimeScheduleContainer";
            this.Size = new System.Drawing.Size(1884, 905);
            this.Load += new System.EventHandler(this.TimeScheduleContainer_Load);
            this.pnMonthCalendar.ResumeLayout(false);
            this.pnControls.ResumeLayout(false);
            pnContent.ResumeLayout(false);
            flpDisplayDays.ResumeLayout(false);
            this.pnDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMonthCalendar;
        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.Button btnViewByMotnh;
        private System.Windows.Forms.Button btnViewByWeek;
        private System.Windows.Forms.Button btnAddNewEvent;
        private CalendarCus calendarCus1;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.Button button1;
        static public System.Windows.Forms.Panel pnContent;
      static  private System.Windows.Forms.FlowLayoutPanel flpDisplayDays;
    }
}
