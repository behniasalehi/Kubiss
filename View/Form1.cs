using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Form1 : Form
    {
        #region [- ctor -]
        public Form1()
        {
            InitializeComponent();
            Ref_PersonViewModel = new ViewModel.PersonViewModel();
            txtPassword.PasswordChar = '*';
            
        }
        #endregion

        #region [- props -]
        public ViewModel.PersonViewModel Ref_PersonViewModel { get; set; }
        public Register Ref_Register{ get; set; }
        #endregion

        #region [- BtnSignin_Click -]
        private void BtnSignin_Click(object sender, EventArgs e)
        {
            if (Ref_PersonViewModel.SignIn(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("Welcome");
                this.Close();
            }
            else
            {
                MessageBox.Show("you must register");
            }
        }
        #endregion

        #region [- BtnSignUp_Click -]
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            Ref_Register = new Register();
            Ref_Register.MdiParent = this.MdiParent;
            this.Close();
            Ref_Register.Show();
        }
        #endregion

        #region [- BtnShow_Click -]
        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*' && btnShow.Text == "show")
            {
                txtPassword.PasswordChar = '\0';
                btnShow.Text = "hide";
            }
            else if (txtPassword.PasswordChar == '\0' && btnShow.Text == "hide")
            {
                txtPassword.PasswordChar = '*';
                btnShow.Text = "show";
            }
        } 
        #endregion
    }
}
