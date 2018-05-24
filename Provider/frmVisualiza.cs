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
    public partial class frmVisualiza : Form
    {        
        frmPrincipal principal;        

        public frmVisualiza(frmPrincipal principal)
        {
            InitializeComponent();            
            dataGridClientes.DataSource = Cliente.clientes;            
            this.principal = principal;            
        }

        private void frmVisualiza_FormClosing(object sender, FormClosingEventArgs e)
        {
            principal.Show();
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridClientes.DataSource = Cliente.clientes.Where(x => x.Nome.Contains(txbBuscar.Text)).ToList<Cliente>();
        }        
        
        private void NovoCliente(Cliente cliente)
        {
            if (cliente != null)
                Cliente.Novo(cliente);

            dataGridClientes.DataSource = Cliente.clientes;
            dataGridClientes.Refresh();
        }
        
        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            Form frmNovo = new frmNovo(NovoCliente);
            frmNovo.ShowDialog();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)dataGridClientes.CurrentRow.DataBoundItem;
            Form frmNovo = new frmNovo(NovoCliente, cliente);
            frmNovo.ShowDialog();
        }

        private void deletarStripButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)dataGridClientes.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show("Deseja apagar item selecionado?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Cliente.Apaga(cliente);
                dataGridClientes.DataSource = (Cliente.clientes.Count > 0) ? Cliente.clientes : null;
                dataGridClientes.Refresh();
            }
        }
    }
}
