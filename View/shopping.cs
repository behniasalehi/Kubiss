using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace View
{
    public partial class shopping : Form
    {
        #region [- ctor -]
        public shopping()
        {
            InitializeComponent();
            Ref_ProductViewModel = new ViewModel.ProductViewModel();
            Ref_Validation = new Validation();
        }

        #endregion

        #region [- ClearAll() -]
        public void ClearAll()
        {
            pictureBox1.Image = null;
            txtCode.Clear();
            txtProduct.Clear();
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            lblerrProduct.Text = string.Empty;
            lblerrName.Text = string.Empty; 
            lblerrUnitPrice.Text = string.Empty;
            lblerrQuantity.Text= string.Empty;
            lblerrCode.Text = string.Empty;
        } 
        #endregion

        #region [- props -]
        public ViewModel.ProductViewModel Ref_ProductViewModel { get; set; }
        public Validation Ref_Validation { get; set; }
        public Helper ReF_Helper { get; set; }
        public Edit Ref_Edit { get; set; }
        #endregion

        #region [- TxtProduct_TextChanged -]
        private void TxtProduct_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.TextValidation(txtProduct.Text) == false)
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

        #region [- TxtUnitPrice_TextChanged -]
        private void TxtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.NumberValidation(txtUnitPrice.Text) == false)
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

        #region [- TxtQuantity_TextChanged -]
        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.NumberValidation(txtQuantity.Text) == false)
            {
                lblerrQuantity.Text = "please enter numbers";
                lblerrQuantity.ForeColor = Color.Red;
            }
            else
            {
                lblerrQuantity.Text = "correct";
                lblerrQuantity.ForeColor = Color.Green;
            }
        }
        #endregion

        #region [-  TxtCode_TextChanged -]
        private void TxtCode_TextChanged(object sender, EventArgs e)
        {
            if (Ref_Validation.NumberValidation(txtCode.Text) == false)
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

        #region [- BtnBrowse_Click -]
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        #endregion

        #region [- BtnSave_Click -]
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Ref_Validation.TextValidation(txtProduct.Text) == true &&
                Ref_Validation.NumberValidation(txtUnitPrice.Text) == true
                && Ref_Validation.NumberValidation(txtQuantity.Text) == true
                && Ref_Validation.NumberValidation(txtCode.Text) == true
                && pictureBox1.Image != null )
            {
                ReF_Helper = new Helper();
                Ref_ProductViewModel.Save(txtProduct.Text, Convert.ToInt32(txtUnitPrice.Text)
                    , Convert.ToInt32(txtQuantity.Text), ReF_Helper.Price(txtUnitPrice.Text,txtQuantity.Text), Convert.ToInt32(txtCode.Text),ReF_Helper.ImageToByteArray(pictureBox1.Image));
                ClearAll();
                MessageBox.Show("save");
                dgvProduct.DataSource = Ref_ProductViewModel.FillGrid();
            }
            else
            {
                MessageBox.Show("please check fields");
            }
        }
        #endregion

        #region [-  Shopping_Load -]
        private void Shopping_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = Ref_ProductViewModel.FillGrid();

        }

        #endregion

        #region [- BtnEdit_Click -]
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Ref_Edit = new Edit();
            ReF_Helper = new Helper();
            Ref_Edit.lblEditID.Text = Convert.ToString(dgvProduct[0, dgvProduct.CurrentRow.Index].Value);
            Ref_Edit.txtEditProduct.Text = Convert.ToString(dgvProduct[1, dgvProduct.CurrentRow.Index].Value);
            Ref_Edit.txtEditUnitPrice.Text = Convert.ToString(dgvProduct[2, dgvProduct.CurrentRow.Index].Value);
            Ref_Edit.txtEditQuantity.Text = Convert.ToString(dgvProduct[3, dgvProduct.CurrentRow.Index].Value);
            Ref_Edit.txtEditCode.Text = Convert.ToString(dgvProduct[5, dgvProduct.CurrentRow.Index].Value);
            Ref_Edit.pctrBx.Image = ReF_Helper.ConverImage(dgvProduct[6, dgvProduct.CurrentRow.Index].Value);
            Ref_Edit.Show();
        }
        #endregion

        #region [- BtnDelete_Click -]
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProduct[0, dgvProduct.CurrentRow.Index].Value);
            DialogResult res = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Ref_ProductViewModel.Delete(id);
                MessageBox.Show("deleted");
                dgvProduct.DataSource = Ref_ProductViewModel.FillGrid();
            }
        }

        #endregion

        #region [-  BtnRefresh_Click -]
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = Ref_ProductViewModel.FillGrid();
        } 
        #endregion
    }
}
