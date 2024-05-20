namespace Handbook_of_amaters_try
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            btSearch.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            combTransistorType.Visible = false;
            lbTransistorType.Visible = false;
            lbVoltage.Visible = false;
            lbCurrent.Visible = false;
            imgColum.Visible = false;
            typeColum.Visible = false;
            voltageColum.Visible = false;
            currentColum.Visible = false;
            priceColum.Visible = false;
            capasityColum.Visible = false;
            allowebleTempColum.Visible = false;
            lbCapacitorType.Visible = false;
            lbCapasity.Visible = false;
            tbCapasity.Visible = false;
            combCapasitorType.Visible = false;
            lbAllowableTemp.Visible = false;
            btDetails.Visible = false;
            //lbModel.Visible = false;
            //tbModel.Visible = false;

        }
        public void TransistorView()
        {
            btSearch.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            combTransistorType.Visible = true;
            lbTransistorType.Visible = true;
            lbVoltage.Visible = true;
            lbCurrent.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            imgColum.Visible = true;
            typeColum.Visible = true;
            voltageColum.Visible = true;
            currentColum.Visible = true;
            priceColum.Visible = true;
            dataGridView1.RowTemplate.Height = 200;
            btDetails.Visible = true;
            lbModel.Visible = true;
            tbModel.Visible = true;
        }

        public void CapasitorView()
        {
            btSearch.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            lbCapacitorType.Visible = true;
            lbVoltage.Visible = true;
            lbCapasity.Visible = true;
            tbCapasity.Visible = true;
            combCapasitorType.Visible = true;
            lbAllowableTemp.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            tbCapasity.Text = "0";
            dataGridView1.RowTemplate.Height = 200;
            imgColum.Visible = true;
            typeColum.Visible = true;
            voltageColum.Visible = true;
            allowebleTempColum.Visible = true;
            capasityColum.Visible = true;
            priceColum.Visible = true;
            btDetails.Visible = true;
            lbModel.Visible = true;
            tbModel.Visible = true;
        }
        public void DataGridColumHide()
        {
            dataGridView1.Columns["Description"].Visible = false;
            dataGridView1.Columns["Link"].Visible = false;
            dataGridView1.Columns["imageLink"].Visible = false;

        }
        public void SetIconSize()
        {
            Bitmap b1 = new Bitmap("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\input-onlinebitmaptools.bmp");
            Bitmap b2 = new Bitmap(b1, new Size(50, 50));
            btAdmin.Image = b2;

        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btSearch = new Button();
            dataGridView1 = new DataGridView();
            lbMainDetailTypeSelect = new Label();
            combDetailType = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            combTransistorType = new ComboBox();
            lbCurrent = new Label();
            combCapasitorType = new ComboBox();
            lbAllowableTemp = new Label();
            lbCapasity = new Label();
            tbCapasity = new TextBox();
            btAdmin = new Button();
            lbVoltage = new Label();
            lbTransistorType = new Label();
            lbCapacitorType = new Label();
            lbModel = new Label();
            tbModel = new TextBox();
            imgColum = new DataGridViewImageColumn();
            typeColum = new DataGridViewTextBoxColumn();
            voltageColum = new DataGridViewTextBoxColumn();
            currentColum = new DataGridViewTextBoxColumn();
            capasityColum = new DataGridViewTextBoxColumn();
            allowebleTempColum = new DataGridViewTextBoxColumn();
            priceColum = new DataGridViewTextBoxColumn();
            btDetails = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btSearch
            // 
            resources.ApplyResources(btSearch, "btSearch");
            btSearch.Name = "btSearch";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { imgColum, typeColum, voltageColum, currentColum, capasityColum, allowebleTempColum, priceColum, btDetails });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbMainDetailTypeSelect
            // 
            resources.ApplyResources(lbMainDetailTypeSelect, "lbMainDetailTypeSelect");
            lbMainDetailTypeSelect.Name = "lbMainDetailTypeSelect";
            // 
            // combDetailType
            // 
            resources.ApplyResources(combDetailType, "combDetailType");
            combDetailType.FormattingEnabled = true;
            combDetailType.Items.AddRange(new object[] { resources.GetString("combDetailType.Items"), resources.GetString("combDetailType.Items1"), resources.GetString("combDetailType.Items2"), resources.GetString("combDetailType.Items3") });
            combDetailType.Name = "combDetailType";
            combDetailType.SelectedIndexChanged += combDetailType_SelectedIndexChanged;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            textBox2.TextChanged += TextChanged;
            textBox2.KeyPress += KeyPress;
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            textBox3.TextChanged += TextChanged;
            textBox3.KeyPress += KeyPress;
            // 
            // combTransistorType
            // 
            resources.ApplyResources(combTransistorType, "combTransistorType");
            combTransistorType.FormattingEnabled = true;
            combTransistorType.Items.AddRange(new object[] { resources.GetString("combTransistorType.Items"), resources.GetString("combTransistorType.Items1") });
            combTransistorType.Name = "combTransistorType";
            // 
            // lbCurrent
            // 
            resources.ApplyResources(lbCurrent, "lbCurrent");
            lbCurrent.Name = "lbCurrent";
            lbCurrent.Click += label2_Click;
            // 
            // combCapasitorType
            // 
            resources.ApplyResources(combCapasitorType, "combCapasitorType");
            combCapasitorType.FormattingEnabled = true;
            combCapasitorType.Items.AddRange(new object[] { resources.GetString("combCapasitorType.Items") });
            combCapasitorType.Name = "combCapasitorType";
            // 
            // lbAllowableTemp
            // 
            resources.ApplyResources(lbAllowableTemp, "lbAllowableTemp");
            lbAllowableTemp.Name = "lbAllowableTemp";
            // 
            // lbCapasity
            // 
            resources.ApplyResources(lbCapasity, "lbCapasity");
            lbCapasity.Name = "lbCapasity";
            // 
            // tbCapasity
            // 
            resources.ApplyResources(tbCapasity, "tbCapasity");
            tbCapasity.Name = "tbCapasity";
            tbCapasity.TextChanged += TextChanged;
            tbCapasity.KeyPress += KeyPress;
            // 
            // btAdmin
            // 
            resources.ApplyResources(btAdmin, "btAdmin");
            btAdmin.Image = Handbook_of_radio_amateurs.Properties.Resources.input_onlinebitmaptools;
            btAdmin.Name = "btAdmin";
            btAdmin.UseVisualStyleBackColor = true;
            btAdmin.Click += btAdmin_Click;
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
            // 
            // lbCapacitorType
            // 
            resources.ApplyResources(lbCapacitorType, "lbCapacitorType");
            lbCapacitorType.Name = "lbCapacitorType";
            // 
            // lbModel
            // 
            resources.ApplyResources(lbModel, "lbModel");
            lbModel.Name = "lbModel";
            // 
            // tbModel
            // 
            resources.ApplyResources(tbModel, "tbModel");
            tbModel.Name = "tbModel";
            // 
            // imgColum
            // 
            imgColum.DataPropertyName = "image";
            resources.ApplyResources(imgColum, "imgColum");
            imgColum.Name = "imgColum";
            // 
            // typeColum
            // 
            typeColum.DataPropertyName = "Model";
            resources.ApplyResources(typeColum, "typeColum");
            typeColum.Name = "typeColum";
            // 
            // voltageColum
            // 
            voltageColum.DataPropertyName = "Voltage";
            resources.ApplyResources(voltageColum, "voltageColum");
            voltageColum.Name = "voltageColum";
            // 
            // currentColum
            // 
            currentColum.DataPropertyName = "Current";
            resources.ApplyResources(currentColum, "currentColum");
            currentColum.Name = "currentColum";
            // 
            // capasityColum
            // 
            capasityColum.DataPropertyName = "Capasity";
            resources.ApplyResources(capasityColum, "capasityColum");
            capasityColum.Name = "capasityColum";
            // 
            // allowebleTempColum
            // 
            allowebleTempColum.DataPropertyName = "AllowableTemperature";
            resources.ApplyResources(allowebleTempColum, "allowebleTempColum");
            allowebleTempColum.Name = "allowebleTempColum";
            // 
            // priceColum
            // 
            priceColum.DataPropertyName = "Price";
            resources.ApplyResources(priceColum, "priceColum");
            priceColum.Name = "priceColum";
            // 
            // btDetails
            // 
            resources.ApplyResources(btDetails, "btDetails");
            btDetails.Name = "btDetails";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbModel);
            Controls.Add(lbModel);
            Controls.Add(lbCapacitorType);
            Controls.Add(lbTransistorType);
            Controls.Add(lbVoltage);
            Controls.Add(btAdmin);
            Controls.Add(tbCapasity);
            Controls.Add(lbCapasity);
            Controls.Add(lbAllowableTemp);
            Controls.Add(combCapasitorType);
            Controls.Add(lbCurrent);
            Controls.Add(combTransistorType);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(combDetailType);
            Controls.Add(lbMainDetailTypeSelect);
            Controls.Add(dataGridView1);
            Controls.Add(btSearch);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSearch;
        private DataGridView dataGridView1;
        private Label lbMainDetailTypeSelect;
        public ComboBox combDetailType;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox combTransistorType;
        private Label lbCurrent;
        private ComboBox combCapasitorType;
        private Label lbAllowableTemp;
        private Label lbCapasity;
        private TextBox tbCapasity;
        private Button btAdmin;
        private Label lbVoltage;
        private Label lbTransistorType;
        private Label lbCapacitorType;
        public Label lbModel;
        public TextBox tbModel;
        private DataGridViewImageColumn imgColum;
        private DataGridViewTextBoxColumn typeColum;
        private DataGridViewTextBoxColumn voltageColum;
        private DataGridViewTextBoxColumn currentColum;
        private DataGridViewTextBoxColumn capasityColum;
        private DataGridViewTextBoxColumn allowebleTempColum;
        private DataGridViewTextBoxColumn priceColum;
        private DataGridViewButtonColumn btDetails;
    }
}
