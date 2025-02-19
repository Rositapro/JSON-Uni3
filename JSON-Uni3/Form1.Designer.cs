namespace JSON_Uni3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btndDelete = new Button();
            btnShow = new Button();
            btnSaveJson = new Button();
            txtId = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 169);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(432, 203);
            dgvProducts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 144);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 5;
            label5.Text = "Search";
            // 
            // txtName
            // 
            txtName.Location = new Point(84, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(84, 82);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(84, 111);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(84, 140);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(190, 140);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(191, 53);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btndDelete
            // 
            btndDelete.Location = new Point(191, 82);
            btndDelete.Name = "btndDelete";
            btndDelete.Size = new Size(75, 23);
            btndDelete.TabIndex = 12;
            btndDelete.Text = "Delete";
            btndDelete.UseVisualStyleBackColor = true;
            btndDelete.Click += btndDelete_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(191, 111);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 13;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnSaveJson
            // 
            btnSaveJson.Location = new Point(272, 139);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(75, 23);
            btnSaveJson.TabIndex = 15;
            btnSaveJson.Text = "Save Json";
            btnSaveJson.UseVisualStyleBackColor = true;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(84, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 28);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 16;
            label3.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(btnSaveJson);
            Controls.Add(btnShow);
            Controls.Add(btndDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btndDelete;
        private Button btnShow;
        private Button btnSaveJson;
        private TextBox txtId;
        private Label label3;
    }
}
