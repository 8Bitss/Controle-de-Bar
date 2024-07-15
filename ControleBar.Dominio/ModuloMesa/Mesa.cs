using ControleDeBar.Dominio.Compartilhado;

namespace ControleDeBar.Dominio.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public int Numero { get; set; }

        public bool MesaOcupada { get; set; }

        public Mesa(int numero, bool mesaOcupada)
        {
            Numero = numero;
            MesaOcupada = mesaOcupada;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Mesa atualizado = (Mesa)novoRegistro;

            Numero = atualizado.Numero;
            MesaOcupada = atualizado.MesaOcupada;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Numero < 0)
                erros.Add("O campo \"número\" deve ser maior que 0");            
            

            return erros;
        }

        public override string ToString()
        {
            string numeroString = Numero.ToString();

            return numeroString;
        }
    }
}
