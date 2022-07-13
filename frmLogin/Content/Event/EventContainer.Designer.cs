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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pnContentNewest.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContentNewest
            // 
            this.pnContentNewest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnContentNewest.Controls.Add(this.groupBox6);
            this.pnContentNewest.Controls.Add(this.groupBox5);
            this.pnContentNewest.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnContentNewest.Location = new System.Drawing.Point(1484, 0);
            this.pnContentNewest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContentNewest.Name = "pnContentNewest";
            this.pnContentNewest.Size = new System.Drawing.Size(400, 905);
            this.pnContentNewest.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(0, 336);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(400, 481);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Up Comming";
            this.groupBox6.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(400, 336);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Newsest Event";
            this.groupBox5.Visible = false;
            // 
            // flpContent
            // 
            flpContent.AutoScroll = true;
            flpContent.AutoSize = true;
            flpContent.BackColor = System.Drawing.Color.WhiteSmoke;
            flpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            flpContent.Location = new System.Drawing.Point(400, 0);
            flpContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            flpContent.Name = "flpContent";
            flpContent.Size = new System.Drawing.Size(1084, 905);
            flpContent.TabIndex = 1;
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.BackColor = System.Drawing.Color.White;
            this.btnAddNewEvent.FlatAppearance.BorderSize = 0;
            this.btnAddNewEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewEvent.Location = new System.Drawing.Point(18, 141);
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(212, 45);
            this.btnAddNewEvent.TabIndex = 3;
            this.btnAddNewEvent.Text = "Add New Event";
            this.btnAddNewEvent.UseVisualStyleBackColor = false;
            this.btnAddNewEvent.Click += new System.EventHandler(this.BtnAddNewEvent_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.btnAddNewEvent);
            this.panelFilter.Controls.Add(this.groupBox3);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(400, 905);
            this.panelFilter.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.MaximumSize = new System.Drawing.Size(400, 150);
            this.groupBox3.MinimumSize = new System.Drawing.Size(400, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 109);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(67, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 23);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "My Event";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(67, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 23);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "My Follow";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // EventContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(flpContent);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.pnContentNewest);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventContainer";
            this.Size = new System.Drawing.Size(1884, 905);
            this.Load += new System.EventHandler(this.ListEvent_Load);
            this.pnContentNewest.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnContentNewest;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAddNewEvent;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        static   public System.Windows.Forms.FlowLayoutPanel flpContent;
    }
}
