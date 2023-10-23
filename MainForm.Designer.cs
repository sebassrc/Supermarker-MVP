namespace Supermarket
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainMenu = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            MasterMenuItem = new ToolStripMenuItem();
            ProductsMenuItem = new ToolStripMenuItem();
            ProvidersMenuItem = new ToolStripMenuItem();
            CategoriesMenuItem = new ToolStripMenuItem();
            PayModeMenuItem = new ToolStripMenuItem();
            TransactionsMenuItem = new ToolStripMenuItem();
            SellMenuItem = new ToolStripMenuItem();
            PurchaseMenuItem = new ToolStripMenuItem();
            HelpMenuItem = new ToolStripMenuItem();
            AboutMenuItem = new ToolStripMenuItem();
            MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.BackColor = SystemColors.ControlText;
            MainMenu.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MainMenu.Items.AddRange(new ToolStripItem[] { FileMenuItem, MasterMenuItem, TransactionsMenuItem, HelpMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(820, 27);
            MainMenu.TabIndex = 0;
            MainMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitMenuItem });
            FileMenuItem.ForeColor = Color.DarkViolet;
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(51, 23);
            FileMenuItem.Text = "File ";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(110, 24);
            ExitMenuItem.Text = "Exit ";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // MasterMenuItem
            // 
            MasterMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ProductsMenuItem, ProvidersMenuItem, CategoriesMenuItem, PayModeMenuItem });
            MasterMenuItem.ForeColor = Color.DarkViolet;
            MasterMenuItem.Name = "MasterMenuItem";
            MasterMenuItem.Size = new Size(73, 23);
            MasterMenuItem.Text = "Master ";
            // 
            // ProductsMenuItem
            // 
            ProductsMenuItem.Name = "ProductsMenuItem";
            ProductsMenuItem.Size = new Size(154, 24);
            ProductsMenuItem.Text = "Products ";
            ProductsMenuItem.Click += ProductsMenuItem_Click;
            // 
            // ProvidersMenuItem
            // 
            ProvidersMenuItem.Name = "ProvidersMenuItem";
            ProvidersMenuItem.Size = new Size(154, 24);
            ProvidersMenuItem.Text = "Providers ";
            ProvidersMenuItem.Click += ProvidersMenuItem_Click;
            // 
            // CategoriesMenuItem
            // 
            CategoriesMenuItem.Name = "CategoriesMenuItem";
            CategoriesMenuItem.Size = new Size(154, 24);
            CategoriesMenuItem.Text = "Categories ";
            CategoriesMenuItem.Click += CategoriesMenuItem_Click;
            // 
            // PayModeMenuItem
            // 
            PayModeMenuItem.Name = "PayModeMenuItem";
            PayModeMenuItem.Size = new Size(154, 24);
            PayModeMenuItem.Text = "Pay Mode";
            PayModeMenuItem.Click += PayModeMenuItem_Click;
            // 
            // TransactionsMenuItem
            // 
            TransactionsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SellMenuItem, PurchaseMenuItem });
            TransactionsMenuItem.ForeColor = Color.DarkViolet;
            TransactionsMenuItem.Name = "TransactionsMenuItem";
            TransactionsMenuItem.Size = new Size(111, 23);
            TransactionsMenuItem.Text = "Transactions";
            // 
            // SellMenuItem
            // 
            SellMenuItem.Name = "SellMenuItem";
            SellMenuItem.Size = new Size(145, 24);
            SellMenuItem.Text = "Sell ";
            // 
            // PurchaseMenuItem
            // 
            PurchaseMenuItem.Name = "PurchaseMenuItem";
            PurchaseMenuItem.Size = new Size(145, 24);
            PurchaseMenuItem.Text = "Purchase ";
            // 
            // HelpMenuItem
            // 
            HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutMenuItem });
            HelpMenuItem.ForeColor = Color.DarkViolet;
            HelpMenuItem.Name = "HelpMenuItem";
            HelpMenuItem.Size = new Size(53, 23);
            HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.Size = new Size(122, 24);
            AboutMenuItem.Text = "About ";
            AboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(820, 450);
            Controls.Add(MainMenu);
            IsMdiContainer = true;
            MainMenuStrip = MainMenu;
            Name = "MainForm";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem MasterMenuItem;
        private ToolStripMenuItem ProductsMenuItem;
        private ToolStripMenuItem ProvidersMenuItem;
        private ToolStripMenuItem CategoriesMenuItem;
        private ToolStripMenuItem PayModeMenuItem;
        private ToolStripMenuItem TransactionsMenuItem;
        private ToolStripMenuItem SellMenuItem;
        private ToolStripMenuItem PurchaseMenuItem;
        private ToolStripMenuItem HelpMenuItem;
        private ToolStripMenuItem AboutMenuItem;
    }
}