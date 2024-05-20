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
            lbVoltage.Visible = false;
            lbCurrent.Visible = false;
            lbCapasity.Visible = false;
            tbCapasity.Visible = false;
            combCapasitorType.Visible = false;
            lbAllowableTemp.Visible = false;
            combCapasitorType.Visible = false;
            tbCapasity.Visible= false;
            lbCapasity.Visible = false;
            lbAllowableTemp.Visible= false;

        }
        public void TransistorView()
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            combTransistorType.Visible = true;
            lbTransistorType.Visible = true;
            lbVoltage.Visible = true;
            lbCurrent.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            dataGridView1.RowTemplate.Height = 200;
        }

        public void CapasitorView()
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            lbVoltage.Visible = true;
            lbCapasity.Visible = true;
            tbCapasity.Visible = true;
            combCapasitorType.Visible = true;
            lbAllowableTemp.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            tbCapasity.Text = "0";
            dataGridView1.RowTemplate.Height = 200;
        }
        public void DiodeView()
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            lbCurrent.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            lbVoltage.Visible = true;
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            combDiodeShellType = new ComboBox();
            lbDiodeShellType = new Label();
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
            tbCapasity = new TextBox();
            lbCapasity = new Label();
            lbAllowableTemp = new Label();
            combCapasitorType = new ComboBox();
            lbCapasitorType = new Label();
            lbCurrent = new Label();
            lbVoltage = new Label();
            lbTransistorType = new Label();
            combTransistorType = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            btSave = new Button();
            dataGridView1 = new DataGridView();
            columDelete = new DataGridViewButtonColumn();
            lbName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // combDiodeShellType
            // 
            combDiodeShellType.FormattingEnabled = true;
            combDiodeShellType.Items.AddRange(new object[] { "DO-41", "DO-15", "DO-27", "DO-41" });
            combDiodeShellType.Location = new Point(15, 588);
            combDiodeShellType.Name = "combDiodeShellType";
            combDiodeShellType.Size = new Size(151, 28);
            combDiodeShellType.TabIndex = 68;
            // 
            // lbDiodeShellType
            // 
            lbDiodeShellType.AutoSize = true;
            lbDiodeShellType.ImeMode = ImeMode.NoControl;
            lbDiodeShellType.Location = new Point(15, 565);
            lbDiodeShellType.Name = "lbDiodeShellType";
            lbDiodeShellType.Size = new Size(159, 20);
            lbDiodeShellType.TabIndex = 67;
            lbDiodeShellType.Text = "Select diode shell type";
            // 
            // rtbDescription
            // 
            rtbDescription.BorderStyle = BorderStyle.FixedSingle;
            rtbDescription.Location = new Point(15, 392);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(336, 166);
            rtbDescription.TabIndex = 66;
            rtbDescription.Text = "";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.ImeMode = ImeMode.NoControl;
            lbDescription.Location = new Point(12, 355);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(123, 20);
            lbDescription.TabIndex = 65;
            lbDescription.Text = "Enter Description";
            // 
            // lbLink
            // 
            lbLink.AutoSize = true;
            lbLink.ImeMode = ImeMode.NoControl;
            lbLink.Location = new Point(13, 276);
            lbLink.Name = "lbLink";
            lbLink.Size = new Size(163, 20);
            lbLink.TabIndex = 64;
            lbLink.Text = "Enter market place Link";
            // 
            // tbLink
            // 
            tbLink.Location = new Point(15, 310);
            tbLink.Name = "tbLink";
            tbLink.Size = new Size(336, 27);
            tbLink.TabIndex = 63;
            // 
            // lbImageLInk
            // 
            lbImageLInk.AutoSize = true;
            lbImageLInk.ImeMode = ImeMode.NoControl;
            lbImageLInk.Location = new Point(13, 194);
            lbImageLInk.Name = "lbImageLInk";
            lbImageLInk.Size = new Size(116, 20);
            lbImageLInk.TabIndex = 62;
            lbImageLInk.Text = "Enter Image link";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.ImeMode = ImeMode.NoControl;
            lbPrice.Location = new Point(15, 113);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(79, 20);
            lbPrice.TabIndex = 61;
            lbPrice.Text = "Enter Price";
            // 
            // tbImageLink
            // 
            tbImageLink.Location = new Point(13, 227);
            tbImageLink.Name = "tbImageLink";
            tbImageLink.Size = new Size(338, 27);
            tbImageLink.TabIndex = 60;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(13, 145);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(125, 27);
            tbPrice.TabIndex = 59;
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 67);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 58;
            // 
            // btAdd
            // 
            btAdd.ImeMode = ImeMode.NoControl;
            btAdd.Location = new Point(143, 757);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 57;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // tbCapasity
            // 
            tbCapasity.Location = new Point(13, 705);
            tbCapasity.Name = "tbCapasity";
            tbCapasity.Size = new Size(125, 27);
            tbCapasity.TabIndex = 56;
            // 
            // lbCapasity
            // 
            lbCapasity.AutoSize = true;
            lbCapasity.ImeMode = ImeMode.NoControl;
            lbCapasity.Location = new Point(15, 682);
            lbCapasity.Name = "lbCapasity";
            lbCapasity.Size = new Size(65, 20);
            lbCapasity.TabIndex = 55;
            lbCapasity.Text = "Capasity";
            // 
            // lbAllowableTemp
            // 
            lbAllowableTemp.AutoSize = true;
            lbAllowableTemp.ImeMode = ImeMode.NoControl;
            lbAllowableTemp.Location = new Point(11, 629);
            lbAllowableTemp.Name = "lbAllowableTemp";
            lbAllowableTemp.Size = new Size(161, 20);
            lbAllowableTemp.TabIndex = 54;
            lbAllowableTemp.Text = "Available temperature ";
            // 
            // combCapasitorType
            // 
            combCapasitorType.FormattingEnabled = true;
            combCapasitorType.Items.AddRange(new object[] { "Low voltage" });
            combCapasitorType.Location = new Point(13, 588);
            combCapasitorType.Name = "combCapasitorType";
            combCapasitorType.Size = new Size(151, 28);
            combCapasitorType.TabIndex = 53;
            // 
            // lbCapasitorType
            // 
            lbCapasitorType.AutoSize = true;
            lbCapasitorType.ImeMode = ImeMode.NoControl;
            lbCapasitorType.Location = new Point(12, 565);
            lbCapasitorType.Name = "lbCapasitorType";
            lbCapasitorType.Size = new Size(148, 20);
            lbCapasitorType.TabIndex = 52;
            lbCapasitorType.Text = "Select capacitor type";
            // 
            // lbCurrent
            // 
            lbCurrent.AutoSize = true;
            lbCurrent.ImeMode = ImeMode.NoControl;
            lbCurrent.Location = new Point(12, 629);
            lbCurrent.Name = "lbCurrent";
            lbCurrent.RightToLeft = RightToLeft.No;
            lbCurrent.Size = new Size(57, 20);
            lbCurrent.TabIndex = 51;
            lbCurrent.Text = "Current";
            lbCurrent.Visible = false;
            // 
            // lbVoltage
            // 
            lbVoltage.AutoSize = true;
            lbVoltage.ImeMode = ImeMode.NoControl;
            lbVoltage.Location = new Point(180, 629);
            lbVoltage.Name = "lbVoltage";
            lbVoltage.Size = new Size(60, 20);
            lbVoltage.TabIndex = 50;
            lbVoltage.Text = "Voltage";
            lbVoltage.Visible = false;
            // 
            // lbTransistorType
            // 
            lbTransistorType.AutoSize = true;
            lbTransistorType.ImeMode = ImeMode.NoControl;
            lbTransistorType.Location = new Point(11, 565);
            lbTransistorType.Name = "lbTransistorType";
            lbTransistorType.Size = new Size(147, 20);
            lbTransistorType.TabIndex = 49;
            lbTransistorType.Text = "Select transistor type";
            lbTransistorType.UseWaitCursor = true;
            lbTransistorType.Visible = false;
            // 
            // combTransistorType
            // 
            combTransistorType.FormattingEnabled = true;
            combTransistorType.Items.AddRange(new object[] { "Field-effect", "Bipolar" });
            combTransistorType.Location = new Point(13, 588);
            combTransistorType.Name = "combTransistorType";
            combTransistorType.Size = new Size(151, 28);
            combTransistorType.TabIndex = 48;
            combTransistorType.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(13, 652);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 47;
            textBox3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 652);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 46;
            textBox2.Visible = false;
            textBox2.WordWrap = false;
            // 
            // btSave
            // 
            btSave.ImeMode = ImeMode.NoControl;
            btSave.Location = new Point(13, 757);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 45;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columDelete });
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(390, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(768, 827);
            dataGridView1.TabIndex = 44;
            // 
            // columDelete
            // 
            columDelete.HeaderText = "Delete";
            columDelete.MinimumWidth = 6;
            columDelete.Name = "columDelete";
            columDelete.Width = 125;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ImeMode = ImeMode.NoControl;
            lbName.Location = new Point(11, 44);
            lbName.Name = "lbName";
            lbName.Size = new Size(94, 20);
            lbName.TabIndex = 69;
            lbName.Text = "Enter Model ";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 827);
            Controls.Add(lbName);
            Controls.Add(combDiodeShellType);
            Controls.Add(lbDiodeShellType);
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
            Controls.Add(tbCapasity);
            Controls.Add(lbCapasity);
            Controls.Add(lbAllowableTemp);
            Controls.Add(combCapasitorType);
            Controls.Add(lbCapasitorType);
            Controls.Add(lbCurrent);
            Controls.Add(lbVoltage);
            Controls.Add(lbTransistorType);
            Controls.Add(combTransistorType);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btSave);
            Controls.Add(dataGridView1);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combDiodeShellType;
        private Label lbDiodeShellType;
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
        private TextBox tbCapasity;
        private Label lbCapasity;
        private Label lbAllowableTemp;
        private ComboBox combCapasitorType;
        private Label lbCapasitorType;
        private Label lbCurrent;
        private Label lbVoltage;
        private Label lbTransistorType;
        private ComboBox combTransistorType;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btSave;
        public DataGridView dataGridView1;
        private DataGridViewButtonColumn columDelete;
        private Label lbName;
    }
}