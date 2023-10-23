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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supermarket.View
{
    public partial class Product : Form
    {


        private readonly CRUD_Product productDAO;
        private bool EditMode;
        private bool IsNew;


        internal Product(ref CRUD_Product productDAO)
        {
            InitializeComponent();
            this.productDAO = productDAO;
            LoadProductList();
            EditMode = false;
            IsNew = false;
        }

        private void LoadProductList()
        {
            DgProduct.Rows.Clear();
            foreach (KeyValuePair<int, Productt> productKV in this.productDAO.GetProduct())
            {
                DgProduct.Rows.Add(productKV.Value.Id, productKV.Value.Name, productKV.Value.Price, productKV.Value.Stock, productKV.Value.Category);
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgProduct_Click(object sender, EventArgs e)
        {
            TxtId.Text = DgProduct.CurrentRow.Cells[0].Value.ToString();
            TxtName.Text = DgProduct.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = DgProduct.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = DgProduct.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = DgProduct.CurrentRow.Cells[4].Value.ToString();
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
                if (SaveProduct() == false)
                {
                    return;
                };
                IsNew = false;
                EditMode = false;
            }
            TxtId.Text = "";
            TxtName.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
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
            textBox1.Enabled = state;
            textBox2.Enabled = state;
            textBox3.Enabled = state;
            DgProduct.Enabled = !state;
            BtnDelete.Enabled = !state;
            BtnClose.Enabled = !state;
            TxtName.Focus();
        }

        private bool SaveProduct()
        {
            if (!IsNameFilled())
            {
                return false;
            }
            if (IsNew == true)
            {
                Productt product = new(null, TxtName.Text, Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), textBox3.Text);

                if (productDAO.AddProduct(product) == false)
                {
                    MessageBox.Show("Error to save", "Alert",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Product save susessfuly", "Alert",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                LoadProductList();
            }
            else
            {
                int id = Int32.Parse(TxtId.Text);
                Productt product = productDAO.GetProduct(id);
                if (product != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }
                    product.Name = TxtName.Text;
                    productDAO.UpdateProduct(id, product);
                    LoadProductList();
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
                MessageBox.Show("The product name is required", "Alert",
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

        private void DgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                EditMode = false;
                ActivateControls(EditMode);
                return;
            }

            if (DgProduct.SelectedRows.Count > 0)
            {

                int selectedIndex = DgProduct.SelectedRows[0].Index;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DgProduct.Rows.RemoveAt(selectedIndex);

                    MessageBox.Show("Product deleted successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select a product to delete", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
