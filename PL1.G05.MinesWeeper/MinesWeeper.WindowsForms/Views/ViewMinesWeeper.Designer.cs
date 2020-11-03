namespace MinesWeeper.WindowsForms.Views
{
    partial class ViewMinesWeeper
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.face = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modoDeJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_tempo = new System.Windows.Forms.TextBox();
            this.textBox_pontos = new System.Windows.Forms.TextBox();
            this.textBox_minas = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 391);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // face
            // 
            this.face.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.face.Image = global::MinesWeeper.WindowsForms.Resource1.face;
            this.face.Location = new System.Drawing.Point(182, 23);
            this.face.Name = "face";
            this.face.Size = new System.Drawing.Size(55, 55);
            this.face.TabIndex = 0;
            this.face.UseVisualStyleBackColor = true;
            this.face.Click += new System.EventHandler(this.face_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoDeJogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modoDeJogoToolStripMenuItem
            // 
            this.modoDeJogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilToolStripMenuItem,
            this.medioToolStripMenuItem});
            this.modoDeJogoToolStripMenuItem.Name = "modoDeJogoToolStripMenuItem";
            this.modoDeJogoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.modoDeJogoToolStripMenuItem.Text = "Modo de Jogo";
            // 
            // facilToolStripMenuItem
            // 
            this.facilToolStripMenuItem.Name = "facilToolStripMenuItem";
            this.facilToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.facilToolStripMenuItem.Text = "Facil";
            this.facilToolStripMenuItem.Click += new System.EventHandler(this.facilToolStripMenuItem_Click);
            // 
            // medioToolStripMenuItem
            // 
            this.medioToolStripMenuItem.Name = "medioToolStripMenuItem";
            this.medioToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.medioToolStripMenuItem.Text = "Medio";
            this.medioToolStripMenuItem.Click += new System.EventHandler(this.medioToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pontos:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero minas:";
            // 
            // textBox_tempo
            // 
            this.textBox_tempo.Enabled = false;
            this.textBox_tempo.Location = new System.Drawing.Point(61, 31);
            this.textBox_tempo.Name = "textBox_tempo";
            this.textBox_tempo.Size = new System.Drawing.Size(68, 20);
            this.textBox_tempo.TabIndex = 7;
            this.textBox_tempo.Text = "00:00";
            this.textBox_tempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_pontos
            // 
            this.textBox_pontos.Enabled = false;
            this.textBox_pontos.Location = new System.Drawing.Point(61, 53);
            this.textBox_pontos.Name = "textBox_pontos";
            this.textBox_pontos.Size = new System.Drawing.Size(68, 20);
            this.textBox_pontos.TabIndex = 8;
            this.textBox_pontos.Text = "0";
            this.textBox_pontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_minas
            // 
            this.textBox_minas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_minas.Enabled = false;
            this.textBox_minas.Location = new System.Drawing.Point(298, 49);
            this.textBox_minas.Name = "textBox_minas";
            this.textBox_minas.Size = new System.Drawing.Size(68, 20);
            this.textBox_minas.TabIndex = 9;
            this.textBox_minas.Text = "0";
            this.textBox_minas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ViewMinesWeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 501);
            this.Controls.Add(this.textBox_minas);
            this.Controls.Add(this.textBox_pontos);
            this.Controls.Add(this.textBox_tempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.face);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ViewMinesWeeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.ViewMinesWeeper_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button face;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoDeJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medioToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_tempo;
        private System.Windows.Forms.TextBox textBox_pontos;
        private System.Windows.Forms.TextBox textBox_minas;
    }
}