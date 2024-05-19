using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handbook_of_amaters_try
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {Convert.ToString(linkLabel1.Text)}") { CreateNoWindow = true });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
