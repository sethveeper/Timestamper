namespace Timestamper
{
    partial class Timestamp
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
            this.label = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(152, 37);
            this.label.TabIndex = 0;
            this.label.Text = "12:59 PM";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 58);
            this.progressBar.Maximum = 33000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(142, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 1;
            this.progressBar.Value = 33000;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Timestamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(181, 114);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Timestamp";
            this.Opacity = 0.6D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Time Stamp";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Timestamp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}

