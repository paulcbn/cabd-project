using Products.Models;
using Products.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class Form1 : Form
    {

        ProductsRepo productsRepo = new ProductsRepo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTypes();
            UpdateProducts();
        }


        private void UpdateTypes()
        {
            dataGridView2.Rows.Clear();
            comboBox1.Items.Clear();

            foreach (var type in productsRepo.GetAllStockTypes())
            {
                dataGridView2.Rows.Add(type.SId, type.Name);
                comboBox1.Items.Add(type);
            }
        }
        private void UpdateProducts()
        {
            dataGridView1.Rows.Clear();
            comboBox2.Items.Clear();

            foreach (var product in productsRepo.GetAllProducts())
            {
                dataGridView1.Rows.Add(product.Name, product.Price, product.StockStatusType.Name, product.UpdatedAt);
                comboBox2.Items.Add(product);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "") { return; }

            if(!float.TryParse(textBox2.Text, out float price)) { return; }

            if (comboBox1.SelectedItem == null) { return; }


            var name = textBox1.Text;
            var sid = (comboBox1.SelectedItem as StockStatusType).SId;

            productsRepo.CreateOrUpdateProduct(name, price, sid);
            UpdateProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null) { return; }

            productsRepo.DeleteProduct(comboBox2.SelectedItem as Product);
            UpdateProducts();
        }
    }
}
