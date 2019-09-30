namespace View
{
    partial class Register
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtTell = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtUserReg = new System.Windows.Forms.TextBox();
            this.txtPassReg = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblerrName = new System.Windows.Forms.Label();
            this.lblerrSurname = new System.Windows.Forms.Label();
            this.lblerrTell = new System.Windows.Forms.Label();
            this.lblerrMobileNumber = new System.Windows.Forms.Label();
            this.lblerrAddress = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "SurName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tell : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "MobileNumber : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1208, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1208, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "UserName : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1208, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password : ";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(274, 120);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(264, 51);
            this.txtSurname.TabIndex = 8;
            this.txtSurname.TextChanged += new System.EventHandler(this.TxtSurname_TextChanged);
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(274, 236);
            this.txtTell.Multiline = true;
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(264, 47);
            this.txtTell.TabIndex = 9;
            this.txtTell.TextChanged += new System.EventHandler(this.TxtTell_TextChanged);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(274, 344);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(264, 53);
            this.txtMobile.TabIndex = 10;
            this.txtMobile.TextChanged += new System.EventHandler(this.TxtMobile_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1640, 42);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(264, 53);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.TextChanged += new System.EventHandler(this.TxtAddress_TextChanged);
            // 
            // txtUserReg
            // 
            this.txtUserReg.Location = new System.Drawing.Point(1640, 142);
            this.txtUserReg.Multiline = true;
            this.txtUserReg.Name = "txtUserReg";
            this.txtUserReg.Size = new System.Drawing.Size(264, 57);
            this.txtUserReg.TabIndex = 12;
            // 
            // txtPassReg
            // 
            this.txtPassReg.Location = new System.Drawing.Point(1640, 256);
            this.txtPassReg.Multiline = true;
            this.txtPassReg.Name = "txtPassReg";
            this.txtPassReg.Size = new System.Drawing.Size(264, 55);
            this.txtPassReg.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(274, 42);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 45);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(858, 636);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(373, 67);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit ";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblerrName
            // 
            this.lblerrName.AutoSize = true;
            this.lblerrName.Location = new System.Drawing.Point(557, 50);
            this.lblerrName.Name = "lblerrName";
            this.lblerrName.Size = new System.Drawing.Size(0, 25);
            this.lblerrName.TabIndex = 16;
            // 
            // lblerrSurname
            // 
            this.lblerrSurname.AutoSize = true;
            this.lblerrSurname.Location = new System.Drawing.Point(557, 138);
            this.lblerrSurname.Name = "lblerrSurname";
            this.lblerrSurname.Size = new System.Drawing.Size(0, 25);
            this.lblerrSurname.TabIndex = 17;
            // 
            // lblerrTell
            // 
            this.lblerrTell.AutoSize = true;
            this.lblerrTell.Location = new System.Drawing.Point(557, 244);
            this.lblerrTell.Name = "lblerrTell";
            this.lblerrTell.Size = new System.Drawing.Size(0, 25);
            this.lblerrTell.TabIndex = 18;
            // 
            // lblerrMobileNumber
            // 
            this.lblerrMobileNumber.AutoSize = true;
            this.lblerrMobileNumber.Location = new System.Drawing.Point(557, 362);
            this.lblerrMobileNumber.Name = "lblerrMobileNumber";
            this.lblerrMobileNumber.Size = new System.Drawing.Size(0, 25);
            this.lblerrMobileNumber.TabIndex = 19;
            // 
            // lblerrAddress
            // 
            this.lblerrAddress.AutoSize = true;
            this.lblerrAddress.Location = new System.Drawing.Point(1920, 62);
            this.lblerrAddress.Name = "lblerrAddress";
            this.lblerrAddress.Size = new System.Drawing.Size(0, 25);
            this.lblerrAddress.TabIndex = 20;
            // 
            // btnShowPass
            // 
            this.btnShowPass.Location = new System.Drawing.Point(1947, 260);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(165, 51);
            this.btnShowPass.TabIndex = 21;
            this.btnShowPass.Text = "show";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.BtnShowPass_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2118, 1040);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.lblerrAddress);
            this.Controls.Add(this.lblerrMobileNumber);
            this.Controls.Add(this.lblerrTell);
            this.Controls.Add(this.lblerrSurname);
            this.Controls.Add(this.lblerrName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassReg);
            this.Controls.Add(this.txtUserReg);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtTell;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtUserReg;
        private System.Windows.Forms.TextBox txtPassReg;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblerrName;
        private System.Windows.Forms.Label lblerrSurname;
        private System.Windows.Forms.Label lblerrTell;
        private System.Windows.Forms.Label lblerrMobileNumber;
        private System.Windows.Forms.Label lblerrAddress;
        private System.Windows.Forms.Button btnShowPass;
    }
}