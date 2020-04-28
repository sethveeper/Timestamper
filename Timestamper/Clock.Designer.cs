namespace Timestamper
{
    partial class Clock
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
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnTimestamp = new System.Windows.Forms.Button();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(10, 9);
            this.lblTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(307, 73);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "12:59 PM";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(10, 83);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(207, 31);
            this.dateTimePicker.TabIndex = 1;
            // 
            // btnTimestamp
            // 
            this.btnTimestamp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimestamp.Location = new System.Drawing.Point(10, 116);
            this.btnTimestamp.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnTimestamp.Name = "btnTimestamp";
            this.btnTimestamp.Size = new System.Drawing.Size(207, 48);
            this.btnTimestamp.TabIndex = 2;
            this.btnTimestamp.Text = "Make Time Stamp";
            this.btnTimestamp.UseVisualStyleBackColor = false;
            this.btnTimestamp.Click += new System.EventHandler(this.btnTimestamp_Click);
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(10, 178);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(63, 25);
            this.lblTimestamp.TabIndex = 3;
            this.lblTimestamp.Text = "None";
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(321, 224);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.btnTimestamp);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Clock";
            this.Text = "Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnTimestamp;
        private System.Windows.Forms.Label lblTimestamp;
    }
}