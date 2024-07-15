using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloProduto;
using Microsoft.EntityFrameworkCore;

namespace ControledeBar.Infra.Orm.Compartilhado
{
    public class ControleDeBarDbContext : DbContext
    {
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
               "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ControleDeBarOrm;Integrated Security=True;Trust Server Certificate=True";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Mesa>(mesaBuilder =>
            {
                mesaBuilder.ToTable("TBMesa");

                mesaBuilder.Property(d => d.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                mesaBuilder.Property(d => d.Numero)
                    .IsRequired()
                    .HasColumnType("varchar(200)");
                
                mesaBuilder.Property(d => d.MesaOcupada)
                    .IsRequired()
                    .HasColumnType("bit");
            });
            
            modelBuilder.Entity<Produto>(produtoBuilder =>
            {
                produtoBuilder.ToTable("TBProduto");

                produtoBuilder.Property(d => d.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                produtoBuilder.Property(d => d.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                produtoBuilder.Property(d => d.Preco)
                    .IsRequired()
                    .HasColumnType("decimal");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
