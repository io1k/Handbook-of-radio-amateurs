using Handbook_of_amaters_try;

namespace Handbook_of_radio_amateurs.Forms
{
    partial class AdminForm
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
        public void Hide()
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            combTransistorType.Visible = false;
            lbTransistorType.Visible = false;
            lbCapacitorType.Visible = false;
            tbCapasity.Visible = false;
            combCapasitorType.Visible = false;
            lbDiodeShellType.Visible = false;
            combDiodeShellType.Visible = false;
            lbMain1.Text = "";
            lbMain2.Text = "";
            lbMain3.Text = "";
        }
        public void TransistorView()
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            combTransistorType.Visible = true;
            lbTransistorType.Visible = true;
            dataGridView1.RowTemplate.Height = 150;
            textBox2.Text = "0";
            textBox3.Text = "0";
            lbMain1.Text = "Voltage";
            lbMain2.Text = "Current";
        }

        public void CapasitorView()
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            lbCapacitorType.Visible = true;
            tbCapasity.Visible = true;
            combCapasitorType.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            tbCapasity.Text = "0";
            dataGridView1.RowTemplate.Height = 150;
            lbMain1.Text = "Voltage";
            lbMain2.Text = "Available temperature";
            lbMain3.Text = "Capasity";
        }
        public void DiodeView()
        {
            lbDiodeShellType.Visible = true;
            combDiodeShellType.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            dataGridView1.RowTemplate.Height = 150;
            textBox2.Text = "0";
            textBox3.Text = "0";
            lbMain2.Text = "Current";
            lbMain1.Text = "Voltage";

        }
        public void ResistorView()
        {
            lbMain2.Text = "Resistance";
            lbMain1.Text = "Tolerance";
            lbMain3.Text = "Power";
            tbCapasity.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            dataGridView1.RowTemplate.Height = 150;
            textBox2.Text = "0";
            textBox3.Text = "0";
            tbCapasity.Text = "0";
            
        }
        public void SetCurrentDetailProperty()
        {
            if (currentType == "Transistor")
            {
                Hide();
                TransistorView();
            }
            else if (currentType == "Capacitor")
            {
                Hide();
                CapasitorView();
            }
            else if (currentType == "Diode")
            {
                Hide();
                DiodeView();
            }
            else if (currentType == "Resistor")
            {
                Hide();
                ResistorView();
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbDescription = new RichTextBox();
            lbDescription = new Label();
            lbLink = new Label();
            tbLink = new TextBox();
            lbImageLInk = new Label();
            lbPrice = new Label();
            tbImageLink = new TextBox();
            tbPrice = new TextBox();
            tbName = new TextBox();
            btAdd = new Button();
            btSave = new Button();
            dataGridView1 = new DataGridView();
            columDelete = new DataGridViewButtonColumn();
            lbName = new Label();
            lbMain3 = new Label();
            lbMain2 = new Label();
            lbMain1 = new Label();
            combDiodeShellType = new ComboBox();
            lbDiodeShellType = new Label();
            lbCapacitorType = new Label();
            lbTransistorType = new Label();
            tbCapasity = new TextBox();
            combCapasitorType = new ComboBox();
            combTransistorType = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // rtbDescription
            // 
            rtbDescription.BorderStyle = BorderStyle.FixedSingle;
            rtbDescription.Location = new Point(10, 279);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(336, 98);
            rtbDescription.TabIndex = 66;
            rtbDescription.Text = "";
            // 
            // lbDescription
            // 
            lbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbDescription.AutoSize = true;
            lbDescription.ImeMode = ImeMode.NoControl;
            lbDescription.Location = new Point(12, 256);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(123, 20);
            lbDescription.TabIndex = 65;
            lbDescription.Text = "Enter Description";
            // 
            // lbLink
            // 
            lbLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbLink.AutoSize = true;
            lbLink.ImeMode = ImeMode.NoControl;
            lbLink.Location = new Point(12, 203);
            lbLink.Name = "lbLink";
            lbLink.Size = new Size(163, 20);
            lbLink.TabIndex = 64;
            lbLink.Text = "Enter market place Link";
            // 
            // tbLink
            // 
            tbLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbLink.Location = new Point(12, 226);
            tbLink.Name = "tbLink";
            tbLink.Size = new Size(336, 27);
            tbLink.TabIndex = 63;
            // 
            // lbImageLInk
            // 
            lbImageLInk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbImageLInk.AutoSize = true;
            lbImageLInk.ImeMode = ImeMode.NoControl;
            lbImageLInk.Location = new Point(12, 150);
            lbImageLInk.Name = "lbImageLInk";
            lbImageLInk.Size = new Size(116, 20);
            lbImageLInk.TabIndex = 62;
            lbImageLInk.Text = "Enter Image link";
            // 
            // lbPrice
            // 
            lbPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbPrice.AutoSize = true;
            lbPrice.ImeMode = ImeMode.NoControl;
            lbPrice.Location = new Point(10, 97);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(79, 20);
            lbPrice.TabIndex = 61;
            lbPrice.Text = "Enter Price";
            // 
            // tbImageLink
            // 
            tbImageLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbImageLink.Location = new Point(12, 173);
            tbImageLink.Name = "tbImageLink";
            tbImageLink.Size = new Size(338, 27);
            tbImageLink.TabIndex = 60;
            // 
            // tbPrice
            // 
            tbPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbPrice.Location = new Point(12, 120);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(125, 27);
            tbPrice.TabIndex = 59;
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbName.Location = new Point(12, 67);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 58;
            // 
            // btAdd
            // 
            btAdd.ImeMode = ImeMode.NoControl;
            btAdd.Location = new Point(143, 576);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 57;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btSave
            // 
            btSave.ImeMode = ImeMode.NoControl;
            btSave.Location = new Point(13, 576);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 45;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columDelete });
            dataGridView1.Location = new Point(356, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 630);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellContentClick += Action;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // columDelete
            // 
            columDelete.HeaderText = "Delete";
            columDelete.MinimumWidth = 6;
            columDelete.Name = "columDelete";
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbName.AutoSize = true;
            lbName.ImeMode = ImeMode.NoControl;
            lbName.Location = new Point(10, 44);
            lbName.Name = "lbName";
            lbName.Size = new Size(94, 20);
            lbName.TabIndex = 69;
            lbName.Text = "Enter Model ";
            // 
            // lbMain3
            // 
            lbMain3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbMain3.AutoSize = true;
            lbMain3.Location = new Point(161, 437);
            lbMain3.Name = "lbMain3";
            lbMain3.Size = new Size(0, 20);
            lbMain3.TabIndex = 81;
            // 
            // lbMain2
            // 
            lbMain2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbMain2.AutoSize = true;
            lbMain2.Location = new Point(12, 490);
            lbMain2.Name = "lbMain2";
            lbMain2.Size = new Size(0, 20);
            lbMain2.TabIndex = 80;
            // 
            // lbMain1
            // 
            lbMain1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbMain1.AutoSize = true;
            lbMain1.Location = new Point(12, 434);
            lbMain1.Name = "lbMain1";
            lbMain1.Size = new Size(0, 20);
            lbMain1.TabIndex = 79;
            // 
            // combDiodeShellType
            // 
            combDiodeShellType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            combDiodeShellType.FormattingEnabled = true;
            combDiodeShellType.Items.AddRange(new object[] { "DO-41", "DO-15", "DO-27", "DO-41" });
            combDiodeShellType.Location = new Point(10, 403);
            combDiodeShellType.Name = "combDiodeShellType";
            combDiodeShellType.Size = new Size(127, 28);
            combDiodeShellType.TabIndex = 78;
            // 
            // lbDiodeShellType
            // 
            lbDiodeShellType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbDiodeShellType.AutoSize = true;
            lbDiodeShellType.Location = new Point(10, 380);
            lbDiodeShellType.Name = "lbDiodeShellType";
            lbDiodeShellType.Size = new Size(159, 20);
            lbDiodeShellType.TabIndex = 77;
            lbDiodeShellType.Text = "Select diode shell type";
            // 
            // lbCapacitorType
            // 
            lbCapacitorType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbCapacitorType.AutoSize = true;
            lbCapacitorType.ImeMode = ImeMode.NoControl;
            lbCapacitorType.Location = new Point(10, 380);
            lbCapacitorType.Name = "lbCapacitorType";
            lbCapacitorType.Size = new Size(148, 20);
            lbCapacitorType.TabIndex = 76;
            lbCapacitorType.Text = "Select capacitor type";
            // 
            // lbTransistorType
            // 
            lbTransistorType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbTransistorType.AutoSize = true;
            lbTransistorType.ImeMode = ImeMode.NoControl;
            lbTransistorType.Location = new Point(10, 380);
            lbTransistorType.Name = "lbTransistorType";
            lbTransistorType.Size = new Size(147, 20);
            lbTransistorType.TabIndex = 75;
            lbTransistorType.Text = "Select transistor type";
            // 
            // tbCapasity
            // 
            tbCapasity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbCapasity.Location = new Point(161, 460);
            tbCapasity.Name = "tbCapasity";
            tbCapasity.Size = new Size(125, 27);
            tbCapasity.TabIndex = 74;
            tbCapasity.TextChanged += TextChanged;
            tbCapasity.KeyPress += KeyPress;
            // 
            // combCapasitorType
            // 
            combCapasitorType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            combCapasitorType.FormattingEnabled = true;
            combCapasitorType.Items.AddRange(new object[] { "Electrolytic", "", "Aluminum polymer", "", "Electrolytic LOW ESR", "", "Electrolytically large", "", "Electrolytic SMD" });
            combCapasitorType.Location = new Point(10, 403);
            combCapasitorType.Name = "combCapasitorType";
            combCapasitorType.Size = new Size(125, 28);
            combCapasitorType.TabIndex = 73;
            // 
            // combTransistorType
            // 
            combTransistorType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            combTransistorType.FormattingEnabled = true;
            combTransistorType.Items.AddRange(new object[] { "Field-effect", "Bipolar" });
            combTransistorType.Location = new Point(10, 403);
            combTransistorType.Name = "combTransistorType";
            combTransistorType.Size = new Size(127, 28);
            combTransistorType.TabIndex = 72;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.Location = new Point(10, 513);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 71;
            textBox3.TextChanged += TextChanged;
            textBox3.KeyPress += KeyPress;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(10, 460);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 70;
            textBox2.WordWrap = false;
            textBox2.TextChanged += TextChanged;
            textBox2.KeyPress += KeyPress;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 630);
            Controls.Add(lbMain3);
            Controls.Add(lbMain2);
            Controls.Add(lbMain1);
            Controls.Add(combDiodeShellType);
            Controls.Add(lbDiodeShellType);
            Controls.Add(lbCapacitorType);
            Controls.Add(lbTransistorType);
            Controls.Add(tbCapasity);
            Controls.Add(combCapasitorType);
            Controls.Add(combTransistorType);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lbName);
            Controls.Add(rtbDescription);
            Controls.Add(lbDescription);
            Controls.Add(lbLink);
            Controls.Add(tbLink);
            Controls.Add(lbImageLInk);
            Controls.Add(lbPrice);
            Controls.Add(tbImageLink);
            Controls.Add(tbPrice);
            Controls.Add(tbName);
            Controls.Add(btAdd);
            Controls.Add(btSave);
            Controls.Add(dataGridView1);
            MaximumSize = new Size(1300, 950);
            MinimumSize = new Size(1176, 677);
            Name = "AdminForm";
            Text = "AdminForm";
            FormClosing += Administrator_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtbDescription;
        private Label lbDescription;
        private Label lbLink;
        private TextBox tbLink;
        private Label lbImageLInk;
        private Label lbPrice;
        private TextBox tbImageLink;
        private TextBox tbPrice;
        private TextBox tbName;
        private Button btAdd;
        private Button btSave;
        public DataGridView dataGridView1;
        private DataGridViewButtonColumn columDelete;
        private Label lbName;
        private Label lbMain3;
        private Label lbMain2;
        private Label lbMain1;
        private ComboBox combDiodeShellType;
        private Label lbDiodeShellType;
        private Label lbCapacitorType;
        private Label lbTransistorType;
        private TextBox tbCapasity;
        private ComboBox combCapasitorType;
        private ComboBox combTransistorType;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}