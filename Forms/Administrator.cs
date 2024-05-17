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

namespace Handbook_of_amaters_try.Forms
{
    public partial class Administrator : Form
    {
        private DataProces dataProces;
        private List<dynamic> data;
        public Administrator()
        {
            InitializeComponent();
        }

        private void Update(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Action(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == columDelete.Index)
            {
                //DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                //dynamic selectedItem = selectedRow.DataBoundItem;
                //data.Remove(selectedItem);

            }
            else
            {
                
            }
        }
        private void Delete(List<dynamic> item)
        {
            
        }
    }
}
