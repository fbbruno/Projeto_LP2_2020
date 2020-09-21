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
    public partial class frm_Transacoes : Form
    {
        public frm_Transacoes()
        {
            InitializeComponent();
        }

        private void transacoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transacoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDProjetoIFDataSet);

        }

        private void frm_Transacoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDProjetoIFDataSet.Transacoes'. Você pode movê-la ou removê-la conforme necessário.
            this.transacoesTableAdapter.Fill(this.bDProjetoIFDataSet.Transacoes);

        }
    }
}
