namespace Supermarket.View
{
    partial class Providers
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
            groupBox1 = new GroupBox();
            TxtName = new TextBox();
            TxtId = new TextBox();
            name = new Label();
            label1 = new Label();
            DgProviders = new DataGridView();
            IdPaymode = new DataGridViewTextBoxColumn();
            NamePayMode = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(TxtId);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.DarkViolet;
            groupBox1.Location = new Point(67, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 177);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // TxtName
            // 
            TxtName.Enabled = false;
            TxtName.Location = new Point(133, 79);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 23);
            TxtName.TabIndex = 3;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(133, 28);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(100, 23);
            TxtId.TabIndex = 2;
            TxtId.TextAlign = HorizontalAlignment.Right;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(27, 82);
            name.Name = "name";
            name.Size = new Size(86, 15);
            name.TabIndex = 1;
            name.Text = "Name Provider";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Id Provider";
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.BackgroundColor = SystemColors.ActiveCaptionText;
            DgProviders.BorderStyle = BorderStyle.Fixed3D;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Columns.AddRange(new DataGridViewColumn[] { IdPaymode, NamePayMode });
            DgProviders.Location = new Point(67, 221);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.RowTemplate.Height = 25;
            DgProviders.Size = new Size(447, 150);
            DgProviders.TabIndex = 3;
            DgProviders.Click += DgProviders_Click;
            // 
            // IdPaymode
            // 
            IdPaymode.HeaderText = "Id";
            IdPaymode.Name = "IdPaymode";
            IdPaymode.ReadOnly = true;
            IdPaymode.Resizable = DataGridViewTriState.False;
            // 
            // NamePayMode
            // 
            NamePayMode.HeaderText = "Providers";
            NamePayMode.Name = "NamePayMode";
            NamePayMode.ReadOnly = true;
            NamePayMode.Resizable = DataGridViewTriState.False;
            NamePayMode.Width = 300;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnClose);
            groupBox2.Controls.Add(BtnDelete);
            groupBox2.Controls.Add(BtnEdit);
            groupBox2.Controls.Add(BtnNew);
            groupBox2.ForeColor = Color.DarkViolet;
            groupBox2.Location = new Point(569, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 302);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options";
            // 
            // BtnClose
            // 
            BtnClose.BackColor = SystemColors.ActiveCaptionText;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.ImageAlign = ContentAlignment.TopCenter;
            BtnClose.Location = new Point(51, 242);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(108, 54);
            BtnClose.TabIndex = 3;
            BtnClose.Text = "&Close";
            BtnClose.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = SystemColors.ActiveCaptionText;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.ImageAlign = ContentAlignment.TopCenter;
            BtnDelete.Location = new Point(51, 176);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(108, 60);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "&Delete";
            BtnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = SystemColors.ActiveCaptionText;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.ImageAlign = ContentAlignment.TopCenter;
            BtnEdit.Location = new Point(51, 115);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(108, 55);
            BtnEdit.TabIndex = 1;
            BtnEdit.Text = "&Edit";
            BtnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = SystemColors.ActiveCaptionText;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(51, 48);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(108, 61);
            BtnNew.TabIndex = 0;
            BtnNew.Text = "&New";
            BtnNew.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnNew.UseVisualStyleBackColor = false;
            BtnNew.Click += BtnNew_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(305, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 129);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Providers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(DgProviders);
            Controls.Add(groupBox1);
            Name = "Providers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Providers";
            Load += Providers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtName;
        private TextBox TxtId;
        private Label name;
        private Label label1;
        private DataGridView DgProviders;
        private DataGridViewTextBoxColumn IdPaymode;
        private DataGridViewTextBoxColumn NamePayMode;
        private GroupBox groupBox2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private PictureBox pictureBox1;
    }
}