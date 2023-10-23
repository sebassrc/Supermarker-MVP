namespace Supermarket.View
{
    partial class PayModels
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
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            IdPaymode = new DataGridViewTextBoxColumn();
            NamePayMode = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(TxtId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.DarkViolet;
            groupBox1.Location = new Point(81, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 123);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // TxtName
            // 
            TxtName.Enabled = false;
            TxtName.Location = new Point(84, 82);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Pay mode name";
            TxtName.Size = new Size(176, 23);
            TxtName.TabIndex = 3;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(84, 28);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(176, 23);
            TxtId.TabIndex = 2;
            TxtId.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 82);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaptionText;
            groupBox2.Controls.Add(BtnClose);
            groupBox2.Controls.Add(BtnDelete);
            groupBox2.Controls.Add(BtnEdit);
            groupBox2.Controls.Add(BtnNew);
            groupBox2.ForeColor = Color.DarkViolet;
            groupBox2.Location = new Point(588, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 302);
            groupBox2.TabIndex = 1;
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
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.BackgroundColor = SystemColors.ActiveCaptionText;
            DgPayMode.BorderStyle = BorderStyle.Fixed3D;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Columns.AddRange(new DataGridViewColumn[] { IdPaymode, NamePayMode });
            DgPayMode.Location = new Point(81, 218);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowTemplate.Height = 25;
            DgPayMode.Size = new Size(447, 150);
            DgPayMode.TabIndex = 2;
            DgPayMode.Click += DgPayMode_Click;
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
            NamePayMode.HeaderText = "Name";
            NamePayMode.Name = "NamePayMode";
            NamePayMode.ReadOnly = true;
            NamePayMode.Resizable = DataGridViewTriState.False;
            NamePayMode.Width = 300;
            // 
            // PayModeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(DgPayMode);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PayModeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pay Mode Management";
            Load += PayModeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtName;
        private TextBox TxtId;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private DataGridViewTextBoxColumn IdPaymode;
        private DataGridViewTextBoxColumn NamePayMode;
    }
}