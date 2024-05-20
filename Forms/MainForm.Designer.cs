namespace Handbook_of_radio_amateurs.Forms
{
    partial class MainForm
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
            lbDiodeShellType.Visible = false;
            combDiodeShellType.Visible = false;
            lbModel.Visible = false;
            tbModel.Visible = false;
            columShellType.Visible = false;
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
            lbModel.Visible = true;
            tbModel.Visible = true;
        }
        public void DiodeView()
        {
            btSearch.Visible = true;
            lbDiodeShellType.Visible = true;
            combDiodeShellType.Visible= true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            lbCurrent.Visible = true;
            tbModel.Visible = true;
            priceColum.Visible = true;
            imgColum.Visible = true;
            dataGridView1.RowTemplate.Height = 200;
            lbModel.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            lbVoltage.Visible = true;
            columShellType.Visible = true;
            voltageColum.Visible = true;
            currentColum.Visible = true;
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tbModel = new TextBox();
            lbModel = new Label();
            lbCapacitorType = new Label();
            lbTransistorType = new Label();
            lbVoltage = new Label();
            btAdmin = new Button();
            tbCapasity = new TextBox();
            lbCapasity = new Label();
            lbAllowableTemp = new Label();
            combCapasitorType = new ComboBox();
            lbCurrent = new Label();
            combTransistorType = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            combDetailType = new ComboBox();
            lbMainDetailTypeSelect = new Label();
            btSearch = new Button();
            dataGridView1 = new DataGridView();
            lbDiodeShellType = new Label();
            combDiodeShellType = new ComboBox();
            imgColum = new DataGridViewImageColumn();
            columShellType = new DataGridViewTextBoxColumn();
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
            // tbModel
            // 
            tbModel.Location = new Point(18, 118);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(125, 27);
            tbModel.TabIndex = 39;
            // 
            // lbModel
            // 
            lbModel.AutoSize = true;
            lbModel.ImeMode = ImeMode.NoControl;
            lbModel.Location = new Point(18, 95);
            lbModel.Name = "lbModel";
            lbModel.Size = new Size(90, 20);
            lbModel.TabIndex = 38;
            lbModel.Text = "Enter model";
            // 
            // lbCapacitorType
            // 
            lbCapacitorType.AutoSize = true;
            lbCapacitorType.ImeMode = ImeMode.NoControl;
            lbCapacitorType.Location = new Point(18, 222);
            lbCapacitorType.Name = "lbCapacitorType";
            lbCapacitorType.Size = new Size(148, 20);
            lbCapacitorType.TabIndex = 37;
            lbCapacitorType.Text = "Select capacitor type";
            // 
            // lbTransistorType
            // 
            lbTransistorType.AutoSize = true;
            lbTransistorType.ImeMode = ImeMode.NoControl;
            lbTransistorType.Location = new Point(14, 222);
            lbTransistorType.Name = "lbTransistorType";
            lbTransistorType.Size = new Size(147, 20);
            lbTransistorType.TabIndex = 36;
            lbTransistorType.Text = "Select transistor type";
            // 
            // lbVoltage
            // 
            lbVoltage.AutoSize = true;
            lbVoltage.ImeMode = ImeMode.NoControl;
            lbVoltage.Location = new Point(18, 275);
            lbVoltage.Name = "lbVoltage";
            lbVoltage.Size = new Size(60, 20);
            lbVoltage.TabIndex = 35;
            lbVoltage.Text = "Voltage";
            // 
            // btAdmin
            // 
            btAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btAdmin.ImeMode = ImeMode.NoControl;
            btAdmin.Location = new Point(12, 583);
            btAdmin.Name = "btAdmin";
            btAdmin.Size = new Size(48, 48);
            btAdmin.TabIndex = 34;
            btAdmin.UseVisualStyleBackColor = true;
            btAdmin.Click += btAdmin_Click;
            // 
            // tbCapasity
            // 
            tbCapasity.Location = new Point(18, 404);
            tbCapasity.Name = "tbCapasity";
            tbCapasity.Size = new Size(125, 27);
            tbCapasity.TabIndex = 33;
            // 
            // lbCapasity
            // 
            lbCapasity.AutoSize = true;
            lbCapasity.ImeMode = ImeMode.NoControl;
            lbCapasity.Location = new Point(18, 381);
            lbCapasity.Name = "lbCapasity";
            lbCapasity.Size = new Size(65, 20);
            lbCapasity.TabIndex = 32;
            lbCapasity.Text = "Capasity";
            // 
            // lbAllowableTemp
            // 
            lbAllowableTemp.AutoSize = true;
            lbAllowableTemp.ImeMode = ImeMode.NoControl;
            lbAllowableTemp.Location = new Point(21, 328);
            lbAllowableTemp.Name = "lbAllowableTemp";
            lbAllowableTemp.Size = new Size(161, 20);
            lbAllowableTemp.TabIndex = 31;
            lbAllowableTemp.Text = "Available temperature ";
            // 
            // combCapasitorType
            // 
            combCapasitorType.FormattingEnabled = true;
            combCapasitorType.Items.AddRange(new object[] { "Electrolytic", "", "Aluminum polymer", "", "Electrolytic LOW ESR", "", "Electrolytically large", "", "Electrolytic SMD" });
            combCapasitorType.Location = new Point(18, 245);
            combCapasitorType.Name = "combCapasitorType";
            combCapasitorType.Size = new Size(151, 28);
            combCapasitorType.TabIndex = 30;
            // 
            // lbCurrent
            // 
            lbCurrent.AutoSize = true;
            lbCurrent.ImeMode = ImeMode.NoControl;
            lbCurrent.Location = new Point(21, 328);
            lbCurrent.Name = "lbCurrent";
            lbCurrent.RightToLeft = RightToLeft.No;
            lbCurrent.Size = new Size(57, 20);
            lbCurrent.TabIndex = 29;
            lbCurrent.Text = "Current";
            // 
            // combTransistorType
            // 
            combTransistorType.FormattingEnabled = true;
            combTransistorType.Items.AddRange(new object[] { "Field-effect", "Bipolar" });
            combTransistorType.Location = new Point(18, 245);
            combTransistorType.Name = "combTransistorType";
            combTransistorType.Size = new Size(151, 28);
            combTransistorType.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 351);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 298);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 26;
            textBox2.WordWrap = false;
            // 
            // combDetailType
            // 
            combDetailType.FormattingEnabled = true;
            combDetailType.Items.AddRange(new object[] { "Transistor", "Capacitor", "Resistor", "Diode" });
            combDetailType.Location = new Point(18, 53);
            combDetailType.Name = "combDetailType";
            combDetailType.Size = new Size(151, 28);
            combDetailType.TabIndex = 25;
            combDetailType.SelectedIndexChanged += combDetailType_SelectedIndexChanged;
            // 
            // lbMainDetailTypeSelect
            // 
            lbMainDetailTypeSelect.AutoSize = true;
            lbMainDetailTypeSelect.ImeMode = ImeMode.NoControl;
            lbMainDetailTypeSelect.Location = new Point(18, 30);
            lbMainDetailTypeSelect.Name = "lbMainDetailTypeSelect";
            lbMainDetailTypeSelect.Size = new Size(124, 20);
            lbMainDetailTypeSelect.TabIndex = 24;
            lbMainDetailTypeSelect.Text = "Select detail type";
            // 
            // btSearch
            // 
            btSearch.ImeMode = ImeMode.NoControl;
            btSearch.Location = new Point(18, 451);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(111, 60);
            btSearch.TabIndex = 22;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { imgColum, columShellType, typeColum, voltageColum, currentColum, capasityColum, allowebleTempColum, priceColum, btDetails });
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Location = new Point(458, 0);
            dataGridView1.MaximumSize = new Size(1154, 655);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(755, 643);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbDiodeShellType
            // 
            lbDiodeShellType.AutoSize = true;
            lbDiodeShellType.Location = new Point(18, 222);
            lbDiodeShellType.Name = "lbDiodeShellType";
            lbDiodeShellType.Size = new Size(159, 20);
            lbDiodeShellType.TabIndex = 40;
            lbDiodeShellType.Text = "Select diode shell type";
            // 
            // combDiodeShellType
            // 
            combDiodeShellType.FormattingEnabled = true;
            combDiodeShellType.Items.AddRange(new object[] { "DO-41", "DO-15", "DO-27", "DO-41" });
            combDiodeShellType.Location = new Point(18, 245);
            combDiodeShellType.Name = "combDiodeShellType";
            combDiodeShellType.Size = new Size(151, 28);
            combDiodeShellType.TabIndex = 41;
            // 
            // imgColum
            // 
            imgColum.DataPropertyName = "image";
            imgColum.HeaderText = "";
            imgColum.MinimumWidth = 125;
            imgColum.Name = "imgColum";
            imgColum.ReadOnly = true;
            imgColum.Width = 150;
            // 
            // columShellType
            // 
            columShellType.DataPropertyName = "ShellType";
            columShellType.HeaderText = "Shell type";
            columShellType.MinimumWidth = 6;
            columShellType.Name = "columShellType";
            columShellType.Width = 125;
            // 
            // typeColum
            // 
            typeColum.DataPropertyName = "Model";
            typeColum.HeaderText = "Model";
            typeColum.MinimumWidth = 6;
            typeColum.Name = "typeColum";
            typeColum.Width = 125;
            // 
            // voltageColum
            // 
            voltageColum.DataPropertyName = "Voltage";
            voltageColum.HeaderText = "Voltage";
            voltageColum.MinimumWidth = 6;
            voltageColum.Name = "voltageColum";
            voltageColum.Width = 125;
            // 
            // currentColum
            // 
            currentColum.DataPropertyName = "Current";
            currentColum.HeaderText = "Current";
            currentColum.MinimumWidth = 6;
            currentColum.Name = "currentColum";
            currentColum.Width = 125;
            // 
            // capasityColum
            // 
            capasityColum.DataPropertyName = "Capasity";
            capasityColum.HeaderText = "Capasity";
            capasityColum.MinimumWidth = 6;
            capasityColum.Name = "capasityColum";
            capasityColum.Width = 125;
            // 
            // allowebleTempColum
            // 
            allowebleTempColum.DataPropertyName = "AllowableTemperature";
            allowebleTempColum.HeaderText = "Available temperature";
            allowebleTempColum.MinimumWidth = 6;
            allowebleTempColum.Name = "allowebleTempColum";
            allowebleTempColum.Width = 125;
            // 
            // priceColum
            // 
            priceColum.DataPropertyName = "Price";
            priceColum.HeaderText = "Price";
            priceColum.MinimumWidth = 6;
            priceColum.Name = "priceColum";
            priceColum.Width = 125;
            // 
            // btDetails
            // 
            btDetails.HeaderText = "More detail";
            btDetails.MinimumWidth = 6;
            btDetails.Name = "btDetails";
            btDetails.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 643);
            Controls.Add(combDiodeShellType);
            Controls.Add(lbDiodeShellType);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Handbook of radio amauters";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tbModel;
        public Label lbModel;
        private Label lbCapacitorType;
        private Label lbTransistorType;
        private Label lbVoltage;
        private Button btAdmin;
        private TextBox tbCapasity;
        private Label lbCapasity;
        private Label lbAllowableTemp;
        private ComboBox combCapasitorType;
        private Label lbCurrent;
        private ComboBox combTransistorType;
        private TextBox textBox3;
        private TextBox textBox2;
        public ComboBox combDetailType;
        private Label lbMainDetailTypeSelect;
        private Button btSearch;
        private DataGridView dataGridView1;
        private Label lbDiodeShellType;
        private ComboBox combDiodeShellType;
        private DataGridViewImageColumn imgColum;
        private DataGridViewTextBoxColumn columShellType;
        private DataGridViewTextBoxColumn typeColum;
        private DataGridViewTextBoxColumn voltageColum;
        private DataGridViewTextBoxColumn currentColum;
        private DataGridViewTextBoxColumn capasityColum;
        private DataGridViewTextBoxColumn allowebleTempColum;
        private DataGridViewTextBoxColumn priceColum;
        private DataGridViewButtonColumn btDetails;
    }
}