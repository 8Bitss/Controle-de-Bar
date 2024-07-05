using ControleBar.Dominio.ModuloConta;
using ControleBar.Dominio.ModuloPedido;

namespace ControleBar.Dominio.ModuloMesa
{
    public class Mesa
    {
        public int Numero { get; set; }

        public Pedido Pedido { get; set; }

        public Conta Conta { get; set; }

        public bool Status { get; set; }
    }
}