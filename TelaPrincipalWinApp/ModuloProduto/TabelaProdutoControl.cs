using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloProduto;
using ControleDeBar.WinApp.Compartilhado;

namespace ControleDeBar.WinApp.ModuloProduto
{
    public partial class TabelaProdutoControl : UserControl
    {
        public TabelaProdutoControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Produto> produtos)
        {
            grid.Rows.Clear();

            foreach (Produto produto in produtos)
                grid.Rows.Add(produto.Id, produto.Nome, produto.Preco);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preço" }
            };
        }
    }
}
