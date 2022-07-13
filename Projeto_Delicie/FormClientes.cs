using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Projeto_Delicie
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            int quantidade;
            double chocolate; // todos os bolos custam $3,50
            double fuba;
            double banana;
            double cenoura;
            double frango;
            double atum;
            double duplo;
            double tortaFrango; // valor torta de Frango
            double paodeQueijo; // valor pão de queijo         
            double valorTotal;
            int cafe;
            int suco;


            // bolos
            if (cb_BoloChocolate.Checked == true)
            {
                quantidade = int.Parse(tb_QtdChoco.Text);
                chocolate = 3.50 * quantidade;
            }
            else
            {
                chocolate = 0;
            }

            if (cb_BoloFuba.Checked == true)
            {
                quantidade = int.Parse(tb_QtdFuba.Text);
                fuba = 3.50 * quantidade;
            }
            else
            {
                fuba = 0;
            }

            if (cb_BoloCenoura.Checked == true)
            {
                quantidade = int.Parse(tb_QtdCenoura.Text);
                cenoura = 3.50 * quantidade;
            }
            else
            {
                cenoura = 0;
            }
            if (cb_BoloBanana.Checked == true)
            {
                quantidade = int.Parse(tb_QtdBanana.Text);
                banana = 3.50 * quantidade;
            }
            else
            {
                banana = 0;
            }

            // salgados

            if (cb_Frango.Checked == true)
            {
                quantidade = int.Parse(tb_QtdLFrango.Text);
                frango = 5.50 * quantidade;
            }
            else
            {
                frango = 0;
            }
            if (cb_Atum.Checked == true)
            {
                quantidade = int.Parse(tb_QtdLAtum.Text);
                atum = 5.50 * quantidade;
            }
            else
            {
                atum = 0;
            }
            if (cb_XDuplo.Checked == true)
            {
                quantidade = int.Parse(tb_QtdDuplo.Text);
                duplo = 5.50 * quantidade;
            }
            else
            {
                duplo = 0;
            }
            if (cb_PaodeQueijo.Checked == true)
            {
                quantidade = int.Parse(tb_QtdPaodeQueijo.Text);
                paodeQueijo = 3.50 * quantidade;
            }
            else
            {
                paodeQueijo = 0;
            }
            if (cb_TortaFrango.Checked == true)
            {
                quantidade = int.Parse(tb_QtdTorta.Text);
                tortaFrango = 5.00 * quantidade;
            }
            else
            {
                tortaFrango = 0;
            }

            // opcional
            if (cb_Cafe.Checked == true)
            {
                cafe = 0;
            }
            if (cb_Suco.Checked == true)
            {
                suco = 0;
            }

            if(Rb_debito.Checked == true)
            { 
            valorTotal = chocolate + fuba + cenoura + banana + frango + tortaFrango + duplo + paodeQueijo + atum;
            tb_ValorTotal.Text = valorTotal.ToString("C2");
            }

            else if(Rb_credito.Checked == true)
            {
                valorTotal = (chocolate + fuba + cenoura + banana + frango + tortaFrango + duplo + paodeQueijo + atum) + 2.50;
                tb_ValorTotal.Text = valorTotal.ToString("C2");
            }

            else
            {
                MessageBox.Show("Por favor, selecione um método de pagamento");
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {

            
            if (DialogResult.Yes == MessageBox.Show("Deseja confirmar o pedido?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                try
                {

                     StreamWriter nota = new StreamWriter("nota_" + tb_Nome.Text + ".txt");                  

                    nota.WriteLine("══════════════════════════════════════════");
                    nota.WriteLine("═════════════     Recibo   ═══════════════");
                    nota.WriteLine("  Data: " + DateTime.Now + "\n");
                    nota.WriteLine("  Cliente: " + tb_Nome.Text);
                    nota.WriteLine("══════════════════════════════════════════");
                    nota.WriteLine("══════════════════════════════════════════");
                    nota.WriteLine("     Itens:                               ");
                    nota.WriteLine();

                    if (cb_Atum.Checked && tb_QtdLAtum.Text != "") // lanche atum
                    {
                        nota.WriteLine(cb_Atum.Text);
                        nota.WriteLine("Valor Unitário: R$5,50 " + " Quantidade: " + tb_QtdLAtum.Text);
                    }

                    
                    if (cb_Frango.Checked == true && tb_QtdLFrango.Text != "") // lanche frango
                    {
                        nota.WriteLine(cb_Frango.Text);
                        nota.WriteLine("Valor Unitário: R$5,50 " + " Quantidade: " + tb_QtdLFrango.Text);
                    }

                    
                    if (cb_TortaFrango.Checked == true && tb_QtdTorta.Text != "") // torta de frango
                    {
                        nota.WriteLine(cb_TortaFrango.Text);
                        nota.WriteLine("Valor Unitário: R$5,00 " + " Quantidade: " + tb_QtdTorta.Text);
                    }

                    
                    if (cb_XDuplo.Checked == true && tb_QtdDuplo.Text != "") // X-Duplo
                    {
                        nota.WriteLine(cb_XDuplo.Text);
                        nota.WriteLine("Valor Unitário: R$5,50 " + " Quantidade: " + tb_QtdDuplo.Text);
                    }

                    
                    if (cb_PaodeQueijo.Checked == true && tb_QtdPaodeQueijo.Text != "") // Pão de Queijo
                    {
                        nota.WriteLine(cb_PaodeQueijo.Text);
                        nota.WriteLine("Valor Unitário: R$3,50 " + " Quantidade: " + tb_QtdPaodeQueijo.Text);
                    }

                    nota.WriteLine();

                    nota.WriteLine("══════════════════════════════════════════");

                    // bolos

                    if (cb_BoloBanana.Checked && tb_QtdBanana.Text != "") // sabor banana
                    {
                        nota.WriteLine(cb_BoloBanana.Text);
                        nota.WriteLine("Valor Unitário: R$3,50 " + " Quantidade: " + tb_QtdBanana.Text);
                    }

                    
                    if (cb_BoloChocolate.Checked == true && tb_QtdChoco.Text != "") // sabor chocolate
                    {
                        nota.WriteLine(cb_BoloChocolate.Text);
                        nota.WriteLine("Valor Unitário: R$3,50 " + " Quantidade: " + tb_QtdChoco.Text);
                    }

                    
                    if (cb_BoloCenoura.Checked == true && tb_QtdCenoura.Text != "") // sabor cenoura
                    {
                        nota.WriteLine(cb_BoloCenoura.Text);
                        nota.WriteLine("Valor Unitário: R$3,50 " + " Quantidade: " + tb_QtdCenoura.Text);
                    }

                    
                    if (cb_BoloFuba.Checked == true && tb_QtdFuba.Text != "") // sabor fubá
                    {
                        nota.WriteLine(cb_BoloFuba.Text);
                        nota.WriteLine("Valor Unitário: R$3,50 " + " Quantidade: " + tb_QtdFuba.Text);
                    }

                    nota.WriteLine();
                    nota.WriteLine("Valor: " + tb_ValorTotal.Text);
                    nota.WriteLine("══════════════════════════════════════════\n");
                    nota.Close();
                   
                    //Confirmando pedido
                    MessageBox.Show("Pedido confirmado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo está errado, verifique a porra do seu programa!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                }
            }
        }


        private void cb_Frango_CheckedChanged(object sender, EventArgs e)
        {
            tb_QtdLFrango.ReadOnly = false;
        }

        private void cb_Atum_CheckedChanged(object sender, EventArgs e)
        {
            tb_QtdLAtum.ReadOnly = false;
        }

        private void cb_XDuplo_CheckedChanged(object sender, EventArgs e)
        {
            tb_QtdDuplo.ReadOnly = false;
        }

        private void cb_PaodeQueijo_CheckedChanged(object sender, EventArgs e)
        {
            tb_QtdPaodeQueijo.ReadOnly = false;
        }

        private void cb_TortaFrango_CheckedChanged(object sender, EventArgs e)
        {
            tb_QtdTorta.ReadOnly = false;
        }   

        private void cb_BoloChocolate_CheckedChanged(object sender, EventArgs e)
        {
            tb_QtdChoco.ReadOnly = false;
        }

        private void cb_BoloFuba_CheckedChanged(object sender, EventArgs e)
        {
            tb_QtdFuba.ReadOnly = false;
        }

        private void cb_BoloBanana_CheckedChanged(object sender, EventArgs e)
        {
            tb_QtdBanana.ReadOnly = false;
        }

        private void cb_BoloCenoura_CheckedChanged(object sender, EventArgs e)
        {
            tb_QtdCenoura.ReadOnly = false;
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            StreamReader leitura = new StreamReader("nota_" + tb_Nome.Text + ".txt"); // CAMINHO DO ARQUIVO SALVO PARA LER
            richTextBox1.Text = leitura.ReadToEnd();
            leitura.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}






