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
    public partial class MainForm : Form
    {
        #region [- ctor -]
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion
        #region [- props -]
        public Form1 Ref_Form1 { get; set; }
        public shopping Ref_Shopping { get; set; }
        #endregion

        #region [- SignInSignUpToolStripMenuItem_Click -]
        private void SignInSignUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ref_Form1 = new Form1();
            Ref_Form1.MdiParent = this;
            Ref_Form1.Show();
        }
        #endregion

        #region [- ProductToolStripMenuItem_Click -]
        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ref_Shopping = new shopping();
            Ref_Shopping.MdiParent = this;
            Ref_Shopping.Show();
        } 
        #endregion
    }
}
