using ControleDeBar.Dominio.ModuloGarcom;

namespace ControleDeBar.Dominio.ModuloConta
{
    public interface IRepositorioConta
    {
        void Cadastrar(Conta registro);
        bool Editar(Conta registroOriginal, Conta registroAtualizado);
        bool Excluir(Conta registro);
        Conta SelecionarPorId(int idSelecionado);
        List<Conta> SelecionarTodos();
    }
}
