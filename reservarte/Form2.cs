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
    public partial class frmBibliotecaBibli : Form
    {
        public frmBibliotecaBibli()
        {
            InitializeComponent();
        }

        private void frmBibliotecaBibli_Load(object sender, EventArgs e)
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection("server=localhost;database=biblioteca;uid=root;pwd=usbw;");
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CU!!!");
            }
            criarFilmes(9);
        }

        private void criarFilmes (int nFilmes)
        {
            for(int i = 1; i <= nFilmes; i++)
            {
                Label lblNome = new Label();
                Label lblDesc = new Label();
                PictureBox pictureBox = new PictureBox();

                lblNome.Text = "label" + i;
                lblNome.Name = "" + i;
                lblNome.Size = new System.Drawing.Size(97, 20);

                lblDesc.Text = "label" + i;
                lblDesc.Name = "" + i;
                lblDesc.Size = new System.Drawing.Size(97, 65);

                Font Fontepequena = new Font("Arial", 7);
                Image img = Properties.Resources.GOAT;

                lblDesc.Font = Fontepequena;
                lblNome.Font = Fontepequena;
                pictureBox.Image = img;

                pictureBox.Size = new Size(77, 92);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                switch (i)
                {
                    case 1:
                        lblNome.Location = new System.Drawing.Point(88, 30);
                        lblDesc.Location = new System.Drawing.Point(88, 57);
                        pictureBox.Location = new Point(7, 30);
                        break;
                    case 2:
                        lblNome.Location = new System.Drawing.Point(88, 135);
                        lblDesc.Location = new System.Drawing.Point(88, 161);
                        pictureBox.Location = new Point(10, 208);
                        break;
                    case 3:
                        lblNome.Location = new System.Drawing.Point(88, 243);
                        lblDesc.Location = new System.Drawing.Point(88, 270);
                        pictureBox.Location = new Point(10, 374);
                        break;
                    case 4:
                        lblNome.Location = new System.Drawing.Point(283, 30);
                        lblDesc.Location = new System.Drawing.Point(283, 57);
                        pictureBox.Location = new Point(306, 46);
                        break;
                    case 5:
                        lblNome.Location = new System.Drawing.Point(283, 135);
                        lblDesc.Location = new System.Drawing.Point(283, 161);
                        pictureBox.Location = new Point(303, 208);
                        break;
                    case 6:
                        lblNome.Location = new System.Drawing.Point(283, 243);
                        lblDesc.Location = new System.Drawing.Point(283, 270);
                        pictureBox.Location = new Point(303, 374);
                        break;
                    case 7:
                        lblNome.Location = new System.Drawing.Point(479, 30);
                        lblDesc.Location = new System.Drawing.Point(479, 57);
                        pictureBox.Location = new Point(598, 46);
                        break;
                    case 8:
                        lblNome.Location = new System.Drawing.Point(479, 135);
                        lblDesc.Location = new System.Drawing.Point(479, 161);
                        pictureBox.Location = new Point(598, 208);
                        break;
                    case 9:
                        lblNome.Location = new System.Drawing.Point(479, 243);
                        lblDesc.Location = new System.Drawing.Point(479, 270);
                        pictureBox.Location = new Point(598, 374);
                        break;

                }
                this.Controls.Add(lblNome);
                this.Controls.Add(lblDesc);
                this.Controls.Add(pictureBox);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
