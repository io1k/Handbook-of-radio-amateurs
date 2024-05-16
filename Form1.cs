using Handbook_of_radio_amateurs;
using Handbook_of_radio_amauter.Data;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace Handbook_of_amaters_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var proces = new DataProces();

            switch (combDetailType.Text.ToString())
            {
                case "Транзистор":

                    var transistor = proces.ReadDetails<Transistor>("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of amaters try\\Data\\TransistorData.json");
                    var sortedtrans = proces.SortedTransistor(transistor, combTransistorType.Text.ToString(), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));

                    proces.FormPicture(sortedtrans);

                    dataGridView1.DataSource = sortedtrans;
                    DataGridColumHide();
                    dataGridView1.Columns["btDetails"].DisplayIndex = dataGridView1.ColumnCount - 1;
                    break;

                case "Конденсатор":
                    var capasitors = proces.ReadDetails<Capasitor>("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of amaters try\\Data\\CapasitorData.json");
                    var sortedcapas = proces.SortedCapasitor(capasitors, combCapasitorType.Text.ToString(), Convert.ToDouble(textBox2.Text), Convert.ToDouble(tbCapasity.Text), Convert.ToDouble(textBox3.Text));

                    proces.FormPicture(sortedcapas);

                    dataGridView1.DataSource = sortedcapas;

                    DataGridColumHide();
                    dataGridView1.Columns["btDetails"].DisplayIndex = dataGridView1.ColumnCount - 1;
                    break;
            }
        }
        private void combDetailType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combDetailType.Text.ToString())
            {
                case "Транзистор":
                    Hide();
                    TransistorView();
                    break;
                case "Конденсатор":
                    Hide();
                    CapasitorView();
                    break;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = "0";
            }
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            //PasswordForm passform = new PasswordForm("123456");
            //passform.Show();
        }
    }

}
