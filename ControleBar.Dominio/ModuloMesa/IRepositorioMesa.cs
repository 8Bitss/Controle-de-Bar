using ControleDeBar.Dominio.ModuloProduto;

namespace ControleDeBar.Dominio.ModuloMesa
{
    public interface IRepositorioMesa 
    {
        void Cadastrar(Mesa registro);
        bool Editar(Mesa registroOriginal, Mesa registroAtualizado);
        bool Excluir(Mesa registro);
        Mesa SelecionarPorId(int idSelecionado);
        List<Mesa> SelecionarTodos();
    }
}
