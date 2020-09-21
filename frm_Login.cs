using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoIF
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\BDProjetoIF.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void getData()
        {
            con.Open();
            String syntax = "SELECT Valor FROM systemTable where Propriedade = Usuario";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            MessageBox.Show(""+dr[0].ToString());
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            //getData();
            String nomeusuario = "admin", senhausuario = "admin", nome, senha;
            nome = txt_Usuario.Text;
            senha = txt_Senha.Text;

            if(nome.Equals(nomeusuario) && senha.Equals(senhausuario))
            {
                MessageBox.Show("Bem Vindo ao Sistema!!!");
                frm_MenuPrincipal mp = new frm_MenuPrincipal();
                this.Hide();
                mp.Show();
            }
            else
            {
                //Mensagem em caso de login errado
                lbl_Alerta.Show();
            }
        }
    }
}
