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
    public partial class frmNovo : Form
    {
        Action<Cliente> alteracao;
        Cliente cliente;

        public frmNovo(Action<Cliente> alteracao, Cliente cliente)
        {
            InitializeComponent();
            this.alteracao = alteracao;
            this.cliente = cliente;
            PreencheCliente(cliente);
        }        

        private void PreencheCliente(Cliente cliente)
        {
            txbNomeCliente.Text = cliente.Nome;
            if (cliente.Prestador == "Assiste")
                rbAssiste.Checked = true;
            else
                rbOcupacional.Checked = true;
            rtbEmails.Text = FormataEmails(cliente.Email);
        }

        public frmNovo(Action<Cliente> insereNovo)
        {
            InitializeComponent();
            this.alteracao = insereNovo;            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeCliente, nomeFornecedor;

            nomeCliente = txbNomeCliente.Text;

            if (rbAssiste.Checked)
                nomeFornecedor = "Assiste";
            else
                nomeFornecedor = "Ocupacional";

            if (this.cliente == null)
            {
                cliente = new Cliente(nomeCliente, nomeFornecedor, FormataEmails());
                alteracao?.Invoke(cliente);
            }
            else
            {
                Cliente.Altera(this.cliente, nomeCliente, nomeFornecedor, FormataEmails());
                alteracao?.Invoke(null);
            }           

            Close();
        }

        private string FormataEmails(List<string> emails)
        {
            string emailsFormatados = "";

            if (emails == null)
                return emailsFormatados;

            foreach(string email in emails)
            {
                emailsFormatados += email + ";";
            }

            return emailsFormatados;
        }

        private List<string> FormataEmails()
        {
            
        }
    }
}
