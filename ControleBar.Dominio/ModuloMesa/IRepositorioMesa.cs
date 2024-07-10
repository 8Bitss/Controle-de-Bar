using ControleDeBar.Dominio.ModuloProduto;

namespace ControleDeBar.Dominio.ModuloMesa
{
    public interface IRepositorioMesa 
    {
        void Cadastrar(Mesa novoMesa);
        bool Editar(int id, Mesa mesaEditado);
        bool Excluir(int id);
        Mesa SelecionarPorId(int idSelecionado);
        List<Mesa> SelecionarTodos();
    }
}
