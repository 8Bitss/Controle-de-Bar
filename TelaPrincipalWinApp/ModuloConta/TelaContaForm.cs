using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloProduto;
using TelaPrincipalWinApp;

namespace ControleDeBar.WinApp.ModuloConta
{
    public partial class TelaContaForm : Form
    {
        private Conta conta;

        public Conta Conta
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Titular;

                cmbGarcom.SelectedItem = value.Garcom;
                cmbMesa.SelectedItem = value.Mesa;

                txtNome.Enabled = false;
                cmbGarcom.Enabled = false;
                cmbMesa.Enabled = false;
                lblValorTotal.Text = $"R$ {value.ValorTotal.ToString()}";

                foreach (Pedido p in value.Pedidos)
                {
                    listProdutos.Items.Add(p);
                }
            }

            get
            {
                return conta;
            }
        }

        public TelaContaForm(List<Mesa> mesas, List<Garcom> garcons, List<Produto> produtos)
        {
            InitializeComponent();

            CarregarMesas(mesas);

            CarregarGarcons(garcons);

            CarregarProdutos(produtos);
        }

        public void CarregarGarcons(List<Garcom> garcons)
        {
            cmbGarcom.Items.Clear();

            foreach (Garcom g in garcons)
                cmbGarcom.Items.Add(g);
        }

        public void CarregarMesas(List<Mesa> mesas)
        {
            cmbMesa.Items.Clear();

            foreach (Mesa m in mesas)
                cmbMesa.Items.Add(m);
        }

        public void CarregarProdutos(List<Produto> produtos)
        {
            txtProduto.Items.Clear();

            foreach (Produto p in produtos)
                txtProduto.Items.Add(p);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (conta == null) 
                conta = ObterConta();

            //string nomeCliente = txtNome.Text;
            //Mesa mesa = cmbMesa.SelectedItem as Mesa;
            //Garcom garcom = cmbGarcom.SelectedItem as Garcom;

            //conta = new Conta(nomeCliente, garcom);

            List<string> erros = conta.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void btnAdicionarPedido_Click(object sender, EventArgs e)
        {
            if(!ContaEstaCriada())
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape("Preencha os campos anteriores antes de criar um pedido!");

                return;
            }

            if (conta == null) 
                conta = ObterConta();

            Produto produto = txtProduto.SelectedItem as Produto;

            if (produto == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um produto selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int quantidade = Convert.ToInt32(txtQuantidade.Value);

            Pedido novoPedido = new Pedido(produto, quantidade);

            conta.AdicionarPedido(novoPedido);

            listProdutos.Items.Add(novoPedido);
            
            AtualizarLabelValorTotal();
        }

        private void AtualizarLabelValorTotal()
        {
            lblValorTotal.Text =
                $"R$ {conta.ValorTotal.ToString()}";
        }

        private void removerProdutoItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conta == null)
                conta = ObterConta();

            Pedido pedidoSelecionado = listProdutos.SelectedItem as Pedido;

            if (pedidoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (listProdutos.Items.Count <= 1)
            {
                MessageBox.Show(
                    "Não foi possível realizar esta ação, a conta precisa ter ao mínimo 1 pedido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            conta.RemoverPedido(pedidoSelecionado);
            listProdutos.Items.Remove(pedidoSelecionado);

            AtualizarLabelValorTotal();
        }

        private bool ContaEstaCriada()
        {
            bool dadosEstaoPreenchidos =
                !string.IsNullOrEmpty(txtNome.Text) &&
                cmbGarcom.SelectedItem != null;

            return dadosEstaoPreenchidos || conta != null;
        }

        private Conta ObterConta()
        {
            string titular = txtNome.Text;
            Garcom garcom = (Garcom)cmbGarcom.SelectedItem;
            Mesa mesa = (Mesa)cmbMesa.SelectedItem;

            return new Conta(titular, mesa, garcom);
        }
    }
}
