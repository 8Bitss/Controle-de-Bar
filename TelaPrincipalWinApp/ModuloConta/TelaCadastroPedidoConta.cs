using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Dominio.ModuloProduto;

namespace ControleDeBar.WinApp.ModuloConta
{
    public partial class TelaCadastroPedidoConta : Form
    {
        private Conta conta;

        public Conta Conta
        {
            set
            {
                conta = value;
            }

            get
            {
                return conta;
            }
        }

        public List<Produto> ProdutosAdicionados
        {
            get
            {
                return checkProdutosPedido.Items.Cast<Produto>().ToList();
            }
        }

        public TelaCadastroPedidoConta(Conta contaSelecionada)
        {
            InitializeComponent();

            Conta = contaSelecionada;

            foreach(Produto produto in checkProdutosPedido.Items)
            {
                ProdutosAdicionados.Add(produto);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
