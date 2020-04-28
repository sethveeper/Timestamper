using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timestamper
{
    public partial class Timestamp : Form
    {
        DateTime stamp;

        public Timestamp()
        {
            InitializeComponent();
            stamp = DateTime.Now;
        }

        public Timestamp(DateTime timestamp)
        {
            InitializeComponent();

            stamp = timestamp;
        }

        private void Timestamp_Load(object sender, EventArgs e)
        {
            label.Text = stamp.ToShortTimeString();

            int minutes = 55;
            progressBar.Maximum = (10 * 60 * minutes);
            progressBar.Value = progressBar.Maximum;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value > 0)
                progressBar.Value--;
            else
                this.Close();
        }
    }
}
