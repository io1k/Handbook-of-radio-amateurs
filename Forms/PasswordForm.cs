using Handbook_of_radio_amateurs;
using Handbook_of_radio_amauter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handbook_of_amaters_try.Forms
{
    public partial class PasswordForm : Form
    {
        private Form1 form1;
        private DataProces dataProces;
        private string password;
        public Administrator admin ;
        private List<dynamic> DetailList;
        public PasswordForm(string pass,List<dynamic> list)
        {
            InitializeComponent();
            password = pass;
            DetailList = list;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEnter_Click(object sender, EventArgs e)
        {

            if (password == tbPassword.Text)
            {
                admin = new Administrator();
                admin.dataGridView1.DataSource = DetailList;
                admin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
        }


    }
}
