namespace Handbook_of_amaters_try
{
    partial class Details
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
            pbDetailImage = new PictureBox();
            tbDetails = new TextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbDetailImage).BeginInit();
            SuspendLayout();
            // 
            // pbDetailImage
            // 
            pbDetailImage.Location = new Point(12, 22);
            pbDetailImage.Name = "pbDetailImage";
            pbDetailImage.Size = new Size(278, 256);
            pbDetailImage.TabIndex = 0;
            pbDetailImage.TabStop = false;
            // 
            // tbDetails
            // 
            tbDetails.BackColor = SystemColors.MenuBar;
            tbDetails.BorderStyle = BorderStyle.None;
            tbDetails.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbDetails.Location = new Point(448, 22);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.Size = new Size(325, 390);
            tbDetails.TabIndex = 1;
            tbDetails.TextChanged += tbDetails_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(12, 351);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(15, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "\\";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(11, 329);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 3;
            label1.Text = "Посилання на маркет плейс";
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(tbDetails);
            Controls.Add(pbDetailImage);
            ForeColor = SystemColors.ButtonFace;
            Name = "Details";
            Text = "Details";
            Load += Details_Load;
            ((System.ComponentModel.ISupportInitialize)pbDetailImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pbDetailImage;
        public TextBox tbDetails;
        public LinkLabel linkLabel1;
        private Label label1;
    }
}