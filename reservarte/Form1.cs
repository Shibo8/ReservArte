using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace reservarte
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection("server=localhost;database=biblioteca;uid=root;pwd=usbw;");
            try
            {
                cnn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("CU!!!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmBibliotecaBibli objform2 = new frmBibliotecaBibli();
            objform2.ShowDialog();
        }
    }
}
