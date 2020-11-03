using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinesWeeper.Common.Models;



namespace MinesWeeper.WindowsForms.Views
{
    public partial class ViewMinesWeeper : Form
    {
        //private int gridSize;
        
        public ViewMinesWeeper()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void face_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Size = new Size(397, 391);
            //this.Width = 300;
            //this.Height = 300;
            this.Size = new Size(440, 540);
            this.CenterToScreen();
        }

        private void facilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Program.M_Jogo.Tamanho = 9;
            //gridSize = 9;
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Size = new Size(397, 391);            
            this.Size = new Size(440, 540);
            criar_tabuleiro(Program.M_Jogo.TamanhoPequeno);
            this.CenterToScreen();
            //Game();
            this.Refresh();
        }

        private void medioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Program.M_Jogo.Tamanho = 16;
            //gridSize = 16;
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Size = new Size(715, 715);
            this.Size = new Size(760, 850);
            criar_tabuleiro(Program.M_Jogo.TamanhoMedio);
            this.CenterToScreen();
            this.Refresh();
        }

        private void ViewMinesWeeper_Load(object sender, EventArgs e)
        {
            this.Size = new Size(391, 506);
            this.Refresh();
        }
        private void criar_tabuleiro(int valor)
        {
            int cont = 0;
            Button button = null;//mudar nome
            int  rowCount = valor;
            int columnCount = valor;

            this.tableLayoutPanel1.ColumnCount = columnCount;
            this.tableLayoutPanel1.RowCount = rowCount;

            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {

                    button = new Button(); 
                    button.Height = 35;
                    button.Width = 35;
                    //button.Image = global::MinesWeeper.WindowsForms.Resource1.Webp_net_resizeimage;
                   // button.Text = string.Format("{0}", cont);
                    button.Name = string.Format("button_{0}", cont);
                    //button.Dock = DockStyle.Fill;
                    button.Click += Button_Click;
                    this.tableLayoutPanel1.Controls.Add(button, j, i);
                    cont++;
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string name = btn.Name;
            MessageBox.Show("O " + name + " foi clicado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
