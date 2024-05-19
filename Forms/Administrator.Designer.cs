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
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columDelete });
            dataGridView1.Name = "dataGridView1";
            dataGridView1.CellContentClick += Action;
            // 
            // columDelete
            // 
            resources.ApplyResources(columDelete, "columDelete");
            columDelete.Name = "columDelete";
            // 
            // btSave
            // 
            resources.ApplyResources(btSave, "btSave");
            btSave.Name = "btSave";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // tbCapasity
            // 
            resources.ApplyResources(tbCapasity, "tbCapasity");
            tbCapasity.Name = "tbCapasity";
            // 
            // lbCapasity
            // 
            resources.ApplyResources(lbCapasity, "lbCapasity");
            lbCapasity.Name = "lbCapasity";
            // 
            // lbAllowableTemp
            // 
            resources.ApplyResources(lbAllowableTemp, "lbAllowableTemp");
            lbAllowableTemp.Name = "lbAllowableTemp";
            // 
            // combCapasitorType
            // 
            resources.ApplyResources(combCapasitorType, "combCapasitorType");
            combCapasitorType.FormattingEnabled = true;
            combCapasitorType.Items.AddRange(new object[] { resources.GetString("combCapasitorType.Items") });
            combCapasitorType.Name = "combCapasitorType";
            // 
            // lbCapasitorType
            // 
            resources.ApplyResources(lbCapasitorType, "lbCapasitorType");
            lbCapasitorType.Name = "lbCapasitorType";
            // 
            // lbCurrent
            // 
            resources.ApplyResources(lbCurrent, "lbCurrent");
            lbCurrent.Name = "lbCurrent";
            lbCurrent.Click += lbCurrent_Click;
            // 
            // lbVoltage
            // 
            resources.ApplyResources(lbVoltage, "lbVoltage");
            lbVoltage.Name = "lbVoltage";
            // 
            // lbTransistorType
            // 
            resources.ApplyResources(lbTransistorType, "lbTransistorType");
            lbTransistorType.Name = "lbTransistorType";
            lbTransistorType.UseWaitCursor = true;
            // 
            // combTransistorType
            // 
            resources.ApplyResources(combTransistorType, "combTransistorType");
            combTransistorType.FormattingEnabled = true;
            combTransistorType.Items.AddRange(new object[] { resources.GetString("combTransistorType.Items"), resources.GetString("combTransistorType.Items1") });
            combTransistorType.Name = "combTransistorType";
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // btAdd
            // 
            resources.ApplyResources(btAdd, "btAdd");
            btAdd.Name = "btAdd";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // tbName
            // 
            resources.ApplyResources(tbName, "tbName");
            tbName.Name = "tbName";
            // 
            // tbPrice
            // 
            resources.ApplyResources(tbPrice, "tbPrice");
            tbPrice.Name = "tbPrice";
            tbPrice.TextChanged += tbPrice_TextChanged;
            // 
            // tbImageLink
            // 
            resources.ApplyResources(tbImageLink, "tbImageLink");
            tbImageLink.Name = "tbImageLink";
            // 
            // lbName
            // 
            resources.ApplyResources(lbName, "lbName");
            lbName.Name = "lbName";
            // 
            // lbPrice
            // 
            resources.ApplyResources(lbPrice, "lbPrice");
            lbPrice.Name = "lbPrice";
            // 
            // lbImageLInk
            // 
            resources.ApplyResources(lbImageLInk, "lbImageLInk");
            lbImageLInk.Name = "lbImageLInk";
            // 
            // tbLink
            // 
            resources.ApplyResources(tbLink, "tbLink");
            tbLink.Name = "tbLink";
            // 
            // lbLink
            // 
            resources.ApplyResources(lbLink, "lbLink");
            lbLink.Name = "lbLink";
            // 
            // lbDescription
            // 
            resources.ApplyResources(lbDescription, "lbDescription");
            lbDescription.Name = "lbDescription";
            lbDescription.Click += lbDescription_Click;
            // 
            // rtbDescription
            // 
            resources.ApplyResources(rtbDescription, "rtbDescription");
            rtbDescription.BorderStyle = BorderStyle.FixedSingle;
            rtbDescription.Name = "rtbDescription";
            // 
            // Administrator
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "Administrator";
            FormClosing += Administrator_FormClosing;
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