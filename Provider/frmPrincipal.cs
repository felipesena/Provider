using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provider
{
    public partial class frmPrincipal : Form
    {
        string planilhaPreencher;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();

            arquivo.Title = "Arquivo a ser preenchido";
            arquivo.Filter = "Arquivos Excel |*.xlsx;*.xls";

            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                planilhaPreencher = arquivo.FileName;
                txbArquivo.Text = arquivo.FileName;
            }
        }
    }
}
