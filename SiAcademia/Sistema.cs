using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Data;
namespace SiAcademia
{
    public partial class Sistema : Form
    {
        int idAlterar; // variavel global
        public Sistema()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblmsgerro_Click(object sender, EventArgs e)
        {

        }
        void ListaPlanos()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.ListaPlanos();
            cbPlanos.DataSource = tabelaDados;
            cbPlanos.DisplayMember = "tipoPlano";
            cbPlanos.ValueMember = "codPLANOS";
            //preenchendo cbAlteraPlano
            cbAlteraPlanos.DataSource = tabelaDados;
            cbAlteraPlanos.DisplayMember = "tipoPlano";
            cbAlteraPlanos.ValueMember = "codPLANOS";
            lblmsgerro.Text = con.mensagem;
            cbPlanos.Text = "";

        }

        void ListaClientes()
        {
            ConectaBanco con = new ConectaBanco();
            dgClientes.DataSource = con.listaClientes();
            lblmsgerro.Text = con.mensagem;
        }

        void limpaCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtNascimento.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            cbPlanos.Text = "";
            txtNome.Focus();
        }
        private void Sistema_Load_1(object sender, EventArgs e)
        {
            ListaPlanos();
            ListaClientes();
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.Nome = txtNome.Text;
            c.Cpf = txtCpf.Text;
            c.Telefone= txtTelefone.Text;
            c.Email= txtEmail.Text;
            c.Cidade= txtCidade.Text;
            c.Endereco= txtEndereco.Text;
            c.DataNascimento= txtNascimento.Text;
            c.Plano = Convert.ToInt32(cbPlanos.SelectedValue.ToString());
            // enviar para o banco
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereClientes(c);
            if (retorno == true)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            else
                lblmsgerro.Text = conecta.mensagem;

            ListaClientes();
            limpaCampos();
        }

        private void txtNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPlanos_Click(object sender, EventArgs e)
        {
            FrmCadastroPlanos frmCadastroPlanosfrm = new FrmCadastroPlanos();
            this.Hide();
            frmCadastroPlanosfrm.ShowDialog();
            this.Close();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgClientes.DataSource as DataTable).DefaultView.RowFilter = String.Format("nome like '{0}%'", txtBusca.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linha = dgClientes.CurrentRow.Index;//pega a linha selecionada
            idAlterar = Convert.ToInt32(dgClientes.Rows[linha].Cells["codCLIENTES"].Value.ToString());
            txtAlteraNome.Text = dgClientes.Rows[linha].Cells["nome"].Value.ToString();
            txtAlteraCpf.Text = dgClientes.Rows[linha].Cells["cpf"].Value.ToString();
            txtAlteraNascimento.Text = dgClientes.Rows[linha].Cells["dataNascimento"].Value.ToString();
            txtAlteraTelefone.Text = dgClientes.Rows[linha].Cells["telefone"].Value.ToString();
            txtAlteraEmail.Text = dgClientes.Rows[linha].Cells["email"].Value.ToString();
            txtAlteraEndereco.Text = dgClientes.Rows[linha].Cells["endereco"].Value.ToString();
            txtAlteraCidade.Text = dgClientes.Rows[linha].Cells["cidade"].Value.ToString();
            cbAlteraPlanos.Text = dgClientes.Rows[linha].Cells["tipoPlano"].Value.ToString();

            menu.SelectedTab = tabPageAlterar;
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.Nome = txtAlteraNome.Text;
            c.Cpf = txtAlteraCpf.Text;
            c.DataNascimento = txtAlteraNascimento.Text;
            c.Telefone = txtAlteraTelefone.Text;
            c.Email = txtAlteraEmail.Text;
            c.Endereco = txtAlteraEndereco.Text;
            c.Cidade = txtAlteraCidade.Text;
            c.Plano = Convert.ToInt32(cbAlteraPlanos.SelectedValue.ToString());
            // envia os dados para alterar
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.alteraCliente(c, idAlterar);
            if (retorno == true)
                MessageBox.Show("Dados alterados com sucesso");
            else
                lblmsgerro.Text = conecta.mensagem;

            ListaClientes();
        }

        private void btnRemoveCliente_Click(object sender, EventArgs e)
        {
            int linha = dgClientes.CurrentRow.Index;//pega a linha selecionada
            int idRemover = Convert.ToInt32(dgClientes.Rows[linha].Cells["codCLIENTES"].Value.ToString());
            DialogResult resp = MessageBox.Show("Confirma exclusão?", "Remove cliente", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.deletaCliente(idRemover);
                if (retorno == true)
                    MessageBox.Show("Cliente excluido");
                else
                    lblmsgerro.Text = conecta.mensagem;
                ListaClientes();
            }//fim if ok
            else
                MessageBox.Show("Operacao cancelada");
        }
    }
}