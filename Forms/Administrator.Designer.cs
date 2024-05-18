namespace Handbook_of_amaters_try.Forms
{
    partial class Administrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            columDelete = new DataGridViewButtonColumn();
            btSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columDelete });
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(308, 0);
            dataGridView1.MaximumSize = new Size(768, 518);
            dataGridView1.MinimumSize = new Size(768, 518);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(768, 518);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += Action;
            // 
            // columDelete
            // 
            columDelete.HeaderText = "Delete";
            columDelete.MinimumWidth = 6;
            columDelete.Name = "columDelete";
            columDelete.Width = 125;
            // 
            // btSave
            // 
            btSave.Location = new Point(23, 461);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 1;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // Administrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 517);
            Controls.Add(btSave);
            Controls.Add(dataGridView1);
            Name = "Administrator";
            Text = "Administration window";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private DataGridViewButtonColumn columDelete;
        private Button btSave;
    }
}