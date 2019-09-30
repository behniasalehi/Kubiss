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
    public partial class Edit : Form
    {
        #region [- ctor -]
        public Edit()
        {
            InitializeComponent();
            Ref_ProductViewModel = new ViewModel.ProductViewModel();
            Ref_Validation = new Validation();
        }
        #endregion

        #region [- props -]
        public ViewModel.ProductViewModel Ref_ProductViewModel{ get; set; }
        public Validation Ref_Validation { get; set; }
        public Helper ReF_Helper { get; set; }
        public shopping ReF_Shopping{ get; set; }
        #endregion

        #region [- TxtEditProduct_TextChanged -]
        private void TxtEditProduct_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.TextValidation(txtEditProduct.Text) == false)
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

        #region [- TxtEditUnitPrice_TextChanged -]
        private void TxtEditUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.NumberValidation(txtEditUnitPrice.Text) == false)
            {
                lblerrUnitPrice.Text = "please enter numbers";
                lblerrUnitPrice.ForeColor = Color.Red;
            }
            else
            {
                lblerrUnitPrice.Text = "correct";
                lblerrUnitPrice.ForeColor = Color.Green;
            }
        }
        #endregion

        #region [- TxtEditQuantity_TextChanged -]
        private void TxtEditQuantity_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.NumberValidation(txtEditQuantity.Text) == false)
            {
                lblerrQuantiy.Text = "please enter numbers";
                lblerrQuantiy.ForeColor = Color.Red;
            }
            else
            {
                lblerrQuantiy.Text = "correct";
                lblerrQuantiy.ForeColor = Color.Green;
            }
        }
        #endregion

        #region [- TxtEditCode_TextChanged -]
        private void TxtEditCode_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.NumberValidation(txtEditCode.Text) == false)
            {
                lblerrCode.Text = "please enter numbers";
                lblerrCode.ForeColor = Color.Red;
            }
            else
            {
                lblerrCode.Text = "correct";
                lblerrCode.ForeColor = Color.Green;
            }
        }
        #endregion

        #region [- BtnEditBrowse_Click -]
        private void BtnEditBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pctrBx.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        #endregion

        #region [- BtnSubmit_Click -]
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
            if (Ref_Validation.TextValidation(txtEditProduct.Text) == true &&
                Ref_Validation.NumberValidation(txtEditUnitPrice.Text) == true
                && Ref_Validation.NumberValidation(txtEditQuantity.Text) == true
                && Ref_Validation.NumberValidation(txtEditCode.Text) == true
                )
               
            {
                ReF_Helper = new Helper();
                ReF_Shopping = new shopping();
                Ref_ProductViewModel.Edit(Convert.ToInt32(lblEditID.Text)
                    , txtEditProduct.Text, Convert.ToInt32(txtEditUnitPrice.Text),
                    Convert.ToInt32(txtEditQuantity.Text),
                    ReF_Helper.Price(txtEditUnitPrice.Text, txtEditQuantity.Text),
                    Convert.ToInt32(txtEditCode.Text), ReF_Helper.ImageToByteArray(pctrBx.Image));
                MessageBox.Show("succeeded");
                this.Close();
                MessageBox.Show("please enter Refresh Button !!!");

            }
            else
            {
                MessageBox.Show("please check fields");
            }
        }

        #endregion

        
    }
}
