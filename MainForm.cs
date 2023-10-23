using Supermarket.Business;
using Supermarket.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class MainForm : Form
    {
        internal CRUD_PayModel payModeDAO;
        internal CRUD_Product productDAO;
        internal CRUD_Providers providersDAO;
        internal CRUD_Categories categoriesDAO;
        public MainForm()
        {

            payModeDAO = new CRUD_PayModel();
            InitializeComponent();
            payModeDAO.AddPayMode(new Model.PayMode(null, "Credit card"));


            productDAO = new CRUD_Product();
            productDAO.AddProduct(new Supermarket.Model.Productt(null, "Reloj Inteligente FitPro", 200, 70, " Dispositivos portátiles"));


            providersDAO = new CRUD_Providers();
            providersDAO.Addproviders(new Model.Providerss(null, "EcoDisposity S.A.S"));


            categoriesDAO = new CRUD_Categories();
            categoriesDAO.AddCategories(new Model.Categoriess(null, "Dispositivos portátiles", "Reloj inteligente", 'D'));

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Bienvenido a Supermarket V 0.1!\n\nGracias por elegir nuestra aplicación para tus compras. " +
                "Esperamos que tengas una experiencia de compra excepcional con nosotros.", "Acerca de nosotros");

        }

        private void PayModeMenuItem_Click(object sender, EventArgs e)
        {
            PayModels formPayMode = new PayModels(ref payModeDAO);
            formPayMode.MdiParent = this;
            formPayMode.Show();
        }

        private void ProductsMenuItem_Click(object sender, EventArgs e)
        {
            Product productform = new Product(ref productDAO);
            productform.MdiParent = this;
            productform.Show();

        }

        private void ProvidersMenuItem_Click(object sender, EventArgs e)
        {
            Providers providersform = new Providers(ref providersDAO);
            providersform.MdiParent = this;
            providersform.Show();
        }

        private void CategoriesMenuItem_Click(object sender, EventArgs e)
        {
            Categories categoriesform = new Categories(ref categoriesDAO);
            categoriesform.MdiParent = this;
            categoriesform.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
