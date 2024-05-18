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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Handbook_of_amaters_try.Forms
{
    public partial class Administrator : Form
    {
        private DataProces dataProces;
        private List<object> data;
        private string currentType;
        public Administrator(string type, List<object> details)
        {
            InitializeComponent();
            data = details;
            currentType = type;
            dataGridView1.DataSource = data;
            SetCurrentDetailProperty();
        }

        private void Update(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Action(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == columDelete.Index)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                var selectedItem = selectedRow.DataBoundItem;
                Delete(selectedItem);

            }
            else
            {
                // Continue
            }
        }
        private void Delete<T>(T item)
        {
            try
            {
                if (currentType == "Transistor")
                {
                    Transistor transistorItem = item as Transistor;
                    if (transistorItem != null)
                    {
                        data.Remove(transistorItem);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = data;
                    }
                }
                else if (currentType == "Capacitor")
                {
                    Capasitor capasitorItem = item as Capasitor;
                    if (capasitorItem != null)
                    {
                        data.Remove(capasitorItem);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = data;
                    }
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Problem with removal, contact a specialist");
            }
        }
        private void Add()
        {
            if (currentType == "Transistor")
            {
                data.Add(new Transistor() {
                   Name = Convert.ToString(tbName.Text),
                   Price= Convert.ToInt32(tbPrice.Text),
                   Description = Convert.ToString(rtbDescription.Text),
                   Link = Convert.ToString(tbLink.Text),
                   imageLink = Convert.ToString(tbImageLink.Text),
                   Type =Convert.ToString(combTransistorType.Text),
                   Voltage =Convert.ToDouble(textBox2.Text),
                   Current = Convert.ToDouble(textBox3.Text)
                }) ;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }
        }
        public void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(data, options);

            File.WriteAllText("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\DetailsData\\TransistorData.json", jsonString);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void lbCurrent_Click(object sender, EventArgs e)
        {

        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbDescription_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
    }


}
