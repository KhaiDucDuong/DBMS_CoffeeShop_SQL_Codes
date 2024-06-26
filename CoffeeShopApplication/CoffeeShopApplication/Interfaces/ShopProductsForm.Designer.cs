﻿using System.Resources;
using System.Windows.Forms;

namespace CoffeeShopApplication
{
    partial class ShopProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopProductsForm));
            tbSearch = new TextBox();
            dgvProducts = new DataGridView();
            coffeeShopDatasetBindingSource = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            pbSearch = new PictureBox();
            pbAdd = new PictureBox();
            header1 = new UC.Header();
            tbId = new TextBox();
            label1 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbSize = new ComboBox();
            tbPrice = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbDeleted = new ComboBox();
            pbSave = new PictureBox();
            pbRefresh = new PictureBox();
            pbDelete = new PictureBox();
            productBindingSource1 = new BindingSource(components);
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeShopDatasetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            tbSearch.ForeColor = SystemColors.ScrollBar;
            tbSearch.Location = new Point(12, 301);
            tbSearch.Margin = new Padding(3, 2, 3, 2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(549, 53);
            tbSearch.TabIndex = 6;
            tbSearch.Text = "Search";
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, productSizeDataGridViewTextBoxColumn, productPriceDataGridViewTextBoxColumn, createdAtDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn });
            dgvProducts.DataSource = productBindingSource1;
            dgvProducts.Location = new Point(12, 378);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(1026, 354);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // coffeeShopDatasetBindingSource
            // 
            coffeeShopDatasetBindingSource.DataSource = typeof(CoffeeShopDataset);
            coffeeShopDatasetBindingSource.Position = 0;
            // 
            // productBindingSource
            // 
            productBindingSource.DataMember = "Product";
            productBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.search1;
            pbSearch.Location = new Point(588, 301);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(55, 55);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 8;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            pbSearch.MouseLeave += pbSearch_MouseLeave;
            pbSearch.MouseHover += pbSearch_MouseHover;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.Location = new Point(678, 301);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(55, 55);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 8;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            pbAdd.MouseLeave += pbAdd_MouseLeave;
            pbAdd.MouseHover += pbAdd_MouseHover;
            // 
            // header1
            // 
            header1.BackColor = SystemColors.MenuHighlight;
            header1.ForeColor = SystemColors.Highlight;
            header1.Location = new Point(0, -2);
            header1.Margin = new Padding(3, 2, 3, 2);
            header1.Name = "header1";
            header1.Size = new Size(1050, 125);
            header1.TabIndex = 9;
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.Location = new Point(99, 148);
            tbId.Multiline = true;
            tbId.Name = "tbId";
            tbId.Size = new Size(333, 42);
            tbId.TabIndex = 1;
            tbId.TextChanged += tbId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 151);
            label1.Name = "label1";
            label1.Size = new Size(40, 32);
            label1.TabIndex = 11;
            label1.Text = "ID";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(697, 148);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(314, 42);
            tbName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(589, 151);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 11;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(399, 220);
            label3.Name = "label3";
            label3.Size = new Size(59, 32);
            label3.TabIndex = 11;
            label3.Text = "Size";
            label3.Click += label3_Click;
            // 
            // cbSize
            // 
            cbSize.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSize.FormattingEnabled = true;
            cbSize.Items.AddRange(new object[] { "Lớn", "Vừa", "Nhỏ" });
            cbSize.Location = new Point(501, 217);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(144, 40);
            cbSize.TabIndex = 4;
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrice.Location = new Point(99, 214);
            tbPrice.Multiline = true;
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(212, 43);
            tbPrice.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 220);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 11;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(757, 215);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 11;
            label5.Text = "Deleted";
            // 
            // cbDeleted
            // 
            cbDeleted.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDeleted.FormattingEnabled = true;
            cbDeleted.Items.AddRange(new object[] { "Yes", "No" });
            cbDeleted.Location = new Point(865, 214);
            cbDeleted.Name = "cbDeleted";
            cbDeleted.Size = new Size(146, 40);
            cbDeleted.TabIndex = 5;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(772, 301);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(55, 55);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 8;
            pbSave.TabStop = false;
            pbSave.Click += pbSave_Click;
            pbSave.MouseLeave += pbSave_MouseLeave;
            pbSave.MouseHover += pbSave_MouseHover;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(956, 301);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(55, 55);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 8;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            pbRefresh.MouseLeave += pbRefresh_MouseLeave;
            pbRefresh.MouseHover += pbRefresh_MouseHover;
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(865, 301);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(55, 55);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 8;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            pbDelete.MouseLeave += pbDelete_MouseLeave;
            pbDelete.MouseHover += pbDelete_MouseHover;
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataMember = "Product";
            productBindingSource1.DataSource = typeof(CoffeeShopDataset);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            productIdDataGridViewTextBoxColumn.HeaderText = "productId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productSizeDataGridViewTextBoxColumn
            // 
            productSizeDataGridViewTextBoxColumn.DataPropertyName = "productSize";
            productSizeDataGridViewTextBoxColumn.HeaderText = "productSize";
            productSizeDataGridViewTextBoxColumn.Name = "productSizeDataGridViewTextBoxColumn";
            productSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            productPriceDataGridViewTextBoxColumn.DataPropertyName = "productPrice";
            productPriceDataGridViewTextBoxColumn.HeaderText = "productPrice";
            productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            createdAtDataGridViewTextBoxColumn.DataPropertyName = "createdAt";
            createdAtDataGridViewTextBoxColumn.HeaderText = "createdAt";
            createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            updatedAtDataGridViewTextBoxColumn.DataPropertyName = "updatedAt";
            updatedAtDataGridViewTextBoxColumn.HeaderText = "updatedAt";
            updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ShopProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 744);
            Controls.Add(cbDeleted);
            Controls.Add(cbSize);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(tbPrice);
            Controls.Add(label1);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(header1);
            Controls.Add(pbDelete);
            Controls.Add(pbRefresh);
            Controls.Add(pbSave);
            Controls.Add(pbAdd);
            Controls.Add(pbSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvProducts);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShopProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Products";
            Load += ShopProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeShopDatasetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbSearch;
        private DataGridView dgvProducts;
        private BindingSource productBindingSource;
        private PictureBox pbSearch;
        private PictureBox pbAdd;
        private UC.Header header1;
        private TextBox tbId;
        private Label label1;
        private TextBox tbName;
        private Label label2;
        private Label label3;
        private ComboBox cbSize;
        private TextBox tbPrice;
        private Label label4;
        private Label label5;
        private ComboBox cbDeleted;
        private PictureBox pbSave;
        private PictureBox pbRefresh;
        private PictureBox pbDelete;
        private BindingSource coffeeShopDatasetBindingSource;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private BindingSource productBindingSource1;
    }
}