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
            imgColum.Visible = false;
            typeColum.Visible = false;
            voltageColum.Visible = false;
            currentColum.Visible = false;
            priceColum.Visible = false;
            capasityColum.Visible = false;
            allowebleTempColum.Visible = false;
            lbCapacitorType.Visible = false;
            tbCapasity.Visible = false;
            combCapasitorType.Visible = false;
            btDetails.Visible = false;
            lbDiodeShellType.Visible = false;
            combDiodeShellType.Visible = false;
            lbModel.Visible = false;
            tbModel.Visible = false;
            columShellType.Visible = false;
            columResistance.Visible = false;
            columTolerance.Visible = false;
            lbMain1.Text = "";
            lbMain2.Text = "";
            lbMain3.Text = "";
            dataGridView1.Visible = false;
            columType.Visible = false;
        }
        public void TransistorView()
        {
            btSearch.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            combTransistorType.Visible = true;
            lbTransistorType.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            imgColum.Visible = true;
            typeColum.Visible = true;
            voltageColum.Visible = true;
            currentColum.Visible = true;
            priceColum.Visible = true;
            dataGridView1.RowTemplate.Height = 150;
            lbModel.Visible = true;
            tbModel.Visible = true;
            lbMain1.Text = "Voltage";
            lbMain2.Text = "Current";
            dataGridView1.Visible = true;
            columType.Visible = true;
        }

        public void CapasitorView()
        {
            btSearch.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            lbCapacitorType.Visible = true;
            tbCapasity.Visible = true;
            combCapasitorType.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            tbCapasity.Text = "0";
            dataGridView1.RowTemplate.Height = 150;
            imgColum.Visible = true;
            voltageColum.Visible = true;
            capasityColum.Visible = true;
            priceColum.Visible = true;
            lbModel.Visible = true;
            tbModel.Visible = true;
            lbMain1.Text = "Voltage";
            lbMain2.Text = "Available temperature";
            lbMain3.Text = "Capasity";
            dataGridView1.Visible = true;
        }
        public void DiodeView()
        {
            btSearch.Visible = true;
            lbDiodeShellType.Visible = true;
            combDiodeShellType.Visible= true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            tbModel.Visible = true;
            priceColum.Visible = true;
            imgColum.Visible = true;
            dataGridView1.RowTemplate.Height = 150;
            lbModel.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            columShellType.Visible = true;
            voltageColum.Visible = true;
            currentColum.Visible = true;
            lbMain2.Text = "Current";
            lbMain1.Text = "Voltage";
            dataGridView1.Visible = true;
        }
        public void ResistorView()
        {
            lbMain2.Text = "Resistance";
            lbMain1.Text = "Tolerance";
            btSearch.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            tbModel.Visible = true;
            priceColum.Visible = true;
            imgColum.Visible = true;
            dataGridView1.RowTemplate.Height = 150;
            lbModel.Visible = true;
            columResistance.Visible = true;
            columTolerance.Visible = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            dataGridView1.Visible = true;
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
            btAdmin = new Button();
            tbCapasity = new TextBox();
            combCapasitorType = new ComboBox();
            combTransistorType = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            combDetailType = new ComboBox();
            lbMainDetailTypeSelect = new Label();
            btSearch = new Button();
            dataGridView1 = new DataGridView();
            lbDiodeShellType = new Label();
            combDiodeShellType = new ComboBox();
            lbMain1 = new Label();
            lbMain2 = new Label();
            lbMain3 = new Label();
            imgColum = new DataGridViewImageColumn();
            columType = new DataGridViewTextBoxColumn();
            columResistance = new DataGridViewTextBoxColumn();
            columTolerance = new DataGridViewTextBoxColumn();
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
            tbModel.Location = new Point(18, 185);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(125, 27);
            tbModel.TabIndex = 39;
            // 
            // lbModel
            // 
            lbModel.AutoSize = true;
            lbModel.ImeMode = ImeMode.NoControl;
            lbModel.Location = new Point(21, 162);
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
            // btAdmin
            // 
            btAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btAdmin.BackColor = SystemColors.Menu;
            btAdmin.FlatStyle = FlatStyle.Flat;
            btAdmin.ForeColor = SystemColors.Menu;
            btAdmin.ImeMode = ImeMode.NoControl;
            btAdmin.Location = new Point(12, 517);
            btAdmin.Name = "btAdmin";
            btAdmin.Size = new Size(48, 48);
            btAdmin.TabIndex = 34;
            btAdmin.UseVisualStyleBackColor = false;
            btAdmin.Click += btAdmin_Click;
            // 
            // tbCapasity
            // 
            tbCapasity.Location = new Point(18, 404);
            tbCapasity.Name = "tbCapasity";
            tbCapasity.Size = new Size(125, 27);
            tbCapasity.TabIndex = 33;
            tbCapasity.TextChanged += TextChanged;
            tbCapasity.KeyPress += KeyPress;
            // 
            // combCapasitorType
            // 
            combCapasitorType.FormattingEnabled = true;
            combCapasitorType.Items.AddRange(new object[] { "Electrolytic", "", "Aluminum polymer", "", "Electrolytic LOW ESR", "", "Electrolytically large", "", "Electrolytic SMD" });
            combCapasitorType.Location = new Point(18, 245);
            combCapasitorType.Name = "combCapasitorType";
            combCapasitorType.Size = new Size(125, 28);
            combCapasitorType.TabIndex = 30;
            // 
            // combTransistorType
            // 
            combTransistorType.FormattingEnabled = true;
            combTransistorType.Items.AddRange(new object[] { "Field-effect", "Bipolar" });
            combTransistorType.Location = new Point(18, 245);
            combTransistorType.Name = "combTransistorType";
            combTransistorType.Size = new Size(125, 28);
            combTransistorType.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 351);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 27;
            textBox3.TextChanged += TextChanged;
            textBox3.KeyPress += KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 299);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 26;
            textBox2.WordWrap = false;
            textBox2.TextChanged += TextChanged;
            textBox2.KeyPress += KeyPress;
            // 
            // combDetailType
            // 
            combDetailType.FormattingEnabled = true;
            combDetailType.Items.AddRange(new object[] { "Transistor", "Capacitor", "Resistor", "Diode" });
            combDetailType.Location = new Point(18, 53);
            combDetailType.Name = "combDetailType";
            combDetailType.Size = new Size(124, 28);
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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { imgColum, columType, columResistance, columTolerance, columShellType, typeColum, voltageColum, currentColum, capasityColum, allowebleTempColum, priceColum, btDetails });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Location = new Point(186, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(988, 575);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbDiodeShellType
            // 
            lbDiodeShellType.AutoSize = true;
            lbDiodeShellType.Location = new Point(21, 222);
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
            combDiodeShellType.Size = new Size(125, 28);
            combDiodeShellType.TabIndex = 41;
            // 
            // lbMain1
            // 
            lbMain1.AutoSize = true;
            lbMain1.Location = new Point(21, 276);
            lbMain1.Name = "lbMain1";
            lbMain1.Size = new Size(0, 20);
            lbMain1.TabIndex = 42;
            // 
            // lbMain2
            // 
            lbMain2.AutoSize = true;
            lbMain2.Location = new Point(21, 328);
            lbMain2.Name = "lbMain2";
            lbMain2.Size = new Size(0, 20);
            lbMain2.TabIndex = 43;
            // 
            // lbMain3
            // 
            lbMain3.AutoSize = true;
            lbMain3.Location = new Point(21, 381);
            lbMain3.Name = "lbMain3";
            lbMain3.Size = new Size(0, 20);
            lbMain3.TabIndex = 44;
            // 
            // imgColum
            // 
            imgColum.DataPropertyName = "image";
            imgColum.HeaderText = "";
            imgColum.MinimumWidth = 150;
            imgColum.Name = "imgColum";
            imgColum.ReadOnly = true;
            // 
            // columType
            // 
            columType.DataPropertyName = "Type";
            columType.HeaderText = "Type";
            columType.MinimumWidth = 6;
            columType.Name = "columType";
            columType.ReadOnly = true;
            // 
            // columResistance
            // 
            columResistance.DataPropertyName = "Resistance";
            columResistance.HeaderText = "Resistance";
            columResistance.MinimumWidth = 6;
            columResistance.Name = "columResistance";
            columResistance.ReadOnly = true;
            // 
            // columTolerance
            // 
            columTolerance.DataPropertyName = "Tolerance";
            columTolerance.HeaderText = "Tolerance";
            columTolerance.MinimumWidth = 6;
            columTolerance.Name = "columTolerance";
            columTolerance.ReadOnly = true;
            // 
            // columShellType
            // 
            columShellType.DataPropertyName = "ShellType";
            columShellType.HeaderText = "Shell type";
            columShellType.MinimumWidth = 6;
            columShellType.Name = "columShellType";
            columShellType.ReadOnly = true;
            // 
            // typeColum
            // 
            typeColum.DataPropertyName = "Model";
            typeColum.HeaderText = "Model";
            typeColum.MinimumWidth = 6;
            typeColum.Name = "typeColum";
            typeColum.ReadOnly = true;
            // 
            // voltageColum
            // 
            voltageColum.DataPropertyName = "Voltage";
            voltageColum.HeaderText = "Voltage";
            voltageColum.MinimumWidth = 6;
            voltageColum.Name = "voltageColum";
            voltageColum.ReadOnly = true;
            // 
            // currentColum
            // 
            currentColum.DataPropertyName = "Current";
            currentColum.HeaderText = "Current";
            currentColum.MinimumWidth = 6;
            currentColum.Name = "currentColum";
            currentColum.ReadOnly = true;
            // 
            // capasityColum
            // 
            capasityColum.DataPropertyName = "Capasity";
            capasityColum.HeaderText = "Capasity";
            capasityColum.MinimumWidth = 6;
            capasityColum.Name = "capasityColum";
            capasityColum.ReadOnly = true;
            // 
            // allowebleTempColum
            // 
            allowebleTempColum.DataPropertyName = "AllowableTemperature";
            allowebleTempColum.HeaderText = "Available temperature";
            allowebleTempColum.MinimumWidth = 6;
            allowebleTempColum.Name = "allowebleTempColum";
            allowebleTempColum.ReadOnly = true;
            // 
            // priceColum
            // 
            priceColum.DataPropertyName = "Price";
            priceColum.HeaderText = "Price";
            priceColum.MinimumWidth = 6;
            priceColum.Name = "priceColum";
            priceColum.ReadOnly = true;
            // 
            // btDetails
            // 
            btDetails.HeaderText = "More detail";
            btDetails.MinimumWidth = 6;
            btDetails.Name = "btDetails";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 575);
            Controls.Add(lbMain3);
            Controls.Add(lbMain2);
            Controls.Add(lbMain1);
            Controls.Add(combDiodeShellType);
            Controls.Add(lbDiodeShellType);
            Controls.Add(tbModel);
            Controls.Add(lbModel);
            Controls.Add(lbCapacitorType);
            Controls.Add(lbTransistorType);
            Controls.Add(btAdmin);
            Controls.Add(tbCapasity);
            Controls.Add(combCapasitorType);
            Controls.Add(combTransistorType);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(combDetailType);
            Controls.Add(lbMainDetailTypeSelect);
            Controls.Add(dataGridView1);
            Controls.Add(btSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1500, 800);
            MinimumSize = new Size(1204, 622);
            Name = "MainForm";
            Text = "Handbook of radio amauters";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tbModel;
        public Label lbModel;
        private Label lbCapacitorType;
        private Label lbTransistorType;
        private Button btAdmin;
        private TextBox tbCapasity;
        private ComboBox combCapasitorType;
        private ComboBox combTransistorType;
        private TextBox textBox3;
        private TextBox textBox2;
        public ComboBox combDetailType;
        private Label lbMainDetailTypeSelect;
        private Button btSearch;
        private DataGridView dataGridView1;
        private Label lbDiodeShellType;
        private ComboBox combDiodeShellType;
        private Label lbMain1;
        private Label lbMain2;
        private Label lbMain3;
        private DataGridViewImageColumn imgColum;
        private DataGridViewTextBoxColumn columType;
        private DataGridViewTextBoxColumn columResistance;
        private DataGridViewTextBoxColumn columTolerance;
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