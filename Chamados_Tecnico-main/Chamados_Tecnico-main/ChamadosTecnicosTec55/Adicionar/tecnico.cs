using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Adicionar
{
    public partial class tecnico : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public tecnico()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvartec_Click(object sender, EventArgs e)
        {


            
            // Chama o objeto Cliente
            Tecnico Tecnico = new Tecnico();
            TecnicoDAO tecnicoDAO = new TecnicoDAO(_conexao);

            if (string.IsNullOrWhiteSpace(txb_emailtec.Text) || string.IsNullOrWhiteSpace(txb_obstec.Text) || string.IsNullOrWhiteSpace(txb_senhatec.Text) || string.IsNullOrWhiteSpace(txb_nometec.Text) || string.IsNullOrWhiteSpace(txb_especialidadetec.Text))
            {
                MessageBox.Show("CADE OS DADOSSS ??");
            }
            else
            {

                //TODA VEZ FAZER CONEXÃO COM O BANCO DE DADOS USAR TRY
                try
                {
                    //preenche o objeto cliente
                    Tecnico.Nome = txb_nometec.Text;
                    Tecnico.Especialidade = txb_especialidadetec.Text;
                    Tecnico.Email = txb_emailtec.Text;
                    Tecnico.Senha = txb_senhatec.Text;
                    Tecnico.Obs = txb_obstec.Text;
                    //CHAMA O DAO PARA INCLUIR O CLIENTE

                    tecnicoDAO.IncluiTecnico(Tecnico);

                }

                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao cadastrar" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {


                    MessageBox.Show("Cadastro Realizado");
                }






            }
        }

        private void btnlimpartec_Click(object sender, EventArgs e)
        {
            txb_emailtec.Clear();
            txb_especialidadetec.Clear();
            txb_nometec.Clear();
            txb_obstec.Clear();
            txb_senhatec.Clear();
           

        }
    }
}
