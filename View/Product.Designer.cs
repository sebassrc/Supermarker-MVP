namespace Supermarket.View
{
    partial class Product
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
            textBox3 = new TextBox();
            Category = new Label();
            textBox2 = new TextBox();
            Stock = new Label();
            textBox1 = new TextBox();
            Price = new Label();
            TxtName = new TextBox();
            TxtId = new TextBox();
            Nombre = new Label();
            Id = new Label();
            DgProduct = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            NameProducto = new DataGridViewTextBoxColumn();
            PriceProducto = new DataGridViewTextBoxColumn();
            StockProducto = new DataGridViewTextBoxColumn();
            CategoryProduct = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(Category);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(Stock);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(Price);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(TxtId);
            groupBox1.Controls.Add(Nombre);
            groupBox1.Controls.Add(Id);
            groupBox1.ForeColor = Color.DarkViolet;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 259);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(153, 208);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = " ";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 9;
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Location = new Point(28, 211);
            Category.Name = "Category";
            Category.Size = new Size(100, 15);
            Category.TabIndex = 8;
            Category.Text = "Category Product";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(153, 164);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = " ";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 7;
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Location = new Point(28, 167);
            Stock.Name = "Stock";
            Stock.Size = new Size(81, 15);
            Stock.TabIndex = 6;
            Stock.Text = "Stock Product";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(153, 121);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " ";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(28, 124);
            Price.Name = "Price";
            Price.Size = new Size(78, 15);
            Price.TabIndex = 4;
            Price.Text = "Price Product";
            Price.Click += label3_Click;
            // 
            // TxtName
            // 
            TxtName.Enabled = false;
            TxtName.Location = new Point(153, 74);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = " ";
            TxtName.Size = new Size(167, 23);
            TxtName.TabIndex = 3;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(153, 28);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(167, 23);
            TxtId.TabIndex = 2;
            TxtId.TextAlign = HorizontalAlignment.Right;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(25, 77);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(84, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Name Product";
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(25, 28);
            Id.Name = "Id";
            Id.Size = new Size(17, 15);
            Id.TabIndex = 0;
            Id.Text = "Id";
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.BackgroundColor = SystemColors.ActiveCaptionText;
            DgProduct.BorderStyle = BorderStyle.Fixed3D;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Columns.AddRange(new DataGridViewColumn[] { IdProducto, NameProducto, PriceProducto, StockProducto, CategoryProduct });
            DgProduct.Location = new Point(12, 288);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowTemplate.Height = 25;
            DgProduct.Size = new Size(596, 150);
            DgProduct.TabIndex = 2;
            DgProduct.CellContentClick += DgProduct_CellContentClick;
            DgProduct.Click += DgProduct_Click;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "Id";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Resizable = DataGridViewTriState.False;
            // 
            // NameProducto
            // 
            NameProducto.HeaderText = "Name";
            NameProducto.Name = "NameProducto";
            NameProducto.ReadOnly = true;
            NameProducto.Resizable = DataGridViewTriState.False;
            NameProducto.Width = 150;
            // 
            // PriceProducto
            // 
            PriceProducto.HeaderText = "Price";
            PriceProducto.Name = "PriceProducto";
            PriceProducto.ReadOnly = true;
            PriceProducto.Resizable = DataGridViewTriState.False;
            // 
            // StockProducto
            // 
            StockProducto.HeaderText = "Stock";
            StockProducto.Name = "StockProducto";
            StockProducto.ReadOnly = true;
            StockProducto.Resizable = DataGridViewTriState.False;
            // 
            // CategoryProduct
            // 
            CategoryProduct.HeaderText = "Category";
            CategoryProduct.Name = "CategoryProduct";
            CategoryProduct.ReadOnly = true;
            CategoryProduct.Resizable = DataGridViewTriState.False;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnClose);
            groupBox2.Controls.Add(BtnDelete);
            groupBox2.Controls.Add(BtnEdit);
            groupBox2.Controls.Add(BtnNew);
            groupBox2.ForeColor = Color.DarkViolet;
            groupBox2.Location = new Point(635, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(181, 385);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options";
            // 
            // BtnClose
            // 
            BtnClose.BackColor = SystemColors.ActiveCaptionText;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.ImageAlign = ContentAlignment.TopCenter;
            BtnClose.Location = new Point(51, 306);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 64);
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
            BtnDelete.Location = new Point(51, 211);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 64);
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
            BtnEdit.Location = new Point(51, 118);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 64);
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
            BtnNew.ImageAlign = ContentAlignment.TopCenter;
            BtnNew.Location = new Point(51, 33);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(75, 64);
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
            pictureBox1.Location = new Point(336, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 204);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(856, 498);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(DgProduct);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtName;
        private TextBox TxtId;
        private Label Nombre;
        private Label Id;
        private TextBox textBox1;
        private Label Price;
        private TextBox textBox3;
        private Label Category;
        private TextBox textBox2;
        private Label Stock;
        private DataGridView DgProduct;
        private GroupBox groupBox2;
        private Button BtnNew;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn NameProducto;
        private DataGridViewTextBoxColumn PriceProducto;
        private DataGridViewTextBoxColumn StockProducto;
        private DataGridViewTextBoxColumn CategoryProduct;
        private PictureBox pictureBox1;
    }
}