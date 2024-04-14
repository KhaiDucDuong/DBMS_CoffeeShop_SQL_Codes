﻿using CoffeeShopApplication.BL;
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

namespace CoffeeShopApplication.Interfaces
{
    public partial class ShopRestockBillsForm : Form
    {
        public ShopRestockBillsForm()
        {
            InitializeComponent();
        }

        private void ShopRestockBillsForm_Load(object sender, EventArgs e)
        {
            DataSet restockBillDataSet = RestockBillBL.getAllRestockBills();
            dgvRestockBills.DataSource = restockBillDataSet.Tables[0].DefaultView;
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {

        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            String date, suppliername;
            date = dtpRestockBill.Value.ToString("MM/dd/yyyy");
            suppliername = tbSupplierName.Text;
            if (RestockBillBL.addRestockBill(date, suppliername))
            {
                MessageBox.Show("Added a new row successfully!", "Action result");
                DataSet productDataSet = RestockBillBL.getAllRestockBills();
                dgvRestockBills.DataSource = productDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to add a row! Check your input data!", "Action result");
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length > 0)
            {
                DataSet restockBillDataSet = RestockBillBL.findRestockBillById(tbSearch.Text);
                dgvRestockBills.DataSource = restockBillDataSet.Tables[0].DefaultView;
            }
        }
    }
}
