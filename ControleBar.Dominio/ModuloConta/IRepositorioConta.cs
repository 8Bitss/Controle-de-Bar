namespace ControleDeBar.Dominio.ModuloConta
{
    public interface IRepositorioConta
    {
        void Cadastrar(Conta novoConta);
        bool Editar(int id, Conta contaEditado);
        bool Excluir(int id);
        Conta SelecionarPorId(int idSelecionado);
        List<Conta> SelecionarTodos();
    }
}
