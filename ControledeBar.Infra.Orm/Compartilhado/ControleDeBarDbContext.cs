using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloProduto;
using Microsoft.EntityFrameworkCore;

namespace ControleDeBar.Infra.Orm.Compartilhado
{
    public class ControleDeBarDbContext : DbContext
    {
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        
        public DbSet<Garcom> Garcons { get; set; }

        

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

            modelBuilder.Entity<Garcom>(garcomBuiler =>
            {
                garcomBuiler.ToTable("TBGarcom");

                garcomBuiler.Property(g => g.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

                garcomBuiler.Property(g => g.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

                garcomBuiler.Property(g => g.Cpf)
                .IsRequired()
                .HasColumnType("varchar(20)");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
