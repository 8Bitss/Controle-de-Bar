using ControleDeBar.Dominio.Compartilhado;
using ControleDeBar.Dominio.ModuloProduto;

namespace ControleDeBar.Dominio.ModuloConta
{
    public class Pedido : EntidadeBase
    {
        public Produto Produto { get; set; }
        public int QtdProduto { get; set; }

        public Pedido()
        {
            
        }

        public Pedido(Produto produto, int qtdProduto)
        {
            Produto = produto;
            QtdProduto = qtdProduto;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Pedido atualizado = (Pedido)novoRegistro;

            Produto = atualizado.Produto;
            QtdProduto = atualizado.QtdProduto;
        }

        public override List<string> Validar()
        {

            List<string> erros = new List<string>();

            if (Produto == null)
                erros.Add("O campo \"Produto\" é obrigatório");

            return erros;
        }

        public override string ToString()
        {
            return $"{QtdProduto}x {Produto.Nome}";
        }
    }
}
