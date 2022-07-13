using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // para trabalhar com o banco

namespace Projeto_Delicie
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Conectar
                string conexao; // conectar com o banco de dados
                conexao = Projeto_Delicie.Properties.Settings.Default.BancoDelicieConnectionString; // Caminho para conectar o banco de dados
                SqlConnection objconexao = new SqlConnection(conexao);
                objconexao.Open();

                // Consultando
                string comando;
                comando = "select count(*) from usuarios where login = '" + tbLogin.Text + "' and senha = '" + tbSenha.Text + "' ";
                SqlCommand objcomando = new SqlCommand(comando, objconexao);
                objcomando.ExecuteScalar(); // retorna a quantidade de registros (usuarios)


                if ((int)objcomando.ExecuteScalar() > 0)
                {
                    tbLogin.Clear();
                    tbSenha.Clear();

                    FormFuncionario frm = new FormFuncionario();
                    frm.Show();
                }


                else
                {
                    MessageBox.Show("Usuário ou senha incorreta, tente novamente.");
                    tbLogin.Focus();

                }

            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }
    }

}
