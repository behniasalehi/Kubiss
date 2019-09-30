namespace View
{
    partial class shopping
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblerrProduct = new System.Windows.Forms.Label();
            this.lblerrUnitPrice = new System.Windows.Forms.Label();
            this.lblerrQuantity = new System.Windows.Forms.Label();
            this.lblerrCode = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblerrName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(339, 287);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(109, 55);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(97, 52);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(193, 29);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "ProductName : ";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(997, 58);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(141, 29);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "UnitPrice : ";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(97, 140);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(129, 29);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity : ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(1007, 140);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(97, 29);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code : ";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(97, 299);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(106, 29);
            this.lblImage.TabIndex = 5;
            this.lblImage.Text = "Image : ";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(348, 52);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(100, 31);
            this.txtProduct.TabIndex = 7;
            this.txtProduct.TextChanged += new System.EventHandler(this.TxtProduct_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(1230, 58);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 31);
            this.txtUnitPrice.TabIndex = 8;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.TxtUnitPrice_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(348, 141);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 31);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.TextChanged += new System.EventHandler(this.TxtQuantity_TextChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(1230, 144);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 31);
            this.txtCode.TabIndex = 10;
            this.txtCode.TextChanged += new System.EventHandler(this.TxtCode_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(387, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 59);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblerrProduct
            // 
            this.lblerrProduct.AutoSize = true;
            this.lblerrProduct.Location = new System.Drawing.Point(1394, -47);
            this.lblerrProduct.Name = "lblerrProduct";
            this.lblerrProduct.Size = new System.Drawing.Size(0, 25);
            this.lblerrProduct.TabIndex = 12;
            // 
            // lblerrUnitPrice
            // 
            this.lblerrUnitPrice.AutoSize = true;
            this.lblerrUnitPrice.Location = new System.Drawing.Point(1394, 58);
            this.lblerrUnitPrice.Name = "lblerrUnitPrice";
            this.lblerrUnitPrice.Size = new System.Drawing.Size(0, 25);
            this.lblerrUnitPrice.TabIndex = 13;
            // 
            // lblerrQuantity
            // 
            this.lblerrQuantity.AutoSize = true;
            this.lblerrQuantity.Location = new System.Drawing.Point(504, 149);
            this.lblerrQuantity.Name = "lblerrQuantity";
            this.lblerrQuantity.Size = new System.Drawing.Size(0, 25);
            this.lblerrQuantity.TabIndex = 14;
            // 
            // lblerrCode
            // 
            this.lblerrCode.AutoSize = true;
            this.lblerrCode.Location = new System.Drawing.Point(1394, 144);
            this.lblerrCode.Name = "lblerrCode";
            this.lblerrCode.Size = new System.Drawing.Size(0, 25);
            this.lblerrCode.TabIndex = 15;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(102, 596);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 82;
            this.dgvProduct.RowTemplate.Height = 33;
            this.dgvProduct.Size = new System.Drawing.Size(2052, 404);
            this.dgvProduct.TabIndex = 16;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(665, 472);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(175, 59);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblerrName
            // 
            this.lblerrName.AutoSize = true;
            this.lblerrName.Location = new System.Drawing.Point(504, 58);
            this.lblerrName.Name = "lblerrName";
            this.lblerrName.Size = new System.Drawing.Size(0, 25);
            this.lblerrName.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(929, 472);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 59);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(553, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 210);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1202, 472);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(175, 59);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // shopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1447);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblerrName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.lblerrCode);
            this.Controls.Add(this.lblerrQuantity);
            this.Controls.Add(this.lblerrUnitPrice);
            this.Controls.Add(this.lblerrProduct);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnBrowse);
            this.MinimumSize = new System.Drawing.Size(2558, 1518);
            this.Name = "shopping";
            this.Text = "shopping";
            this.Load += new System.EventHandler(this.Shopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblerrProduct;
        private System.Windows.Forms.Label lblerrUnitPrice;
        private System.Windows.Forms.Label lblerrQuantity;
        private System.Windows.Forms.Label lblerrCode;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblerrName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvProduct;
        public System.Windows.Forms.Button btnRefresh;
    }
}