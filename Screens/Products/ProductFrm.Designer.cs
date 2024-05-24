namespace POSApp.Screens.Products
{
    partial class ProductFrm
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
            btnAddPrd = new Button();
            prdImage = new PictureBox();
            txtPrdName = new TextBox();
            txtPrdCode = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPrdPrice = new TextBox();
            txtPrdNotes = new TextBox();
            label5 = new Label();
            txtPrdQuantity = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnAddProduct = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)prdImage).BeginInit();
            SuspendLayout();
            // 
            // btnAddPrd
            // 
            btnAddPrd.BackColor = Color.Transparent;
            btnAddPrd.BackgroundImage = Properties.Resources.add;
            btnAddPrd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddPrd.FlatAppearance.BorderSize = 0;
            btnAddPrd.FlatStyle = FlatStyle.Flat;
            btnAddPrd.Location = new Point(959, 500);
            btnAddPrd.Name = "btnAddPrd";
            btnAddPrd.Size = new Size(62, 49);
            btnAddPrd.TabIndex = 15;
            btnAddPrd.UseVisualStyleBackColor = false;
            // 
            // prdImage
            // 
            prdImage.BackColor = SystemColors.Control;
            prdImage.BackgroundImageLayout = ImageLayout.Stretch;
            prdImage.Location = new Point(959, 196);
            prdImage.Name = "prdImage";
            prdImage.Size = new Size(281, 277);
            prdImage.SizeMode = PictureBoxSizeMode.StretchImage;
            prdImage.TabIndex = 14;
            prdImage.TabStop = false;
            prdImage.Click += prdImage_Click;
            // 
            // txtPrdName
            // 
            txtPrdName.Location = new Point(218, 189);
            txtPrdName.Multiline = true;
            txtPrdName.Name = "txtPrdName";
            txtPrdName.Size = new Size(281, 34);
            txtPrdName.TabIndex = 13;
            // 
            // txtPrdCode
            // 
            txtPrdCode.Location = new Point(218, 100);
            txtPrdCode.Multiline = true;
            txtPrdCode.Name = "txtPrdCode";
            txtPrdCode.Size = new Size(281, 34);
            txtPrdCode.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(41, 257);
            label4.Name = "label4";
            label4.Size = new Size(65, 31);
            label4.TabIndex = 11;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 183);
            label3.Name = "label3";
            label3.Size = new Size(76, 31);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 103);
            label2.Name = "label2";
            label2.Size = new Size(68, 31);
            label2.TabIndex = 9;
            label2.Text = "Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(649, 39);
            label1.Name = "label1";
            label1.Size = new Size(212, 46);
            label1.TabIndex = 8;
            label1.Text = "Add Product";
            // 
            // txtPrdPrice
            // 
            txtPrdPrice.Location = new Point(218, 263);
            txtPrdPrice.Multiline = true;
            txtPrdPrice.Name = "txtPrdPrice";
            txtPrdPrice.Size = new Size(281, 34);
            txtPrdPrice.TabIndex = 16;
            // 
            // txtPrdNotes
            // 
            txtPrdNotes.Location = new Point(218, 348);
            txtPrdNotes.Multiline = true;
            txtPrdNotes.Name = "txtPrdNotes";
            txtPrdNotes.Size = new Size(281, 125);
            txtPrdNotes.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 342);
            label5.Name = "label5";
            label5.Size = new Size(76, 31);
            label5.TabIndex = 17;
            label5.Text = "Notes";
            // 
            // txtPrdQuantity
            // 
            txtPrdQuantity.Location = new Point(959, 103);
            txtPrdQuantity.Multiline = true;
            txtPrdQuantity.Name = "txtPrdQuantity";
            txtPrdQuantity.Size = new Size(281, 34);
            txtPrdQuantity.TabIndex = 20;
            txtPrdQuantity.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(782, 106);
            label6.Name = "label6";
            label6.Size = new Size(103, 31);
            label6.TabIndex = 19;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(779, 320);
            label7.Name = "label7";
            label7.Size = new Size(167, 31);
            label7.TabIndex = 21;
            label7.Text = "Product Image";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.White;
            btnAddProduct.Location = new Point(1039, 503);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(131, 46);
            btnAddProduct.TabIndex = 22;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(115, 97);
            label8.Name = "label8";
            label8.Size = new Size(24, 31);
            label8.TabIndex = 23;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(112, 245);
            label9.Name = "label9";
            label9.Size = new Size(24, 31);
            label9.TabIndex = 24;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(115, 172);
            label10.Name = "label10";
            label10.Size = new Size(24, 31);
            label10.TabIndex = 25;
            label10.Text = "*";
            // 
            // ProductFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_login_background_outlook_login12;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1292, 590);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnAddProduct);
            Controls.Add(label7);
            Controls.Add(txtPrdQuantity);
            Controls.Add(label6);
            Controls.Add(txtPrdNotes);
            Controls.Add(label5);
            Controls.Add(txtPrdPrice);
            Controls.Add(btnAddPrd);
            Controls.Add(prdImage);
            Controls.Add(txtPrdName);
            Controls.Add(txtPrdCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductFrm";
            Text = "ProductFrm";
            ((System.ComponentModel.ISupportInitialize)prdImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPrd;
        private PictureBox prdImage;
        private TextBox txtPrdName;
        private TextBox txtPrdCode;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPrdPrice;
        private TextBox txtPrdNotes;
        private Label label5;
        private TextBox txtPrdQuantity;
        private Label label6;
        private Label label7;
        private Button btnAddProduct;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}