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
        public void TakeCurrentData(List<Details> list)
        {

        }
        public void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(data, options);

            File.WriteAllText("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\SaveMethodTest.json", jsonString);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }


}
