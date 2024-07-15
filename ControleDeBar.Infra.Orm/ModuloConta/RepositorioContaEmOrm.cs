using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace ControledeBar.Infra.Orm.ModuloConta
{
    public class RepositorioContaEmOrm : IRepositorioConta
    {
        ControleDeBarDbContext dbContext;

        public RepositorioContaEmOrm(ControleDeBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Conta registro)
        {
            dbContext.Contas.Add(registro);

            dbContext.SaveChanges();
        }

        public bool Editar(Conta registroOriginal, Conta registroAtualizado)
        {
            if (registroOriginal == null || registroAtualizado == null)
                return false;

            registroOriginal.AtualizarRegistro(registroAtualizado);

            dbContext.Contas.Update(registroOriginal);

            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(Conta registro)
        {
            if (registro == null)
                return false;

            dbContext.Contas.Remove(registro);

            dbContext.SaveChanges();

            return true;
        }

        public Conta SelecionarPorId(int idSelecionado)
        {
            return dbContext.Contas.Find(idSelecionado)!;
        }

        public List<Conta> SelecionarTodos()
        {
            return dbContext.Contas.Include(x => x.Mesa).Include(x => x.Garcom).Include(x => x.Pedidos).ToList();
        }
    }
}
