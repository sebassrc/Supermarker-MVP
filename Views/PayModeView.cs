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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {


            DgPayMode.DataSource = payModeList;
        }

        private static PayModeView instance;


        


        public static PayModeView GetInstance()
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView ();

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
    }
}



