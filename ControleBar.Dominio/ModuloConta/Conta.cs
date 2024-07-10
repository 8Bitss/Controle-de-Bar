using ControleDeBar.Dominio.Compartilhado;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;

namespace ControleDeBar.Dominio.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public string Titular { get; set; }
        public Mesa Mesa { get; set; }
        public Garcom Garcom { get; set; }
        public bool EstaAberta { get; set; }
        public DateTime Abertura { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public decimal ValorTotal { get; set; }

        public Conta(string nomeCliente, Garcom garcom)
        {
            Titular = nomeCliente;
            Garcom = garcom;
            EstaAberta = true;
            Abertura = DateTime.Now;

            Pedidos = new List<Pedido>();
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Conta atualizada = (Conta)novoRegistro;

            Titular = atualizada.Titular; 
            EstaAberta = atualizada.EstaAberta;
            ValorTotal = atualizada.ValorTotal;
            Garcom = atualizada.Garcom;
            Mesa = atualizada.Mesa;
            Pedidos = atualizada.Pedidos;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titular.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if(Garcom == null)
                erros.Add("O campo \"Garçom\" é obrigatório");

            return erros;
        }

        public void AdicionarPedido(Pedido pedidoSelecionado)
        {
            Pedidos.Add(pedidoSelecionado);
            ValorTotal += pedidoSelecionado.Produto.Preco * pedidoSelecionado.QtdProduto;
        }

        public void RemoverPedido(Pedido pedidoSelecionado)
        {
            Pedidos.Remove(pedidoSelecionado);
            ValorTotal = ValorTotal - pedidoSelecionado.Produto.Preco * pedidoSelecionado.QtdProduto;
        }
    }
}