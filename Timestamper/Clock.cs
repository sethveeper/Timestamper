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
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void btnTimestamp_Click(object sender, EventArgs e)
        {
            DateTime stamp = DateTime.Now;

            if (dateTimePicker.Checked)
                stamp = dateTimePicker.Value;

            lblTimestamp.Text = stamp.ToShortTimeString();
            Timestamp timeStamp = new Timestamp(stamp);
            timeStamp.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
