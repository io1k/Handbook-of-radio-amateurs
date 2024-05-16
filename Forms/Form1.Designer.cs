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
            priceColum.Visible = false ;
            capasityColum.Visible = false;
            allowebleTempColum.Visible = false;
            lbCapasitorType.Visible = false;
            lbCapasitorType.Visible = false;
            lbCapasity.Visible = false;
            tbCapasity.Visible = false;
            combCapasitorType.Visible = false;
            lbAllowableTemp.Visible = false;
            btDetails.Visible = false;

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
        }

        public void CapasitorView()
        {
            btSearch.Visible = true;
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
            imgColum.Visible = true;
            typeColum.Visible = true;
            voltageColum.Visible = true;
            allowebleTempColum.Visible = true;
            capasityColum.Visible = true;
            priceColum.Visible = true;
            btDetails.Visible = true;
        }
        public void DataGridColumHide()
        {
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Name"].Visible = false;
            dataGridView1.Columns["Description"].Visible = false;
            dataGridView1.Columns["Link"].Visible = false;
            dataGridView1.Columns["imageLink"].Visible = false;

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
            imgColum = new DataGridViewImageColumn();
            typeColum = new DataGridViewTextBoxColumn();
            voltageColum = new DataGridViewTextBoxColumn();
            currentColum = new DataGridViewTextBoxColumn();
            capasityColum = new DataGridViewTextBoxColumn();
            allowebleTempColum = new DataGridViewTextBoxColumn();
            priceColum = new DataGridViewTextBoxColumn();
            btDetails = new DataGridViewButtonColumn();
            lbMainDetailTypeSelect = new Label();
            combDetailType = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            combTransistorType = new ComboBox();
            lbTransistorType = new Label();
            lbVoltage = new Label();
            lbCurrent = new Label();
            lbCapasitorType = new Label();
            combCapasitorType = new ComboBox();
            lbAllowableTemp = new Label();
            lbCapasity = new Label();
            tbCapasity = new TextBox();
            btAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btSearch
            // 
            btSearch.Location = new Point(45, 584);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 0;
            btSearch.Text = "Пошук";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { imgColum, typeColum, voltageColum, currentColum, capasityColum, allowebleTempColum, priceColum, btDetails });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Location = new Point(329, -2);
            dataGridView1.MaximumSize = new Size(1154, 655);
            dataGridView1.MinimumSize = new Size(1154, 655);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1154, 655);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // imgColum
            // 
            imgColum.DataPropertyName = "image";
            imgColum.HeaderText = "";
            imgColum.MinimumWidth = 125;
            imgColum.Name = "imgColum";
            imgColum.Width = 200;
            // 
            // typeColum
            // 
            typeColum.DataPropertyName = "Type";
            typeColum.HeaderText = "Тип";
            typeColum.MinimumWidth = 6;
            typeColum.Name = "typeColum";
            typeColum.Width = 125;
            // 
            // voltageColum
            // 
            voltageColum.DataPropertyName = "Voltage";
            voltageColum.HeaderText = "Напруга";
            voltageColum.MinimumWidth = 6;
            voltageColum.Name = "voltageColum";
            voltageColum.Width = 125;
            // 
            // currentColum
            // 
            currentColum.DataPropertyName = "Current";
            currentColum.HeaderText = "Поточний струм";
            currentColum.MinimumWidth = 6;
            currentColum.Name = "currentColum";
            currentColum.Width = 125;
            // 
            // capasityColum
            // 
            capasityColum.DataPropertyName = "Capasity";
            capasityColum.HeaderText = "Ємність ";
            capasityColum.MinimumWidth = 6;
            capasityColum.Name = "capasityColum";
            capasityColum.Width = 125;
            // 
            // allowebleTempColum
            // 
            allowebleTempColum.DataPropertyName = "AllowableTemperature";
            allowebleTempColum.HeaderText = "Доступна температура";
            allowebleTempColum.MinimumWidth = 6;
            allowebleTempColum.Name = "allowebleTempColum";
            allowebleTempColum.Width = 125;
            // 
            // priceColum
            // 
            priceColum.DataPropertyName = "Price";
            priceColum.HeaderText = "Ціна";
            priceColum.MinimumWidth = 6;
            priceColum.Name = "priceColum";
            priceColum.Width = 125;
            // 
            // btDetails
            // 
            btDetails.HeaderText = "Детальніше";
            btDetails.MinimumWidth = 6;
            btDetails.Name = "btDetails";
            btDetails.Width = 125;
            // 
            // lbMainDetailTypeSelect
            // 
            lbMainDetailTypeSelect.AutoSize = true;
            lbMainDetailTypeSelect.Location = new Point(45, 41);
            lbMainDetailTypeSelect.Name = "lbMainDetailTypeSelect";
            lbMainDetailTypeSelect.Size = new Size(146, 20);
            lbMainDetailTypeSelect.TabIndex = 2;
            lbMainDetailTypeSelect.Text = "Виберіит тип деталі";
            // 
            // combDetailType
            // 
            combDetailType.FormattingEnabled = true;
            combDetailType.Items.AddRange(new object[] { "Транзистор", "Конденсатор", "Резистор", "Діод" });
            combDetailType.Location = new Point(45, 74);
            combDetailType.Name = "combDetailType";
            combDetailType.Size = new Size(151, 28);
            combDetailType.TabIndex = 3;
            combDetailType.SelectedIndexChanged += combDetailType_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            textBox2.Visible = false;
            textBox2.WordWrap = false;
            textBox2.TextChanged += TextChanged;
            textBox2.KeyPress += KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 335);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            textBox3.Visible = false;
            textBox3.TextChanged += TextChanged;
            textBox3.KeyPress += KeyPress;
            // 
            // combTransistorType
            // 
            combTransistorType.FormattingEnabled = true;
            combTransistorType.Items.AddRange(new object[] { "Польовий", "Біполярний" });
            combTransistorType.Location = new Point(45, 167);
            combTransistorType.Name = "combTransistorType";
            combTransistorType.Size = new Size(151, 28);
            combTransistorType.TabIndex = 7;
            combTransistorType.Visible = false;
            // 
            // lbTransistorType
            // 
            lbTransistorType.AutoSize = true;
            lbTransistorType.Location = new Point(45, 133);
            lbTransistorType.Name = "lbTransistorType";
            lbTransistorType.Size = new Size(190, 20);
            lbTransistorType.TabIndex = 8;
            lbTransistorType.Text = "Виберіть тип транзистора";
            lbTransistorType.UseWaitCursor = true;
            lbTransistorType.Visible = false;
            // 
            // lbVoltage
            // 
            lbVoltage.AutoSize = true;
            lbVoltage.Location = new Point(45, 208);
            lbVoltage.Name = "lbVoltage";
            lbVoltage.Size = new Size(67, 20);
            lbVoltage.TabIndex = 9;
            lbVoltage.Text = "Напруга";
            lbVoltage.Visible = false;
            // 
            // lbCurrent
            // 
            lbCurrent.AutoSize = true;
            lbCurrent.Location = new Point(45, 288);
            lbCurrent.Name = "lbCurrent";
            lbCurrent.RightToLeft = RightToLeft.No;
            lbCurrent.Size = new Size(123, 20);
            lbCurrent.TabIndex = 10;
            lbCurrent.Text = "Поточний струм";
            lbCurrent.Visible = false;
            lbCurrent.Click += label2_Click;
            // 
            // lbCapasitorType
            // 
            lbCapasitorType.AutoSize = true;
            lbCapasitorType.Location = new Point(45, 133);
            lbCapasitorType.Name = "lbCapasitorType";
            lbCapasitorType.Size = new Size(200, 20);
            lbCapasitorType.TabIndex = 11;
            lbCapasitorType.Text = "Виберіть тип конденсатора";
            // 
            // combCapasitorType
            // 
            combCapasitorType.FormattingEnabled = true;
            combCapasitorType.Items.AddRange(new object[] { "Низковольтний" });
            combCapasitorType.Location = new Point(45, 167);
            combCapasitorType.Name = "combCapasitorType";
            combCapasitorType.Size = new Size(151, 28);
            combCapasitorType.TabIndex = 12;
            // 
            // lbAllowableTemp
            // 
            lbAllowableTemp.AutoSize = true;
            lbAllowableTemp.Location = new Point(45, 288);
            lbAllowableTemp.Name = "lbAllowableTemp";
            lbAllowableTemp.Size = new Size(167, 20);
            lbAllowableTemp.TabIndex = 13;
            lbAllowableTemp.Text = "Доступна температура";
            // 
            // lbCapasity
            // 
            lbCapasity.AutoSize = true;
            lbCapasity.Location = new Point(50, 390);
            lbCapasity.Name = "lbCapasity";
            lbCapasity.Size = new Size(67, 20);
            lbCapasity.TabIndex = 14;
            lbCapasity.Text = "Ємність ";
            // 
            // tbCapasity
            // 
            tbCapasity.Location = new Point(45, 426);
            tbCapasity.Name = "tbCapasity";
            tbCapasity.Size = new Size(125, 27);
            tbCapasity.TabIndex = 15;
            tbCapasity.TextChanged += TextChanged;
            tbCapasity.KeyPress += KeyPress;
            // 
            // btAdmin
            // 
            btAdmin.Image = (Image)resources.GetObject("btAdmin.Image");
            btAdmin.Location = new Point(275, 605);
            btAdmin.Name = "btAdmin";
            btAdmin.Size = new Size(48, 48);
            btAdmin.TabIndex = 16;
            btAdmin.UseVisualStyleBackColor = true;
            btAdmin.Click += btAdmin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 653);
            Controls.Add(btAdmin);
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
            Controls.Add(combDetailType);
            Controls.Add(lbMainDetailTypeSelect);
            Controls.Add(dataGridView1);
            Controls.Add(btSearch);
            MaximumSize = new Size(1500, 700);
            MinimumSize = new Size(1500, 700);
            Name = "Form1";
            Text = "Довідник радіолюбителя";
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
        private Label lbTransistorType;
        private Label lbVoltage;
        private Label lbCurrent;
        private Label lbCapasitorType;
        private ComboBox combCapasitorType;
        private Label lbAllowableTemp;
        private Label lbCapasity;
        private TextBox tbCapasity;
        private DataGridViewImageColumn imgColum;
        private DataGridViewTextBoxColumn typeColum;
        private DataGridViewTextBoxColumn voltageColum;
        private DataGridViewTextBoxColumn currentColum;
        private DataGridViewTextBoxColumn capasityColum;
        private DataGridViewTextBoxColumn allowebleTempColum;
        private DataGridViewTextBoxColumn priceColum;
        private DataGridViewButtonColumn btDetails;
        private Button btAdmin;
    }
}
