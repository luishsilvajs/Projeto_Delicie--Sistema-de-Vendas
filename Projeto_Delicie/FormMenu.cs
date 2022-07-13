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

namespace Projeto_Delicie
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            FormCardapio frm = new FormCardapio();
            frm.Show();
            this.Visible = true;
        }

        private void brnEntrar_Click(object sender, EventArgs e)
        {
            if(rbClientes.Checked == true)
            {
                FormClientes frm = new FormClientes();
                frm.Show();
            }
            
            if(rbFuncionario.Checked == true)
            {
                FormLogin frm = new FormLogin();
                frm.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      }
}
