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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supermarket.View
{
    public partial class Categories : Form
    {
        private readonly CRUD_Categories categoriesDAO;
        private bool EditMode;
        private bool IsNew;


        internal Categories(ref CRUD_Categories categoriesDAO)
        {
            InitializeComponent();
            this.categoriesDAO = categoriesDAO;
            CategoriesList();
            EditMode = false;
            IsNew = false;
        }


        private void CategoriesList()
        {
            DgCategories.Rows.Clear();
            foreach (KeyValuePair<int, Categoriess> payModeKV in this.categoriesDAO.GetCategories())
            {
                DgCategories.Rows.Add(payModeKV.Value.Id, payModeKV.Value.Name, payModeKV.Value.Desc, payModeKV.Value.Envase);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (SaveCategories() == false)
                {
                    return;
                };
                IsNew = false;
                EditMode = false;
            }
            TxtId.Text = "";
            TxtName.Text = "";
            txtDesc.Text = "";
            txtEnv.Text = "";
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
            txtDesc.Enabled = state;
            txtEnv.Enabled = state;
            DgCategories.Enabled = !state;
            BtnDelete.Enabled = !state;
            BtnClose.Enabled = !state;
            TxtName.Focus();
        }

        private bool SaveCategories()
        {
            if (!IsNameFilled())
            {
                return false;
            }
            if (IsNew == true)
            {
                Categoriess categories = new(null, TxtName.Text, txtDesc.Text, Convert.ToChar(txtEnv.Text));

                if (categoriesDAO.AddCategories(categories) == false)
                {
                    MessageBox.Show("Error to save", "Alert",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Categorie save susessfuly", "Alert",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                CategoriesList();
            }
            else
            {
                int id = Int32.Parse(TxtId.Text);
                Categoriess categories = categoriesDAO.GetCategories(id);
                if (categories != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }
                    categories.Name = TxtName.Text;
                    categoriesDAO.UpdateCategories(id, categories);
                    CategoriesList();
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
                MessageBox.Show("The Categorie name is required", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TxtName.Focus();
                return false;
            }
            return true;

        }




        private void DgCategories_Click(object sender, EventArgs e)
        {
            TxtId.Text = DgCategories.CurrentRow.Cells[0].Value.ToString();
            TxtName.Text = DgCategories.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = DgCategories.CurrentRow.Cells[2].Value.ToString();
            txtEnv.Text = DgCategories.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                EditMode = false;
                ActivateControls(EditMode);
                return;
            }

            if (DgCategories.SelectedRows.Count > 0)
            {

                int selectedIndex = DgCategories.SelectedRows[0].Index;


                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DgCategories.Rows.RemoveAt(selectedIndex);

                    MessageBox.Show("Category deleted successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select a category to delete", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                    MessageBox.Show("Select one Categorie of the list", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    return;
                };
                EditMode = true;
                IsNew = false;

            }
            ActivateControls(EditMode);
        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DgCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
