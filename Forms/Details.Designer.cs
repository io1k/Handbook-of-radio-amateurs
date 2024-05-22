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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            pbDetailImage = new PictureBox();
            tbDetails = new TextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbDetailImage).BeginInit();
            SuspendLayout();
            // 
            // pbDetailImage
            // 
            resources.ApplyResources(pbDetailImage, "pbDetailImage");
            pbDetailImage.Name = "pbDetailImage";
            pbDetailImage.TabStop = false;
            // 
            // tbDetails
            // 
            resources.ApplyResources(tbDetails, "tbDetails");
            tbDetails.BackColor = SystemColors.MenuBar;
            tbDetails.BorderStyle = BorderStyle.None;
            tbDetails.Name = "tbDetails";
            tbDetails.ReadOnly = true;
            tbDetails.TextChanged += tbDetails_TextChanged;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(linkLabel1, "linkLabel1");
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // Details
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(tbDetails);
            Controls.Add(pbDetailImage);
            ForeColor = SystemColors.ButtonFace;
            Name = "Details";
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