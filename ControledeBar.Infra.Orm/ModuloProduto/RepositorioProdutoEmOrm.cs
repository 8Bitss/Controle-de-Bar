using ControleDeBar.Infra.Orm.Compartilhado;
using ControleDeBar.Dominio.ModuloProduto;
using Microsoft.EntityFrameworkCore;

namespace ControleDeBar.Infra.Orm.ModuloProduto
{
    public class RepositorioProdutoEmOrm : IRepositorioProduto
    {
        ControleDeBarDbContext dbContext;

        public RepositorioProdutoEmOrm(ControleDeBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Produto registro)
        {
            dbContext.Produtos.Add(registro);
            dbContext.SaveChanges();
        }

        public bool Editar(Produto registroOriginal, Produto registroAtualizado)
        {
            if (registroOriginal == null || registroAtualizado == null)
                return false;

            registroOriginal.AtualizarRegistro(registroAtualizado);

            dbContext.Produtos.Update(registroOriginal);

            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(Produto registro)
        {
            if (registro == null)
                return false;

            dbContext.Produtos.Remove(registro);

            dbContext.SaveChanges();

            return true;
        }

        public Produto SelecionarPorId(int idSelecionado)
        {
            return dbContext.Produtos.Find(idSelecionado)!;
        }

        public List<Produto> SelecionarTodos()
        {
            return dbContext.Produtos.ToList();
        }
    }
}
