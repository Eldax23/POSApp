namespace POSApp.Screens.Customers
{
    partial class CustomerFrm
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
            btnRemoveCust = new Button();
            btnEditCust = new Button();
            txtCustPhone = new TextBox();
            lbl12 = new Label();
            label7 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnAddCustomer = new Button();
            txtCustNotes = new TextBox();
            label5 = new Label();
            txtCustAddress = new TextBox();
            btnAddPrd = new Button();
            custImg = new PictureBox();
            custNameTxt = new TextBox();
            lbl2 = new Label();
            label3 = new Label();
            label12 = new Label();
            btnReset = new Button();
            btnSearchProduct = new Button();
            txtName = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label6 = new Label();
            custGridView = new DataGridView();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            label13 = new Label();
            txtCustEmail = new TextBox();
            label8 = new Label();
            txtCompany = new TextBox();
            ((System.ComponentModel.ISupportInitialize)custImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)custGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRemoveCust
            // 
            btnRemoveCust.BackColor = Color.White;
            btnRemoveCust.Location = new Point(199, 423);
            btnRemoveCust.Name = "btnRemoveCust";
            btnRemoveCust.Size = new Size(131, 46);
            btnRemoveCust.TabIndex = 72;
            btnRemoveCust.Text = "Remove";
            btnRemoveCust.UseVisualStyleBackColor = false;
            // 
            // btnEditCust
            // 
            btnEditCust.BackColor = Color.White;
            btnEditCust.Location = new Point(62, 423);
            btnEditCust.Name = "btnEditCust";
            btnEditCust.Size = new Size(131, 46);
            btnEditCust.TabIndex = 71;
            btnEditCust.Text = "Edit";
            btnEditCust.UseVisualStyleBackColor = false;
            // 
            // txtCustPhone
            // 
            txtCustPhone.Location = new Point(676, 127);
            txtCustPhone.Multiline = true;
            txtCustPhone.Name = "txtCustPhone";
            txtCustPhone.Size = new Size(281, 34);
            txtCustPhone.TabIndex = 66;
            txtCustPhone.Text = "0";
            // 
            // lbl12
            // 
            lbl12.AutoSize = true;
            lbl12.BackColor = Color.Transparent;
            lbl12.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            lbl12.ForeColor = Color.White;
            lbl12.Location = new Point(503, 121);
            lbl12.Name = "lbl12";
            lbl12.Size = new Size(79, 31);
            lbl12.TabIndex = 65;
            lbl12.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(485, 201);
            label7.Name = "label7";
            label7.Size = new Size(185, 31);
            label7.TabIndex = 39;
            label7.Text = "Customer Image";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(95, 118);
            label10.Name = "label10";
            label10.Size = new Size(24, 31);
            label10.TabIndex = 70;
            label10.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(735, 311);
            label9.Name = "label9";
            label9.Size = new Size(24, 31);
            label9.TabIndex = 69;
            label9.Text = "*";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.White;
            btnAddCustomer.Location = new Point(340, 423);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(131, 46);
            btnAddCustomer.TabIndex = 67;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // txtCustNotes
            // 
            txtCustNotes.Location = new Point(190, 282);
            txtCustNotes.Multiline = true;
            txtCustNotes.Name = "txtCustNotes";
            txtCustNotes.Size = new Size(281, 110);
            txtCustNotes.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 277);
            label5.Name = "label5";
            label5.Size = new Size(76, 31);
            label5.TabIndex = 63;
            label5.Text = "Notes";
            // 
            // txtCustAddress
            // 
            txtCustAddress.Location = new Point(190, 203);
            txtCustAddress.Multiline = true;
            txtCustAddress.Name = "txtCustAddress";
            txtCustAddress.Size = new Size(281, 34);
            txtCustAddress.TabIndex = 62;
            // 
            // btnAddPrd
            // 
            btnAddPrd.BackColor = Color.Transparent;
            btnAddPrd.BackgroundImage = Properties.Resources.add;
            btnAddPrd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddPrd.FlatAppearance.BorderSize = 0;
            btnAddPrd.FlatStyle = FlatStyle.Flat;
            btnAddPrd.Location = new Point(1186, 671);
            btnAddPrd.Name = "btnAddPrd";
            btnAddPrd.Size = new Size(62, 49);
            btnAddPrd.TabIndex = 61;
            btnAddPrd.UseVisualStyleBackColor = false;
            // 
            // custImg
            // 
            custImg.BackColor = SystemColors.Control;
            custImg.BackgroundImageLayout = ImageLayout.Stretch;
            custImg.Location = new Point(676, 186);
            custImg.Name = "custImg";
            custImg.Size = new Size(281, 100);
            custImg.SizeMode = PictureBoxSizeMode.StretchImage;
            custImg.TabIndex = 60;
            custImg.TabStop = false;
            custImg.Click += custImg_Click;
            // 
            // custNameTxt
            // 
            custNameTxt.Location = new Point(190, 124);
            custNameTxt.Multiline = true;
            custNameTxt.Name = "custNameTxt";
            custNameTxt.Size = new Size(281, 34);
            custNameTxt.TabIndex = 59;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            lbl2.ForeColor = Color.White;
            lbl2.Location = new Point(13, 192);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(98, 31);
            lbl2.TabIndex = 57;
            lbl2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 118);
            label3.Name = "label3";
            label3.Size = new Size(76, 31);
            label3.TabIndex = 56;
            label3.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(467, 29);
            label12.Name = "label12";
            label12.Size = new Size(184, 46);
            label12.TabIndex = 54;
            label12.Text = "Customers";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.Location = new Point(663, 106);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 33);
            btnReset.TabIndex = 53;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.White;
            btnSearchProduct.Location = new Point(663, 67);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(96, 33);
            btnSearchProduct.TabIndex = 52;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(456, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 27);
            txtName.TabIndex = 51;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(94, 73);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(186, 27);
            txtPhone.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(358, 67);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 49;
            label1.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(9, 73);
            label6.Name = "label6";
            label6.Size = new Size(79, 31);
            label6.TabIndex = 48;
            label6.Text = "Phone";
            // 
            // custGridView
            // 
            custGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custGridView.Location = new Point(20, 130);
            custGridView.MultiSelect = false;
            custGridView.Name = "custGridView";
            custGridView.ReadOnly = true;
            custGridView.RowHeadersWidth = 51;
            custGridView.Size = new Size(637, 500);
            custGridView.TabIndex = 47;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtCustPhone);
            groupBox1.Controls.Add(btnAddCustomer);
            groupBox1.Controls.Add(btnRemoveCust);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(btnEditCust);
            groupBox1.Controls.Add(custImg);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtCustEmail);
            groupBox1.Controls.Add(lbl12);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCompany);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtCustNotes);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lbl2);
            groupBox1.Controls.Add(custNameTxt);
            groupBox1.Controls.Add(txtCustAddress);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(777, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1110, 509);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(774, 455);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 24);
            checkBox1.TabIndex = 76;
            checkBox1.Text = "isActive";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(521, 399);
            label13.Name = "label13";
            label13.Size = new Size(70, 31);
            label13.TabIndex = 75;
            label13.Text = "Email";
            // 
            // txtCustEmail
            // 
            txtCustEmail.Location = new Point(676, 405);
            txtCustEmail.Multiline = true;
            txtCustEmail.Name = "txtCustEmail";
            txtCustEmail.Size = new Size(281, 34);
            txtCustEmail.TabIndex = 74;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(503, 320);
            label8.Name = "label8";
            label8.Size = new Size(119, 31);
            label8.TabIndex = 72;
            label8.Text = "Company ";
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(676, 326);
            txtCompany.Multiline = true;
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(281, 34);
            txtCompany.TabIndex = 71;
            // 
            // CustomerFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_login_background_outlook_login1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 732);
            Controls.Add(label9);
            Controls.Add(btnReset);
            Controls.Add(btnAddPrd);
            Controls.Add(btnSearchProduct);
            Controls.Add(txtName);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(custGridView);
            Controls.Add(groupBox1);
            Name = "CustomerFrm";
            Text = "CustomerFrm";
            ((System.ComponentModel.ISupportInitialize)custImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)custGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemoveCust;
        private Button btnEditCust;
        private TextBox txtCustPhone;
        private Label lbl12;
        private Label label7;
        private Label label10;
        private Label label9;
        private Button btnAddCustomer;
        private TextBox txtCustNotes;
        private Label label5;
        private TextBox txtCustAddress;
        private Button btnAddPrd;
        private PictureBox custImg;
        private TextBox custNameTxt;
        private Label lbl2;
        private Label label3;
        private Label label12;
        private Button btnReset;
        private Button btnSearchProduct;
        private TextBox txtName;
        private TextBox txtPhone;
        private Label label1;
        private Label label6;
        private DataGridView custGridView;
        private GroupBox groupBox1;
        private Label label13;
        private TextBox txtCustEmail;
        private Label label8;
        private TextBox txtCompany;
        private CheckBox checkBox1;
    }
}