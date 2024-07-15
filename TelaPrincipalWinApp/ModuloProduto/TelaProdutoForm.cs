using ControleDeBar.Dominio.ModuloProduto;
using TelaPrincipalWinApp;

namespace ControleDeBar.WinApp.ModuloProduto
{
    public partial class TelaProdutoForm : Form
    {
        private Produto produto;

        public Produto Produto
        {
            set
            {
                txtIdProduto.Text = value.Id.ToString();
                txtNomeProduto.Text = value.Nome;
                txtPrecoProduto.Value = value.Preco;
            }
            get
            {
                return produto;
            }
        }

        public TelaProdutoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProduto.Text;
            decimal preco = txtPrecoProduto.Value;

            produto = new Produto(nome, preco);

            List<string> erros = produto.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
