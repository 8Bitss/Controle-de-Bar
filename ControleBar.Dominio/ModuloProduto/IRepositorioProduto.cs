namespace ControleDeBar.Dominio.ModuloProduto
{
    public interface IRepositorioProduto
    {
        void Cadastrar(Produto novoProduto);
        bool Editar(int id, Produto produtoEditado);
        bool Excluir(int id);
        Produto SelecionarPorId(int idSelecionado);
        List<Produto> SelecionarTodos();
    }
}
