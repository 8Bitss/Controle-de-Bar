using ControleDeBar.Infra.Orm.Compartilhado;
using ControleDeBar.Dominio.ModuloMesa;

namespace ControleDeBar.Infra.Orm.ModuloMesa
{
    public class RepositorioMesaEmOrm : IRepositorioMesa
    {
        ControleDeBarDbContext dbContext;

        public RepositorioMesaEmOrm(ControleDeBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Mesa registro)
        {
            dbContext.Mesas.Add(registro);

            dbContext.SaveChanges();
        }

        public bool Editar(Mesa registroOriginal, Mesa registroAtualizado)
        {
            if (registroOriginal == null || registroAtualizado == null)
                return false;

            registroOriginal.AtualizarRegistro(registroAtualizado);

            dbContext.Mesas.Update(registroOriginal);
            
            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(Mesa registro)
        {
            if (registro == null) 
                return false;

            dbContext.Mesas.Remove(registro);

            dbContext.SaveChanges();

            return true;
        }

        Mesa IRepositorioMesa.SelecionarPorId(int idSelecionado)
        {
            return dbContext.Mesas.Find(idSelecionado)!;
        }

        List<Mesa> IRepositorioMesa.SelecionarTodos()
        {
            return dbContext.Mesas.ToList();
        }
    }
}
