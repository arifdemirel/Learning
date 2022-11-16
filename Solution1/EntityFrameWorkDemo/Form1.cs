using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EntityFrameWorkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productdal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadProducts();

        }

        private void ReloadProducts()
        {
            dgwProducts.DataSource = _productdal.GetAll();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productdal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
            }

            );
            ReloadProducts();
            MessageBox.Show("Product Added");
        }

        private void btnUpdate_Click(object sender, EventArgs e)

        {
            _productdal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)

            }
            );
            ReloadProducts();
            MessageBox.Show("Product Updated");

        }

        

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productdal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
            });

            ReloadProducts();
            MessageBox.Show("Product Deleted");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void SearchProducts(string key)
        {
            //dgwProducts.DataSource = _productdal.GetAll().Where(p => p.Name.Contains(key));
            var result = _productdal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList(); //en son olarak, tekrardan to list eklemeliyizki DataGrid'deki görüntülenebilecek şekilde veri taşınabilsin ya da doğrudan çağırdığımız metoda gömüyoruz. Product.Dal'ada GetByName metoduna bakınız
            //var result = _productdal.GetByName(key);
            dgwProducts.DataSource = result;
        }

        private void tbxGetById_Click(object sender, EventArgs e)
        {
            var keyId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productdal.GetById(keyId);
            dgwProducts.DataSource = _productdal.GetById(keyId);

        }
    }
}
