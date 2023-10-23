namespace Supermarket.View
{
    partial class Categories
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
            pictureBox1 = new PictureBox();
            txtEnv = new TextBox();
            txtDesc = new TextBox();
            TxtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TxtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            DgCategories = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            NameProducto = new DataGridViewTextBoxColumn();
            PriceProducto = new DataGridViewTextBoxColumn();
            StockProducto = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtEnv);
            groupBox1.Controls.Add(txtDesc);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.DarkViolet;
            groupBox1.Location = new Point(49, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 227);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(348, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 129);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txtEnv
            // 
            txtEnv.Enabled = false;
            txtEnv.Location = new Point(190, 182);
            txtEnv.Name = "txtEnv";
            txtEnv.Size = new Size(130, 23);
            txtEnv.TabIndex = 10;
            txtEnv.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDesc
            // 
            txtDesc.Enabled = false;
            txtDesc.Location = new Point(190, 135);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(130, 23);
            txtDesc.TabIndex = 9;
            txtDesc.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtName
            // 
            TxtName.Enabled = false;
            TxtName.Location = new Point(190, 77);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(130, 23);
            TxtName.TabIndex = 8;
            TxtName.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkViolet;
            label4.Location = new Point(27, 182);
            label4.Name = "label4";
            label4.Size = new Size(126, 19);
            label4.TabIndex = 6;
            label4.Text = "Envase Categorie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkViolet;
            label3.Location = new Point(27, 135);
            label3.Name = "label3";
            label3.Size = new Size(158, 19);
            label3.TabIndex = 4;
            label3.Text = "Description Categorie";
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(190, 28);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(130, 23);
            TxtId.TabIndex = 2;
            TxtId.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(27, 82);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 1;
            label2.Text = "Name Categorie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 0;
            label1.Text = "Id Categorie";
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.BackgroundColor = SystemColors.ActiveCaptionText;
            DgCategories.BorderStyle = BorderStyle.Fixed3D;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Columns.AddRange(new DataGridViewColumn[] { IdProducto, NameProducto, PriceProducto, StockProducto });
            DgCategories.Location = new Point(49, 271);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.RowTemplate.Height = 25;
            DgCategories.Size = new Size(491, 150);
            DgCategories.TabIndex = 3;
            DgCategories.CellContentClick += DgCategories_CellContentClick;
            DgCategories.Click += DgCategories_Click;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "Id Categ";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Resizable = DataGridViewTriState.False;
            // 
            // NameProducto
            // 
            NameProducto.HeaderText = "Name Categ";
            NameProducto.Name = "NameProducto";
            NameProducto.ReadOnly = true;
            NameProducto.Resizable = DataGridViewTriState.False;
            NameProducto.Width = 150;
            // 
            // PriceProducto
            // 
            PriceProducto.HeaderText = "Description";
            PriceProducto.Name = "PriceProducto";
            PriceProducto.ReadOnly = true;
            PriceProducto.Resizable = DataGridViewTriState.False;
            // 
            // StockProducto
            // 
            StockProducto.HeaderText = "Envase";
            StockProducto.Name = "StockProducto";
            StockProducto.ReadOnly = true;
            StockProducto.Resizable = DataGridViewTriState.False;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaptionText;
            groupBox2.Controls.Add(BtnClose);
            groupBox2.Controls.Add(BtnDelete);
            groupBox2.Controls.Add(BtnEdit);
            groupBox2.Controls.Add(BtnNew);
            groupBox2.ForeColor = Color.DarkViolet;
            groupBox2.Location = new Point(573, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 302);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options";
            groupBox2.Enter += groupBox2_Enter;
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
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(DgCategories);
            Controls.Add(groupBox1);
            Name = "Categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";
            Load += Categories_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtId;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private DataGridView DgCategories;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn NameProducto;
        private DataGridViewTextBoxColumn PriceProducto;
        private DataGridViewTextBoxColumn StockProducto;
        private GroupBox groupBox2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox txtEnv;
        private TextBox txtDesc;
        private TextBox TxtName;
        private PictureBox pictureBox1;
    }
}