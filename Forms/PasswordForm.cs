using Handbook_of_radio_amateurs;
using Handbook_of_radio_amateurs.Forms;
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
        private DataProces dataProces;
        private string password;
        private List<object> DetailList;
        private string currentType;
        public PasswordForm(string pass, List<object> list, string type)
        {
            InitializeComponent();
            password = pass;
            DetailList = list;
            currentType = type;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEnter_Click(object sender, EventArgs e)
        {

            if (password == tbPassword.Text)
            {
                var admin = new AdminForm(currentType, DetailList);
                admin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void lbEnterPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
