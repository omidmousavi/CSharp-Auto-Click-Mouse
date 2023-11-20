namespace Auto_Click_Mouse
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtHH = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtForwhile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.txtMM = new System.Windows.Forms.TextBox();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "(ms)با فرکانس :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "(s)به مدت :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "در ساعت :";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(63, 156);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 26);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "شروع";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(149, 156);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(81, 26);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "توقف";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtHH
            // 
            this.txtHH.Location = new System.Drawing.Point(127, 53);
            this.txtHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtHH.MaxLength = 2;
            this.txtHH.Name = "txtHH";
            this.txtHH.Size = new System.Drawing.Size(24, 21);
            this.txtHH.TabIndex = 0;
            this.txtHH.TextChanged += new System.EventHandler(this.txtHH_TextChanged);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(126, 113);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterval.MaxLength = 6;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(101, 21);
            this.txtInterval.TabIndex = 1;
            this.txtInterval.TextChanged += new System.EventHandler(this.txtInterval_TextChanged);
            // 
            // txtForwhile
            // 
            this.txtForwhile.Location = new System.Drawing.Point(126, 83);
            this.txtForwhile.Margin = new System.Windows.Forms.Padding(4);
            this.txtForwhile.MaxLength = 6;
            this.txtForwhile.Name = "txtForwhile";
            this.txtForwhile.Size = new System.Drawing.Size(101, 21);
            this.txtForwhile.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(39, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "ساعت فعلی :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.Location = new System.Drawing.Point(117, 21);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 18);
            this.lblTime.TabIndex = 10;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // txtMM
            // 
            this.txtMM.Location = new System.Drawing.Point(165, 53);
            this.txtMM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMM.MaxLength = 2;
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(24, 21);
            this.txtMM.TabIndex = 11;
            this.txtMM.TextChanged += new System.EventHandler(this.txtMM_TextChanged);
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(204, 53);
            this.txtSS.Margin = new System.Windows.Forms.Padding(4);
            this.txtSS.MaxLength = 2;
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(24, 21);
            this.txtSS.TabIndex = 12;
            this.txtSS.TextChanged += new System.EventHandler(this.txtSS_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(297, 205);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.txtMM);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtForwhile);
            this.Controls.Add(this.txtHH);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtHH;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox txtForwhile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox txtMM;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

