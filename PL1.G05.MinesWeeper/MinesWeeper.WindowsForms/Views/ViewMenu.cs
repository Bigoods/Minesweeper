using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesWeeper.WindowsForms.Views
{
    public partial class ViewMenu : Form
    {
        public ViewMenu()
        {
            InitializeComponent();
           
        }                                          

        private void pictureBoxInserir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            
            dlg.Filter = "Image Files (*.jpg;*.jpeg,*.png)|*.JPG;*.JPEG;*.PNG";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxInserir.ImageLocation = dlg.FileName;
                pictureBoxInserir.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBoxSetaEsquerda_Click(object sender, EventArgs e)
        {
            panelRightWelcome.BringToFront();
            pictureBoxSetaEsquerda.Visible = false;
        }

        private void linkLabelSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRightSign.BringToFront();
            pictureBoxSetaEsquerda.Visible = true;
        }

        private void labelSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRightLogin.BringToFront();
            pictureBoxSetaEsquerda.Visible = true;     
        }

        private void ViewMenu_Load(object sender, EventArgs e)
        {
            panelRightWelcome.Dock = panelRightSign.Dock = panelRightLogin.Dock = panelRightJogoOff.Dock = DockStyle.Fill;
            panelRightWelcome.Parent = panelRightSign.Parent = panelRightLogin.Parent = panelRightJogoOff.Parent = this;
        }

        private void linkLabelJogoOff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRightJogoOff.BringToFront();
            pictureBoxSetaEsquerda.Visible = true;
        }
    }
}
