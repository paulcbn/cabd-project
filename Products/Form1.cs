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
            UpdateIntervals();
        }


        private void UpdateTypes()
        {
            typesGridView.Rows.Clear();
            createUpdateComboBox.Items.Clear();

            foreach (var type in productsRepo.GetAllStockTypes())
            {
                typesGridView.Rows.Add(type.SId, type.Name);
                createUpdateComboBox.Items.Add(type);
            }
        }
        private void UpdateProducts()
        {
            productsGridView.Rows.Clear();
            deleteComboBox.Items.Clear();
            comboBox1.Items.Clear();

            foreach (var product in productsRepo.GetAllProducts())
            {
                productsGridView.Rows.Add(product.Name, product.Price, product.StockStatusType.Name, product.UpdatedAt);
                deleteComboBox.Items.Add(product);
                comboBox1.Items.Add(product);
            }
        }

        private void UpdateIntervals()
        {
            intervalDataGridView.Rows.Clear();

            foreach(var interval in productsRepo.GetProductsPriceStreak())
            {
                intervalDataGridView.Rows.Add(interval.Name, interval.Price, interval.BeginDate, interval.EndDate, interval.Interval);
            }
        }
        private void UpdateGraph(string name)
        {
            chart1.Series[0].Points.Clear();

            foreach(var product in productsRepo.GetProductSimpleHistory(name))
            {
                chart1.Series[0].Points.AddXY(product.UpdatedAt, product.Price);
            }
        }
        private void UpdateDelta(string name)
        {
            deltaDataGridView.Rows.Clear();

            foreach(var productDelta in productsRepo.GetProductDeltaHistory(name))
            {
                deltaDataGridView.Rows.Add(productDelta.Name, productDelta.Price, productDelta.DeltaPrice, productDelta.DeltaTime, productDelta.UpdatedAt);
            }
        }

        private void CreateUpdateButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "") {
                ShowMessageBox("Name should not be empty!");
                return; 
            }

            if(!float.TryParse(priceTextBox.Text, out float price)) {
                ShowMessageBox("Price should be a number!");
                return; 
            }

            if (createUpdateComboBox.SelectedItem == null) {
                ShowMessageBox("Product type should not be empty!");
                return; 
            }


            var name = nameTextBox.Text;
            var sid = (createUpdateComboBox.SelectedItem as StockStatusType).SId;

            productsRepo.CreateOrUpdateProduct(name, price, sid);
            UpdateProducts();
            UpdateIntervals();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (deleteComboBox.SelectedItem == null) {
                ShowMessageBox("Product should not be empty!");
                return; 
            }

            productsRepo.DeleteProduct(deleteComboBox.SelectedItem as Product);
            UpdateProducts();
            UpdateIntervals();
        }

        private void CustomProductButton_Click(object sender, EventArgs e)
        {
            if (tMomentTextBox.Text == "")
            {
                ShowMessageBox("Name should not be empty!");
                return;
            }

            customProductGrid.Rows.Clear();
            var prod = productsRepo.GetCustomStateProduct(tMomentTextBox.Text, tMomentDatePicker.Value);

            if (prod != null)
            {
                customProductGrid.Rows.Add(prod.Name, prod.Price.ToString(), prod.UpdatedAt.ToString(), prod.StockStatusType.Name);
            }
        }

        private void ShowMessageBox(string text)
        {
            MessageBox.Show(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateIntervals();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                ShowMessageBox("Product should not be empty!");
                return;
            }


            UpdateGraph((comboBox1.SelectedItem as Product).Name);
            UpdateDelta((comboBox1.SelectedItem as Product).Name);
        }
    }
}
