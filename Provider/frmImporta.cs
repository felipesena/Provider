using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provider
{
    public partial class frmImporta : Form
    {
        string planilhaImporta;

        public frmImporta()
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
                planilhaImporta = arquivo.FileName;
                txbArquivo.Text = arquivo.FileName;
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = "Status: Importando arquivo...";
                Cursor.Current = Cursors.WaitCursor;

                Cliente.Importar(planilhaImporta);
                Form frmNotificaiton = new frmNotification("Importado com sucesso");
                frmNotificaiton.Show();

                lbStatus.Text = "Status:";
                Cursor.Current = Cursors.Default;
                Cliente.Inicializa();
            }
            catch(FileNotFoundException error)
            {
                MessageBox.Show(this.Text, error.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
