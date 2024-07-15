using ControleDeBar.Dominio.ModuloMesa;

namespace ControleDeBar.Dominio.ModuloGarcom
{
    public interface IRepositorioGarcom
    {
        void Cadastrar(Garcom registro);
        bool Editar(Garcom registroOriginal, Garcom registroAtualizado);
        bool Excluir(Garcom registro);
        Garcom SelecionarPorId(int idSelecionado);
        List<Garcom> SelecionarTodos();
    }
}
