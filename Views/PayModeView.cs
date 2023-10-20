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
        private bool message;
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
                    if (e.KeyCode == Keys.Enter) { 

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
            get { return TxtSearchValue.Text; }
            set { TxtSearchValue.Text = value; }
        }

        public bool IsEdit
        {
            get { return IsEdit; }
            set { IsEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return IsSuccessful; }
            set { IsSuccessful = value; }
        }

        public bool Message
        {
            get { return Message; }
            set { Message = value; }
        }



        public string playModeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string playModeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string playModeOservation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PayModeView()
        {
            InitializeComponent();
        }

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
            public void show()
       




    

    public void show()
    {
        throw new NotImplementedException();
    }
}
}
