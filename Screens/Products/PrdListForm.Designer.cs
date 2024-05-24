namespace POSApp.Screens.Products
{
    partial class PrdListForm
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
            prdGridView = new DataGridView();
            label6 = new Label();
            label1 = new Label();
            txtPrdCode = new TextBox();
            txtPrdName = new TextBox();
            btnSearchProduct = new Button();
            btnReset = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnAddProduct = new Button();
            label7 = new Label();
            txtPrdQuantity = new TextBox();
            label2 = new Label();
            txtPrdNotes = new TextBox();
            label5 = new Label();
            txtPrdPrice = new TextBox();
            btnAddPrd = new Button();
            prdImage = new PictureBox();
            txtCustName = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            btnRemoveProduct = new Button();
            groupBox1 = new GroupBox();
            btnAddNewPrd = new Button();
            ((System.ComponentModel.ISupportInitialize)prdGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prdImage).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // prdGridView
            // 
            prdGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prdGridView.Location = new Point(12, 147);
            prdGridView.MultiSelect = false;
            prdGridView.Name = "prdGridView";
            prdGridView.ReadOnly = true;
            prdGridView.RowHeadersWidth = 51;
            prdGridView.Size = new Size(622, 423);
            prdGridView.TabIndex = 0;
            prdGridView.SelectionChanged += prdGridView_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 84);
            label6.Name = "label6";
            label6.Size = new Size(68, 31);
            label6.TabIndex = 20;
            label6.Text = "Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(278, 84);
            label1.Name = "label1";
            label1.Size = new Size(164, 31);
            label1.TabIndex = 21;
            label1.Text = "Product Name";
            // 
            // txtPrdCode
            // 
            txtPrdCode.Location = new Point(86, 90);
            txtPrdCode.Name = "txtPrdCode";
            txtPrdCode.Size = new Size(186, 27);
            txtPrdCode.TabIndex = 22;
            // 
            // txtPrdName
            // 
            txtPrdName.Location = new Point(448, 90);
            txtPrdName.Name = "txtPrdName";
            txtPrdName.Size = new Size(186, 27);
            txtPrdName.TabIndex = 23;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.White;
            btnSearchProduct.Location = new Point(683, 84);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(96, 33);
            btnSearchProduct.TabIndex = 24;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += btnAddProduct_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.Location = new Point(683, 123);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 33);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(725, 255);
            label10.Name = "label10";
            label10.Size = new Size(24, 31);
            label10.TabIndex = 43;
            label10.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(722, 328);
            label9.Name = "label9";
            label9.Size = new Size(24, 31);
            label9.TabIndex = 42;
            label9.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(725, 180);
            label8.Name = "label8";
            label8.Size = new Size(24, 31);
            label8.TabIndex = 41;
            label8.Text = "*";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.White;
            btnAddProduct.Location = new Point(1649, 586);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(131, 46);
            btnAddProduct.TabIndex = 40;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(508, 214);
            label7.Name = "label7";
            label7.Size = new Size(167, 31);
            label7.TabIndex = 39;
            label7.Text = "Product Image";
            // 
            // txtPrdQuantity
            // 
            txtPrdQuantity.Location = new Point(1321, 179);
            txtPrdQuantity.Multiline = true;
            txtPrdQuantity.Name = "txtPrdQuantity";
            txtPrdQuantity.Size = new Size(281, 34);
            txtPrdQuantity.TabIndex = 38;
            txtPrdQuantity.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1144, 182);
            label2.Name = "label2";
            label2.Size = new Size(103, 31);
            label2.TabIndex = 37;
            label2.Text = "Quantity";
            // 
            // txtPrdNotes
            // 
            txtPrdNotes.Location = new Point(828, 431);
            txtPrdNotes.Multiline = true;
            txtPrdNotes.Name = "txtPrdNotes";
            txtPrdNotes.Size = new Size(281, 110);
            txtPrdNotes.TabIndex = 36;
            txtPrdNotes.TextChanged += txtPrdNotes_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(651, 425);
            label5.Name = "label5";
            label5.Size = new Size(76, 31);
            label5.TabIndex = 35;
            label5.Text = "Notes";
            // 
            // txtPrdPrice
            // 
            txtPrdPrice.Location = new Point(828, 346);
            txtPrdPrice.Multiline = true;
            txtPrdPrice.Name = "txtPrdPrice";
            txtPrdPrice.Size = new Size(281, 34);
            txtPrdPrice.TabIndex = 34;
            // 
            // btnAddPrd
            // 
            btnAddPrd.BackColor = Color.Transparent;
            btnAddPrd.BackgroundImage = Properties.Resources.add;
            btnAddPrd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddPrd.FlatAppearance.BorderSize = 0;
            btnAddPrd.FlatStyle = FlatStyle.Flat;
            btnAddPrd.Location = new Point(1569, 583);
            btnAddPrd.Name = "btnAddPrd";
            btnAddPrd.Size = new Size(62, 49);
            btnAddPrd.TabIndex = 33;
            btnAddPrd.UseVisualStyleBackColor = false;
            // 
            // prdImage
            // 
            prdImage.BackColor = SystemColors.Control;
            prdImage.BackgroundImageLayout = ImageLayout.Stretch;
            prdImage.Location = new Point(1321, 246);
            prdImage.Name = "prdImage";
            prdImage.Size = new Size(281, 100);
            prdImage.SizeMode = PictureBoxSizeMode.StretchImage;
            prdImage.TabIndex = 32;
            prdImage.TabStop = false;
            prdImage.Click += prdImage_Click;
            // 
            // txtCustName
            // 
            txtCustName.Location = new Point(828, 272);
            txtCustName.Multiline = true;
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(281, 34);
            txtCustName.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(828, 183);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 34);
            textBox2.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(651, 340);
            label4.Name = "label4";
            label4.Size = new Size(65, 31);
            label4.TabIndex = 29;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(651, 266);
            label3.Name = "label3";
            label3.Size = new Size(76, 31);
            label3.TabIndex = 28;
            label3.Text = "Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(651, 186);
            label11.Name = "label11";
            label11.Size = new Size(68, 31);
            label11.TabIndex = 27;
            label11.Text = "Code";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1011, 115);
            label12.Name = "label12";
            label12.Size = new Size(208, 46);
            label12.TabIndex = 26;
            label12.Text = "Edit Product";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(1618, 171);
            button1.Name = "button1";
            button1.Size = new Size(131, 46);
            button1.TabIndex = 44;
            button1.Text = "Edit Product";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.BackColor = Color.White;
            btnRemoveProduct.Location = new Point(1618, 240);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(131, 46);
            btnRemoveProduct.TabIndex = 45;
            btnRemoveProduct.Text = "Remove Product";
            btnRemoveProduct.UseVisualStyleBackColor = false;
            btnRemoveProduct.Click += btnRemoveProduct_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnAddNewPrd);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(640, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1136, 509);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            // 
            // btnAddNewPrd
            // 
            btnAddNewPrd.BackColor = Color.White;
            btnAddNewPrd.Location = new Point(937, 39);
            btnAddNewPrd.Name = "btnAddNewPrd";
            btnAddNewPrd.Size = new Size(172, 46);
            btnAddNewPrd.TabIndex = 47;
            btnAddNewPrd.Text = "Add New Product";
            btnAddNewPrd.UseVisualStyleBackColor = false;
            btnAddNewPrd.Click += btnAddNewPrd_Click;
            // 
            // PrdListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1788, 582);
            Controls.Add(btnRemoveProduct);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnAddProduct);
            Controls.Add(txtPrdQuantity);
            Controls.Add(label2);
            Controls.Add(txtPrdNotes);
            Controls.Add(label5);
            Controls.Add(txtPrdPrice);
            Controls.Add(btnAddPrd);
            Controls.Add(prdImage);
            Controls.Add(txtCustName);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(btnReset);
            Controls.Add(btnSearchProduct);
            Controls.Add(txtPrdName);
            Controls.Add(txtPrdCode);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(prdGridView);
            Controls.Add(groupBox1);
            Name = "PrdListForm";
            Text = "PrdListForm";
            ((System.ComponentModel.ISupportInitialize)prdGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)prdImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView prdGridView;
        private Label label6;
        private Label label1;
        private TextBox txtPrdCode;
        private TextBox txtPrdName;
        private Button btnSearchProduct;
        private Button btnReset;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnAddProduct;
        private Label label7;
        private TextBox txtPrdQuantity;
        private Label label2;
        private TextBox txtPrdNotes;
        private Label label5;
        private TextBox txtPrdPrice;
        private Button btnAddPrd;
        private PictureBox prdImage;
        private TextBox txtCustName;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label11;
        private Label label12;
        private Button button1;
        private Button btnRemoveProduct;
        private GroupBox groupBox1;
        private Button btnAddNewPrd;
    }
}