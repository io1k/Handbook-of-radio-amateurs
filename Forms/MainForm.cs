using Handbook_of_amaters_try.Forms;
using Handbook_of_amaters_try;
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

namespace Handbook_of_radio_amateurs.Forms
{
    public partial class MainForm : Form
    {
        public List<List<object>> currentDetailList;
        public MainForm()
        {
            var proces = new DataProces();
            InitializeComponent();
            Hide();
            SetIconSize();
            currentDetailList = proces.AddAllLists();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Details detailsForm = new Details();
            if (e.ColumnIndex == btDetails.Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                dynamic selectedItem = selectedRow.DataBoundItem;
                List<string> result = new List<string>();
                if (detailsForm != null && detailsForm.Visible)
                {
                    foreach (var property in selectedItem.GetType().GetProperties())
                    {
                        if (property.Name == "Id" || property.Name == "imageLink" || property.Name == "image" || property.Name == "imageLink" || property.Name == "Link")
                        {
                            continue;
                        }
                        result.Add(property.Name + ":  " + property.GetValue(selectedItem));
                    }
                    detailsForm.pbDetailImage.Image = selectedItem.image;
                    detailsForm.linkLabel1.Text = selectedItem.Link;
                    detailsForm.tbDetails.Text = string.Join(Environment.NewLine, result);
                    detailsForm.Activate();
                }
                else
                {
                    foreach (var property in selectedItem.GetType().GetProperties())
                    {
                        if (property.Name == "Id" || property.Name == "imageLink" || property.Name == "image" || property.Name == "imageLink" || property.Name == "Link")
                        {
                            continue;
                        }
                        result.Add(property.Name + ":  " + property.GetValue(selectedItem));
                    }
                    detailsForm.pbDetailImage.Image = selectedItem.image;
                    detailsForm.linkLabel1.Text = selectedItem.Link;
                    detailsForm.tbDetails.Text = string.Join(Environment.NewLine, result);
                    detailsForm.Show();
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var Proces = new DataProces();
            switch (combDetailType.Text.ToString())
            {
                case "Transistor":
                    var transistor = Proces.ReadDetails<Transistor>("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\DetailsData\\TransistorData.json");
                    var sortedtrans = Proces.SortedTransistor(transistor, tbModel.Text.ToString(), combTransistorType.Text.ToString(), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));

                    Proces.FormPicture(sortedtrans);

                    dataGridView1.DataSource = sortedtrans;
                    DataGridColumHide();
                    dataGridView1.Columns["btDetails"].DisplayIndex = dataGridView1.ColumnCount - 1;
                    btDetails.Visible = true;
                    break;

                case "Capacitor":

                    var capasitors = Proces.ReadDetails<Capasitor>("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\DetailsData\\CapasitorData.json");
                    var sortedcapas = Proces.SortedCapasitor(capasitors, tbModel.Text.ToString(), combCapasitorType.Text.ToString(), Convert.ToDouble(textBox2.Text), Convert.ToDouble(tbCapasity.Text), Convert.ToDouble(textBox3.Text));

                    Proces.FormPicture(sortedcapas);

                    dataGridView1.DataSource = sortedcapas;
                    DataGridColumHide();
                    dataGridView1.Columns["btDetails"].DisplayIndex = dataGridView1.ColumnCount - 1;
                    btDetails.Visible = true;
                    break;

                case "Diode":

                    var diodes = Proces.ReadDetails<Diode>("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\DetailsData\\DiodesData.json");
                    var sorteddiodes = Proces.SortedDiode(diodes, tbModel.Text.ToString(), combDiodeShellType.Text.ToString(), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));

                    Proces.FormPicture(sorteddiodes);

                    dataGridView1.DataSource = sorteddiodes;
                    DataGridColumHide();
                    dataGridView1.Columns["btDetails"].DisplayIndex = dataGridView1.ColumnCount - 1;
                    btDetails.Visible = true;
                    break;
            }
        }
        private void combDetailType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Process = new DataProces();
            switch (combDetailType.Text.ToString())
            {
                case "Transistor":
                    Hide();
                    TransistorView();
                    break;
                case "Capacitor":
                    Hide();
                    CapasitorView();
                    break;
                case "Diode":
                    Hide();
                    DiodeView();
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
            var type = combDetailType.Text.ToString();
            string password = "1";
            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please select detail type");
            }
            else if (type == "Transistor")
            {
                PasswordForm passform = new PasswordForm(password, currentDetailList[0], type);
                passform.Show();
            }
            else if (type == "Capacitor")
            {
                PasswordForm passform = new PasswordForm(password, currentDetailList[1], type);
                passform.Show();
            }
            else if (type == "Diode")
            {
                PasswordForm passform = new PasswordForm(password, currentDetailList[2], type);
                passform.Show();
            }

        }

        private void lbCapasitorType_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

