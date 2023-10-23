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

namespace Supermarket.View
{
    public partial class Providers : Form
    {

        private readonly CRUD_Providers providersDAO;
        private bool EditMode;
        private bool IsNew;



        internal Providers(ref CRUD_Providers providersDAO)
        {
            InitializeComponent();
            this.providersDAO = providersDAO;
            ProvidersList();
            EditMode = false;
            IsNew = false;
        }
        private void ProvidersList()
        {
            DgProviders.Rows.Clear();
            foreach (KeyValuePair<int, Providerss> payModeKV in this.providersDAO.GetProviders())
            {
                DgProviders.Rows.Add(payModeKV.Value.Id, payModeKV.Value.Providers);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgProviders_Click(object sender, EventArgs e)
        {
            TxtId.Text = DgProviders.CurrentRow.Cells[0].Value.ToString();
            TxtName.Text = DgProviders.CurrentRow.Cells[1].Value.ToString();
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
                if (SaveProvider() == false)
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
            DgProviders.Enabled = !state;
            BtnDelete.Enabled = !state;
            BtnClose.Enabled = !state;
            TxtName.Focus();
        }

        private bool SaveProvider()
        {
            if (!IsNameFilled())
            {
                return false;
            }
            if (IsNew == true)
            {
                Providerss providers = new(null, TxtName.Text);

                if (providersDAO.Addproviders(providers) == false)
                {
                    MessageBox.Show("Error to save", "Alert",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Provider save susessfuly", "Alert",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                ProvidersList();
            }
            else
            {
                int id = Int32.Parse(TxtId.Text);
                Providerss providers = providersDAO.GetProviders(id);
                if (providers != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }
                    providers.Providers = TxtName.Text;
                    providersDAO.UpdateProviders(id, providers);
                    ProvidersList();
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
                MessageBox.Show("The Provider name is required", "Alert",
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
                    MessageBox.Show("Select one Provider of the list", "Alert",
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

            if (DgProviders.SelectedRows.Count > 0)
            {
                int selectedIndex = DgProviders.SelectedRows[0].Index;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this provider?", "Confirmation",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Elimina la fila seleccionada del DataGridView
                    DgProviders.Rows.RemoveAt(selectedIndex);

                    MessageBox.Show("Provider deleted successfully", "Success",

                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select a provider to delete", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Providers_Load(object sender, EventArgs e)
        {

        }
    }
}
