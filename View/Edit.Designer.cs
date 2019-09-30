namespace View
{
    partial class Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditUnitPrice = new System.Windows.Forms.TextBox();
            this.txtEditProduct = new System.Windows.Forms.TextBox();
            this.txtEditQuantity = new System.Windows.Forms.TextBox();
            this.txtEditCode = new System.Windows.Forms.TextBox();
            this.btnEditBrowse = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEditID = new System.Windows.Forms.Label();
            this.lblerrName = new System.Windows.Forms.Label();
            this.lblerrUnitPrice = new System.Windows.Forms.Label();
            this.lblerrQuantiy = new System.Windows.Forms.Label();
            this.lblerrCode = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pctrBx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(914, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(914, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "UnitPrice : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ProductName : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Image : ";
            // 
            // txtEditUnitPrice
            // 
            this.txtEditUnitPrice.Location = new System.Drawing.Point(1162, 202);
            this.txtEditUnitPrice.Multiline = true;
            this.txtEditUnitPrice.Name = "txtEditUnitPrice";
            this.txtEditUnitPrice.Size = new System.Drawing.Size(142, 31);
            this.txtEditUnitPrice.TabIndex = 5;
            this.txtEditUnitPrice.TextChanged += new System.EventHandler(this.TxtEditUnitPrice_TextChanged);
            // 
            // txtEditProduct
            // 
            this.txtEditProduct.Location = new System.Drawing.Point(366, 202);
            this.txtEditProduct.Multiline = true;
            this.txtEditProduct.Name = "txtEditProduct";
            this.txtEditProduct.Size = new System.Drawing.Size(139, 31);
            this.txtEditProduct.TabIndex = 6;
            this.txtEditProduct.TextChanged += new System.EventHandler(this.TxtEditProduct_TextChanged);
            // 
            // txtEditQuantity
            // 
            this.txtEditQuantity.Location = new System.Drawing.Point(366, 372);
            this.txtEditQuantity.Multiline = true;
            this.txtEditQuantity.Name = "txtEditQuantity";
            this.txtEditQuantity.Size = new System.Drawing.Size(139, 31);
            this.txtEditQuantity.TabIndex = 7;
            this.txtEditQuantity.TextChanged += new System.EventHandler(this.TxtEditQuantity_TextChanged);
            // 
            // txtEditCode
            // 
            this.txtEditCode.Location = new System.Drawing.Point(1174, 372);
            this.txtEditCode.Multiline = true;
            this.txtEditCode.Name = "txtEditCode";
            this.txtEditCode.Size = new System.Drawing.Size(130, 31);
            this.txtEditCode.TabIndex = 8;
            this.txtEditCode.TextChanged += new System.EventHandler(this.TxtEditCode_TextChanged);
            // 
            // btnEditBrowse
            // 
            this.btnEditBrowse.Location = new System.Drawing.Point(366, 531);
            this.btnEditBrowse.Name = "btnEditBrowse";
            this.btnEditBrowse.Size = new System.Drawing.Size(139, 49);
            this.btnEditBrowse.TabIndex = 9;
            this.btnEditBrowse.Text = "Browse";
            this.btnEditBrowse.UseVisualStyleBackColor = true;
            this.btnEditBrowse.Click += new System.EventHandler(this.BtnEditBrowse_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(145, 736);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(203, 87);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(140, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(59, 29);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID : ";
            // 
            // lblEditID
            // 
            this.lblEditID.AutoSize = true;
            this.lblEditID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditID.Location = new System.Drawing.Point(361, 28);
            this.lblEditID.Name = "lblEditID";
            this.lblEditID.Size = new System.Drawing.Size(0, 37);
            this.lblEditID.TabIndex = 13;
            // 
            // lblerrName
            // 
            this.lblerrName.AutoSize = true;
            this.lblerrName.Location = new System.Drawing.Point(542, 205);
            this.lblerrName.Name = "lblerrName";
            this.lblerrName.Size = new System.Drawing.Size(0, 25);
            this.lblerrName.TabIndex = 14;
            // 
            // lblerrUnitPrice
            // 
            this.lblerrUnitPrice.AutoSize = true;
            this.lblerrUnitPrice.Location = new System.Drawing.Point(1342, 205);
            this.lblerrUnitPrice.Name = "lblerrUnitPrice";
            this.lblerrUnitPrice.Size = new System.Drawing.Size(0, 25);
            this.lblerrUnitPrice.TabIndex = 15;
            // 
            // lblerrQuantiy
            // 
            this.lblerrQuantiy.AutoSize = true;
            this.lblerrQuantiy.Location = new System.Drawing.Point(542, 375);
            this.lblerrQuantiy.Name = "lblerrQuantiy";
            this.lblerrQuantiy.Size = new System.Drawing.Size(0, 25);
            this.lblerrQuantiy.TabIndex = 16;
            // 
            // lblerrCode
            // 
            this.lblerrCode.AutoSize = true;
            this.lblerrCode.Location = new System.Drawing.Point(1342, 375);
            this.lblerrCode.Name = "lblerrCode";
            this.lblerrCode.Size = new System.Drawing.Size(0, 25);
            this.lblerrCode.TabIndex = 17;
            // 
            // pctrBx
            // 
            this.pctrBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pctrBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctrBx.Location = new System.Drawing.Point(700, 473);
            this.pctrBx.Name = "pctrBx";
            this.pctrBx.Size = new System.Drawing.Size(334, 216);
            this.pctrBx.TabIndex = 18;
            this.pctrBx.TabStop = false;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1646, 956);
            this.Controls.Add(this.pctrBx);
            this.Controls.Add(this.lblerrCode);
            this.Controls.Add(this.lblerrQuantiy);
            this.Controls.Add(this.lblerrUnitPrice);
            this.Controls.Add(this.lblerrName);
            this.Controls.Add(this.lblEditID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnEditBrowse);
            this.Controls.Add(this.txtEditCode);
            this.Controls.Add(this.txtEditQuantity);
            this.Controls.Add(this.txtEditProduct);
            this.Controls.Add(this.txtEditUnitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edit";
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditBrowse;
        private System.Windows.Forms.Button btnSubmit;
        public System.Windows.Forms.TextBox txtEditUnitPrice;
        public System.Windows.Forms.TextBox txtEditProduct;
        public System.Windows.Forms.TextBox txtEditQuantity;
        public System.Windows.Forms.TextBox txtEditCode;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblEditID;
        private System.Windows.Forms.Label lblerrName;
        private System.Windows.Forms.Label lblerrUnitPrice;
        private System.Windows.Forms.Label lblerrQuantiy;
        private System.Windows.Forms.Label lblerrCode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox pctrBx;
    }
}