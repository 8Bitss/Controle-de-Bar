using ControleDeBar.Infra.Orm.Compartilhado;
using ControleDeBar.Dominio.ModuloGarcom;
using Microsoft.Win32;
using ControleDeBar.Dominio.ModuloMesa;

namespace ControleDeBar.Infra.Orm.ModuloGarcom
{
    public class RepositorioGarcomEmOrm : IRepositorioGarcom
    {
        ControleDeBarDbContext dbContext;

        public RepositorioGarcomEmOrm(ControleDeBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Garcom registro)
        {
            dbContext.Garcons.Add(registro);

            dbContext.SaveChanges();
        }

        public bool Editar(Garcom registroOriginal, Garcom registroAtualizado)
        {
            if (registroOriginal == null || registroAtualizado == null)
                return false;

            registroOriginal.AtualizarRegistro(registroAtualizado);

            dbContext.Garcons.Update(registroOriginal);

            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(Garcom registro)
        {
            if (registro == null)
                return false;

            dbContext.Garcons.Remove(registro);

            dbContext.SaveChanges();

            return true;
        }

        public Garcom SelecionarPorId(int idSelecionado)
        {
            return dbContext.Garcons.Find(idSelecionado)!;
        }

        public List<Garcom> SelecionarTodos()
        {
            return dbContext.Garcons.ToList();
        }
    }
}
