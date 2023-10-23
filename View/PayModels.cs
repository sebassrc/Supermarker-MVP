using Supermarket.Business;
using Supermarket.Model;
using Supermarket.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Supermarket.View
{
    public partial class PayModels : Form
    {

        private readonly CRUD_PayModel payModeDAO;
        private bool EditMode;
        private bool IsNew;



        internal PayModels(ref CRUD_PayModel payModeDAO)
        {
            InitializeComponent();
            this.payModeDAO = payModeDAO;
            LoadPayModeList();
            EditMode = false;
            IsNew = false;
        }

        private void LoadPayModeList()
        {
            DgPayMode.Rows.Clear();
            foreach (KeyValuePair<int, Model.PayMode> payModeKV in this.payModeDAO.GetPayModeList())
            {
                DgPayMode.Rows.Add(payModeKV.Value.Id, payModeKV.Value.Name);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgPayMode_Click(object sender, EventArgs e)
        {
            TxtId.Text = DgPayMode.CurrentRow.Cells[0].Value.ToString();
            TxtName.Text = DgPayMode.CurrentRow.Cells[1].Value.ToString();

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (EditMode == false)
            {
                EditMode = true;
                IsNew = true;
            }
            else
            {
                if (SavePayMode() == false)
                {
                    return;
                };
                IsNew = false;
                EditMode = false;
            }
            TxtId.Text = "";
            TxtName.Text = "";
            ActivateControls(EditMode);
        }
        private void ActivateControls(bool state)
        {
            if (EditMode == true)
            {
                BtnNew.Text = "Save";
                BtnNew.Image = Resources.save;
                BtnEdit.Text = "Cancel";
                BtnEdit.Image = Resources.cancel;
            }
            else
            {
                BtnNew.Text = "New";
                BtnNew.Image = Resources._new;
                BtnEdit.Text = "Edit";
                BtnEdit.Image = Resources.edit;
            }
            TxtName.Enabled = state;
            DgPayMode.Enabled = !state;
            BtnDelete.Enabled = !state;
            BtnClose.Enabled = !state;
            TxtName.Focus();
        }
        private bool SavePayMode()
        {
            if (!IsNameFilled())
            {
                return false;
            }
            if (IsNew == true)
            {
                Model.PayMode payMode = new(null, TxtName.Text);

                if (payModeDAO.AddPayMode(payMode) == false)
                {
                    MessageBox.Show("Error to save", "Alert",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Pay mode save susessfuly", "Alert",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                LoadPayModeList();
            }
            else
            {
                int id = Int32.Parse(TxtId.Text);
                Model.PayMode payMode = payModeDAO.GetPayMode(id);
                if (payMode != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }
                    payMode.Name = TxtName.Text;
                    payModeDAO.UpdatePayMode(id, payMode);
                    LoadPayModeList();
                    return true;
                }
                return false;
            }
            return true;
        }
        private bool IsNameFilled()
        {
            if ((TxtName.Text).Trim().Length == 0)
            {
                MessageBox.Show("The Pay mode name is required", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TxtName.Focus();
                return false;
            }
            return true;

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (EditMode == true)
            {
                EditMode = false;
            }
            else
            {
                if (TxtName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Select one register of the list", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    return;
                };
                EditMode = true;
                IsNew = false;

            }
            ActivateControls(EditMode);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                EditMode = false;
                ActivateControls(EditMode);
                return;
            }

            if (DgPayMode.SelectedRows.Count > 0)
            {

                int selectedIndex = DgPayMode.SelectedRows[0].Index;


                DialogResult result = MessageBox.Show("Are you sure you want to delete this payment mode?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DgPayMode.Rows.RemoveAt(selectedIndex);

                    MessageBox.Show("Payment mode deleted successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select a payment mode to delete", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void PayModeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
