using ControleDeBar.WinApp.Compartilhado;

namespace ControleDeBar.WinApp.ModuloProduto
{
    public class ControladorProduto : ControladorBase
    {
        public override string TipoCadastro { get { return "Produtos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo produto"; } }

        public override string ToolTipEditar { get { return "Editar um novo produto"; } }

        public override string ToolTipExcluir { get { return "Excluir um produto existente"; } }

        public override void Adicionar()
        {
            TelaProdutoForm telaProduto = new TelaProdutoForm();

            DialogResult dialogResult = telaProduto.ShowDialog();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
