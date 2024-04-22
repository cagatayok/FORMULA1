namespace Formula1
{
    partial class Form1
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
            this.Main_panel1 = new System.Windows.Forms.Panel();
            this.ptr_box_lane2 = new System.Windows.Forms.PictureBox();
            this.ptr_box_lane = new System.Windows.Forms.PictureBox();
            this.ptr_box_mycar = new System.Windows.Forms.PictureBox();
            this.mycarhız_timer1 = new System.Windows.Forms.Timer(this.components);
            this.mycarhareket_timer1 = new System.Windows.Forms.Timer(this.components);
            this.Main_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_box_lane2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_box_lane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_box_mycar)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_panel1
            // 
            this.Main_panel1.BackColor = System.Drawing.Color.Silver;
            this.Main_panel1.Controls.Add(this.ptr_box_lane2);
            this.Main_panel1.Controls.Add(this.ptr_box_lane);
            this.Main_panel1.Controls.Add(this.ptr_box_mycar);
            this.Main_panel1.Location = new System.Drawing.Point(0, 0);
            this.Main_panel1.Name = "Main_panel1";
            this.Main_panel1.Size = new System.Drawing.Size(300, 500);
            this.Main_panel1.TabIndex = 0;
            // 
            // ptr_box_lane2
            // 
            this.ptr_box_lane2.BackgroundImage = global::Formula1.Properties.Resources.şerti;
            this.ptr_box_lane2.Location = new System.Drawing.Point(270, -30000);
            this.ptr_box_lane2.Name = "ptr_box_lane2";
            this.ptr_box_lane2.Size = new System.Drawing.Size(30, 30500);
            this.ptr_box_lane2.TabIndex = 1;
            this.ptr_box_lane2.TabStop = false;
            // 
            // ptr_box_lane
            // 
            this.ptr_box_lane.BackgroundImage = global::Formula1.Properties.Resources.şerit223;
            this.ptr_box_lane.Location = new System.Drawing.Point(0, -30000);
            this.ptr_box_lane.Name = "ptr_box_lane";
            this.ptr_box_lane.Size = new System.Drawing.Size(30, 30500);
            this.ptr_box_lane.TabIndex = 1;
            this.ptr_box_lane.TabStop = false;
            // 
            // ptr_box_mycar
            // 
            this.ptr_box_mycar.BackgroundImage = global::Formula1.Properties.Resources.formula11;
            this.ptr_box_mycar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptr_box_mycar.Location = new System.Drawing.Point(124, 430);
            this.ptr_box_mycar.Name = "ptr_box_mycar";
            this.ptr_box_mycar.Size = new System.Drawing.Size(52, 60);
            this.ptr_box_mycar.TabIndex = 0;
            this.ptr_box_mycar.TabStop = false;
            // 
            // mycarhız_timer1
            // 
            this.mycarhız_timer1.Enabled = true;
            this.mycarhız_timer1.Interval = 500;
            this.mycarhız_timer1.Tick += new System.EventHandler(this.mycarhız_timer1_Tick);
            // 
            // mycarhareket_timer1
            // 
            this.mycarhareket_timer1.Enabled = true;
            this.mycarhareket_timer1.Tick += new System.EventHandler(this.mycarhareket_timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.Main_panel1);
            this.Name = "Form1";
            this.Text = "Formula1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Main_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_box_lane2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_box_lane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_box_mycar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_panel1;
        private System.Windows.Forms.PictureBox ptr_box_mycar;
        private System.Windows.Forms.PictureBox ptr_box_lane2;
        private System.Windows.Forms.PictureBox ptr_box_lane;
        private System.Windows.Forms.Timer mycarhız_timer1;
        private System.Windows.Forms.Timer mycarhareket_timer1;
    }
}

