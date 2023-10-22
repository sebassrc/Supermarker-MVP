namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnSearch = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            DgPayMode = new DataGridView();
            tabPagePayModeDetail = new TabPage();
            TxtPayModeObservation = new TextBox();
            TxtPayModeId = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(163, 46);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 1;
            label1.Text = "Pay Mode";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 349);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(789, 321);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List ";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            tabPagePayModeList.Click += tabPagePayModeList_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(510, 47);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(103, 38);
            BtnSearch.TabIndex = 7;
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += PayModeView_Load;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(653, 263);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(115, 40);
            BtnClose.TabIndex = 6;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(653, 204);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(115, 40);
            BtnDelete.TabIndex = 5;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(653, 149);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(115, 40);
            BtnEdit.TabIndex = 4;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(653, 91);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(115, 40);
            BtnNew.TabIndex = 3;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(8, 63);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(496, 23);
            TxtSearch.TabIndex = 2;
            TxtSearch.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 30);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Search Pay Mode";
            label2.Click += label2_Click;
            // 
            // DgPayMode
            // 
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(8, 91);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.RowTemplate.Height = 25;
            DgPayMode.Size = new Size(605, 223);
            DgPayMode.TabIndex = 0;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label6);
            tabPagePayModeDetail.Controls.Add(label7);
            tabPagePayModeDetail.Controls.Add(label8);
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Size = new Size(789, 321);
            tabPagePayModeDetail.TabIndex = 2;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            tabPagePayModeDetail.Click += tabPage1_Click;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(253, 179);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode  Observation";
            TxtPayModeObservation.Size = new Size(283, 59);
            TxtPayModeObservation.TabIndex = 14;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(253, 37);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.ReadOnly = true;
            TxtPayModeId.Size = new Size(110, 23);
            TxtPayModeId.TabIndex = 13;
            TxtPayModeId.Text = "0";
            TxtPayModeId.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 150);
            label6.Name = "label6";
            label6.Size = new Size(130, 15);
            label6.TabIndex = 12;
            label6.Text = "Pay Mode  Observation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(253, 84);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 11;
            label7.Text = "Pay Mode  Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(253, 19);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 10;
            label8.Text = "Pay Mode Id";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(370, 255);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 46);
            BtnCancel.TabIndex = 9;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(257, 255);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 46);
            BtnSave.TabIndex = 8;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            Load += PayModeView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private DataGridView DgPayMode;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtSearch;
        private Label label2;

        public TextBox TxtPayModeName { get; private set; }
        private TabPage tabPagePayModeDetail;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeId;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtpayModeName;
        //private TextBox TxtPayModeName;
    }
}