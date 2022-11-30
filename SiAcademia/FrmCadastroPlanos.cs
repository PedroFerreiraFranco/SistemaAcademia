using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiAcademia
{
    public partial class FrmCadastroPlanos : Form
    {
        public FrmCadastroPlanos()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Sistema sistema = new Sistema();
            this.Hide();
            sistema.ShowDialog();
            this.Close();
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            Planos p = new Planos();
            p.NomePlano = txtNomePlano.Text;
            p.Valor = txtValor.Text;
            p.DataFim = txtDataInicio.Text;
            p.DataInicio = txtDataInicio.Text;
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.inserePlanos(p);
            if (retorno == true)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
            }
        }
    }
 }

