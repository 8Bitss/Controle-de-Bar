using ControleDeBar.Dominio.Compartilhado;
using ControleDeBar.Dominio.Extensions;

namespace ControleDeBar.Dominio.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Produto atualizado = (Produto)novoRegistro;

            Nome = atualizado.Nome;
            Preco = atualizado.Preco;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (Preco < 0)
                erros.Add("O campo \"Preço\" deve ser maior que 0");

            return erros;
        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }
    }
}
