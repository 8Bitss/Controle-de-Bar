namespace ControleDeBar.Dominio.ModuloProduto
{
    public interface IRepositorioProduto
    {
        void Cadastrar(Produto registro);
        bool Editar(Produto registroOriginal, Produto registroAtualizado);
        bool Excluir(Produto registro);
        Produto SelecionarPorId(int idSelecionado);
        List<Produto> SelecionarTodos();
    }
}
