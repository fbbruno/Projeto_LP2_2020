using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIF
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Livros_Click(object sender, EventArgs e)
        {
            frm_Livros liv = new frm_Livros();            
            liv.Show();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            frm_Clientes cli = new frm_Clientes();
            cli.Show();
        }

        private void btn_Transacoes_Click(object sender, EventArgs e)
        {
            frm_Transacoes tra = new frm_Transacoes();
            tra.Show();
        }

        private void btn_Configuracoes_Click(object sender, EventArgs e)
        {
            frm_Configuracoes conf = new frm_Configuracoes();
            conf.Show();
        }

        private void btn_Departamentos_Click(object sender, EventArgs e)
        {
            frm_Departamentos dep = new frm_Departamentos();
            dep.Show();
        }
    }
}
