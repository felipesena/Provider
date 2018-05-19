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
    public partial class frmNotification : Form
    {
        public frmNotification(string mensagem)
        {
            InitializeComponent();
            ShowInTaskbar = false;
            lb_message.Text = mensagem;
            timer_close.Start();
        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
