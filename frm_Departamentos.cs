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
    public partial class frm_Departamentos : Form
    {
        public frm_Departamentos()
        {
            InitializeComponent();
        }

        private void departamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDProjetoIFDataSet);

        }

        private void frm_Departamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDProjetoIFDataSet.Departamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.departamentosTableAdapter.Fill(this.bDProjetoIFDataSet.Departamentos);

        }
    }
}
