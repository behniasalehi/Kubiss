using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Register : Form
    {
        #region [- ctor -] 
        public Register()
        {
            InitializeComponent();
            Ref_PersonViewModel = new ViewModel.PersonViewModel();
            Ref_Validation = new Validation();
            txtPassReg.PasswordChar = '*';
        }
        #endregion

        #region [- props -]
        public ViewModel.PersonViewModel Ref_PersonViewModel { get; set; }
        public Validation Ref_Validation { get; set; }
        #endregion

        #region [- BtnSubmit_Click -]
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (Ref_Validation.TextValidation(txtName.Text)==true && Ref_Validation.TextValidation(txtSurname.Text) == true
                && Ref_Validation.TellValidation(txtTell.Text) == true && Ref_Validation.MobileValidation(txtMobile.Text)&&
                Ref_Validation.AddressValidation(txtAddress.Text)==true && txtUserReg.Text != string.Empty && txtPassReg.Text != string.Empty)
            {
                Ref_PersonViewModel.Save(txtName.Text, txtSurname.Text, txtTell.Text, txtMobile.Text, txtAddress.Text, txtUserReg.Text, txtPassReg.Text);
                MessageBox.Show("succeeded");
                this.Close();
            }
            else
            {
                MessageBox.Show("unsucceeded !  please check fields");
            }
        }
        #endregion

        #region [- TxtName_TextChanged -]
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.TextValidation(txtName.Text) == false)
            {
                lblerrName.Text = "please enter character and numbers";
                lblerrName.ForeColor = Color.Red;
            }
            else
            {
                lblerrName.Text = "correct";
                lblerrName.ForeColor = Color.Green;
            }
        }
        #endregion

        #region [- TxtSurname_TextChanged -]
        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.TextValidation(txtSurname.Text) == false)
            {
                lblerrSurname.Text = "please enter character and numbers";
                lblerrSurname.ForeColor = Color.Red;
            }
            else
            {
                lblerrSurname.Text = "correct";
                lblerrSurname.ForeColor = Color.Green;
            }
        }
        #endregion

        #region [- TxtTell_TextChanged -]
        private void TxtTell_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.TellValidation(txtTell.Text) == false)
            {
                lblerrTell.Text = "please enter 8 numbers";
                lblerrTell.ForeColor = Color.Red;
            }
            else
            {
                lblerrTell.Text = "correct";
                lblerrTell.ForeColor = Color.Green;
            }
        }
        #endregion

        #region [- TxtMobile_TextChanged -]
        private void TxtMobile_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.MobileValidation(txtMobile.Text) == false)
            {
                lblerrMobileNumber.Text = "please enter 11 numbers";
                lblerrMobileNumber.ForeColor = Color.Red;
            }
            else
            {
                lblerrMobileNumber.Text = "correct";
                lblerrMobileNumber.ForeColor = Color.Green;
            }
        }

        #endregion

        #region [- TxtAddress_TextChanged -]
        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.AddressValidation(txtAddress.Text) == false)
            {
                lblerrAddress.Text = "please enter character and numbers";
                lblerrAddress.ForeColor = Color.Red;
            }
            else
            {
                lblerrAddress.Text = "correct";
                lblerrAddress.ForeColor = Color.Green;
            }
        }


        #endregion

        #region [- BtnShowPass_Click -]
        private void BtnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassReg.PasswordChar == '*' && btnShowPass.Text == "show")
            {
                txtPassReg.PasswordChar = '\0';
                btnShowPass.Text = "hide";
            }
            else if (txtPassReg.PasswordChar == '\0' && btnShowPass.Text == "hide")
            {
                txtPassReg.PasswordChar = '*';
                btnShowPass.Text = "show";
            }
        } 
        #endregion
    }
}
