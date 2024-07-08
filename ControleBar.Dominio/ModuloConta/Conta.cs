using ControleDeBar.Dominio.Compartilhado;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;

namespace ControleDeBar.Dominio.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public string NomeCliente { get; set; }
        public bool Status { get; set; }
        public decimal ValorTotal { get; set; }

        public Garcom Garcom { get; set; }
        public Mesa Mesa { get; set; }
        public Pedido Pedido { get; set; }

        public Conta(string nomeCliente)
        {
            NomeCliente = nomeCliente;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Conta atualizada = (Conta)novoRegistro;

            NomeCliente = atualizada.NomeCliente; 
            Status = atualizada.Status;
            ValorTotal = atualizada.ValorTotal;
            Garcom = atualizada.Garcom;
            Mesa = atualizada.Mesa;
            Pedido = atualizada.Pedido;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(NomeCliente.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }
    }
}