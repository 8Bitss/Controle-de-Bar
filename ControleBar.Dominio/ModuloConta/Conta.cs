using ControleDeBar.Dominio.ModuloGarcom;

namespace ControleDeBar.Dominio.ModuloConta
{
    public class Conta
    {

        public decimal ValorTotal { get; set; }

        public bool Status { get; set; }

        public string NomeCliente { get; set; }

        public Garcom Garcom { get; set; }
    }
}