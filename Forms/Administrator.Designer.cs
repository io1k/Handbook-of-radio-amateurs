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
        public void Hide()
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            combTransistorType.Visible = false;
            lbTransistorType.Visible = false;
            lbVoltage.Visible = false;
            lbCurrent.Visible = false;
            lbCapasitorType.Visible = false;
            lbCapasitorType.Visible = false;
            lbCapasity.Visible = false;
            tbCapasity.Visible = false;
            combCapasitorType.Visible = false;
            lbAllowableTemp.Visible = false;

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
        }

        public void CapasitorView()
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            lbCapasitorType.Visible = true;
            lbVoltage.Visible = true;
            lbCapasitorType.Visible = true;
            lbCapasity.Visible = true;
            tbCapasity.Visible = true;
            combCapasitorType.Visible = true;
            lbAllowableTemp.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            tbCapasity.Text = "0";
            dataGridView1.RowTemplate.Height = 200;
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
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            dataGridView1 = new DataGridView();
            columDelete = new DataGridViewButtonColumn();
            btSave = new Button();
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
            btAdd = new Button();
            tbName = new TextBox();
            tbPrice = new TextBox();
            tbImageLink = new TextBox();
            lbName = new Label();
            lbPrice = new Label();
            lbImageLInk = new Label();
            tbLink = new TextBox();
            lbLink = new Label();
            lbDescription = new Label();
            rtbDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columDelete });
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(379, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(768, 798);
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
            btSave.Location = new Point(24, 757);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 1;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // tbCapasity
            // 
            tbCapasity.Location = new Point(23, 724);
            tbCapasity.Name = "tbCapasity";
            tbCapasity.Size = new Size(125, 27);
            tbCapasity.TabIndex = 28;
            // 
            // lbCapasity
            // 
            lbCapasity.AutoSize = true;
            lbCapasity.Location = new Point(24, 691);
            lbCapasity.Name = "lbCapasity";
            lbCapasity.Size = new Size(65, 20);
            lbCapasity.TabIndex = 27;
            lbCapasity.Text = "Capasity";
            // 
            // lbAllowableTemp
            // 
            lbAllowableTemp.AutoSize = true;
            lbAllowableTemp.Location = new Point(26, 629);
            lbAllowableTemp.Name = "lbAllowableTemp";
            lbAllowableTemp.Size = new Size(161, 20);
            lbAllowableTemp.TabIndex = 26;
            lbAllowableTemp.Text = "Available temperature ";
            // 
            // combCapasitorType
            // 
            combCapasitorType.FormattingEnabled = true;
            combCapasitorType.Items.AddRange(new object[] { "Low voltage" });
            combCapasitorType.Location = new Point(24, 598);
            combCapasitorType.Name = "combCapasitorType";
            combCapasitorType.Size = new Size(151, 28);
            combCapasitorType.TabIndex = 25;
            // 
            // lbCapasitorType
            // 
            lbCapasitorType.AutoSize = true;
            lbCapasitorType.Location = new Point(23, 565);
            lbCapasitorType.Name = "lbCapasitorType";
            lbCapasitorType.Size = new Size(148, 20);
            lbCapasitorType.TabIndex = 24;
            lbCapasitorType.Text = "Select capacitor type";
            // 
            // lbCurrent
            // 
            lbCurrent.AutoSize = true;
            lbCurrent.Location = new Point(23, 629);
            lbCurrent.Name = "lbCurrent";
            lbCurrent.RightToLeft = RightToLeft.No;
            lbCurrent.Size = new Size(57, 20);
            lbCurrent.TabIndex = 23;
            lbCurrent.Text = "Current";
            lbCurrent.Visible = false;
            lbCurrent.Click += lbCurrent_Click;
            // 
            // lbVoltage
            // 
            lbVoltage.AutoSize = true;
            lbVoltage.Location = new Point(193, 629);
            lbVoltage.Name = "lbVoltage";
            lbVoltage.Size = new Size(60, 20);
            lbVoltage.TabIndex = 22;
            lbVoltage.Text = "Voltage";
            lbVoltage.Visible = false;
            // 
            // lbTransistorType
            // 
            lbTransistorType.AutoSize = true;
            lbTransistorType.Location = new Point(22, 565);
            lbTransistorType.Name = "lbTransistorType";
            lbTransistorType.Size = new Size(147, 20);
            lbTransistorType.TabIndex = 21;
            lbTransistorType.Text = "Select transistor type";
            lbTransistorType.UseWaitCursor = true;
            lbTransistorType.Visible = false;
            // 
            // combTransistorType
            // 
            combTransistorType.FormattingEnabled = true;
            combTransistorType.Items.AddRange(new object[] { "Field-effect", "Bipolar" });
            combTransistorType.Location = new Point(24, 598);
            combTransistorType.Name = "combTransistorType";
            combTransistorType.Size = new Size(151, 28);
            combTransistorType.TabIndex = 20;
            combTransistorType.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 661);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 19;
            textBox3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 662);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 18;
            textBox2.Visible = false;
            textBox2.WordWrap = false;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(154, 757);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 29;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(23, 67);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 30;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(24, 145);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(125, 27);
            tbPrice.TabIndex = 31;
            tbPrice.TextChanged += tbPrice_TextChanged;
            // 
            // tbImageLink
            // 
            tbImageLink.Location = new Point(24, 227);
            tbImageLink.Name = "tbImageLink";
            tbImageLink.Size = new Size(338, 27);
            tbImageLink.TabIndex = 32;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(24, 34);
            lbName.Name = "lbName";
            lbName.Size = new Size(94, 20);
            lbName.TabIndex = 33;
            lbName.Text = "Enter Model ";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(26, 113);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(79, 20);
            lbPrice.TabIndex = 34;
            lbPrice.Text = "Enter Price";
            // 
            // lbImageLInk
            // 
            lbImageLInk.AutoSize = true;
            lbImageLInk.Location = new Point(24, 194);
            lbImageLInk.Name = "lbImageLInk";
            lbImageLInk.Size = new Size(116, 20);
            lbImageLInk.TabIndex = 35;
            lbImageLInk.Text = "Enter Image link";
            // 
            // tbLink
            // 
            tbLink.Location = new Point(26, 310);
            tbLink.Name = "tbLink";
            tbLink.Size = new Size(125, 27);
            tbLink.TabIndex = 36;
            // 
            // lbLink
            // 
            lbLink.AutoSize = true;
            lbLink.Location = new Point(24, 276);
            lbLink.Name = "lbLink";
            lbLink.Size = new Size(163, 20);
            lbLink.TabIndex = 37;
            lbLink.Text = "Enter market place Link";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(23, 355);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(123, 20);
            lbDescription.TabIndex = 38;
            lbDescription.Text = "Enter Description";
            lbDescription.Click += lbDescription_Click;
            // 
            // rtbDescription
            // 
            rtbDescription.BorderStyle = BorderStyle.FixedSingle;
            rtbDescription.Location = new Point(26, 392);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(336, 166);
            rtbDescription.TabIndex = 39;
            rtbDescription.Text = "";
            // 
            // Administrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 798);
            Controls.Add(rtbDescription);
            Controls.Add(lbDescription);
            Controls.Add(lbLink);
            Controls.Add(tbLink);
            Controls.Add(lbImageLInk);
            Controls.Add(lbPrice);
            Controls.Add(lbName);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1165, 845);
            MinimumSize = new Size(1165, 845);
            Name = "Administrator";
            Text = "Administration window";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridView1;
        private DataGridViewButtonColumn columDelete;
        private Button btSave;
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
        private Button btAdd;
        private TextBox tbName;
        private TextBox tbPrice;
        private TextBox tbImageLink;
        private Label lbName;
        private Label lbPrice;
        private Label lbImageLInk;
        private TextBox tbLink;
        private Label lbLink;
        private Label lbDescription;
        private RichTextBox rtbDescription;
    }
}