using ControleDeBar.Dominio.ModuloProduto;
using ControleDeBar.WinApp.Compartilhado;
using TelaPrincipalWinApp;


namespace ControleDeBar.WinApp.ModuloProduto
{
    public class ControladorProduto : ControladorBase
    {
        private IRepositorioProduto repositorioProduto;
        private TabelaProdutoControl tabelaProduto;

        public ControladorProduto(IRepositorioProduto repositorio)
        {
            repositorioProduto = repositorio;
        }

        public override string TipoCadastro { get { return "Produtos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo produto"; } }

        public override string ToolTipEditar { get { return "Editar uma produto existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um produto existente"; } }

        public override void Adicionar()
        {
            TelaProdutoForm telaProduto = new TelaProdutoForm();

            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Produto novoProduto = telaProduto.Produto;

            repositorioProduto.Cadastrar(novoProduto);

            CarregarProdutos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoProduto.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaProdutoForm telaProduto = new TelaProdutoForm();

            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto produtoSelecionado =
                repositorioProduto.SelecionarPorId(idSelecionado);

            if (produtoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaProduto.Produto = produtoSelecionado;

            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Produto produtoEditado = telaProduto.Produto;

            repositorioProduto.Editar(produtoSelecionado, produtoEditado);

            CarregarProdutos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{produtoEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto produtoSelecionado =
                repositorioProduto.SelecionarPorId(idSelecionado);

            if (produtoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{produtoSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioProduto.Excluir(produtoSelecionado);

            CarregarProdutos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{produtoSelecionado.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaProduto == null)
                tabelaProduto = new TabelaProdutoControl();

            CarregarProdutos();

            return tabelaProduto;
        }

        private void CarregarProdutos()
        {
            List<Produto> produtos = repositorioProduto.SelecionarTodos();

            tabelaProduto.AtualizarRegistros(produtos);
        }
    }
}
