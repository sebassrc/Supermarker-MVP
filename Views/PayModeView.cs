﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        private TabPage tabPagePatModeDatil;

        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPagePayModeDetail);

            BtnClose.Click += delegate { this.Close(); };

        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Add New Pay Mode";
            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Edit Pay Mode";
            };

            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Pay mode",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPagePayModeDetai);
                    tabControl1.TabPages.Add(tabPagePayModeList);
                }

                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePayModeDetai);
                tabControl1.TabPages.Add(tabPagePayModeList);
            };
        }

        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }

        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }

        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }

        }
        public string SearchValue
        {

            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string playModeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string playModeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string playModeOservation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Action<object?, EventArgs> IPayModeView.CancelEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Action<object?, EventArgs> IPayModeView.SaveEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Action<object?, EventArgs> IPayModeView.DeleteEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Action<object?, EventArgs> IPayModeView.EditEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Action<object?, EventArgs> IPayModeView.SearchEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Action<object?, EventArgs> IPayModeView.AddNewEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void PayModeView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void DgPayMode_CellContentClick(object sender, EventArgs e)
        {
            try
            {
                TxtPayModeId.Text = DgPayMode.CurrentRow.Cells[0].Value.ToString();
                TxtpayModeName.Text = DgPayMode.CurrentRow.Cells[1].Value.ToString();
                TxtPayModeObservation.Text = DgPayMode.CurrentRow.Cells[2].Value.ToString();

            }
            catch
            {

            }
        }


        public void SetPayModeListBildingSource(BindingSource payModeList)
        {


            DgPayMode.DataSource = payModeList;
        }

        private static PayModeView instance;





        public static PayModeView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;


            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {

                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }

            return instance;
        }

        public void show()
        {
            throw new NotImplementedException();
        }

        private void tabPagePayModeList_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}



