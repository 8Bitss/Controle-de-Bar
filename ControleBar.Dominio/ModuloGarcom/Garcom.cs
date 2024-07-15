using ControleDeBar.Dominio.Compartilhado;
using ControleDeBar.Dominio.Extensions;

namespace ControleDeBar.Dominio.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Garcom()
        {
            
        }

        public Garcom(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Garcom atualizado = (Garcom)novoRegistro;

            Nome = atualizado.Nome;
            Cpf = atualizado.Cpf;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Cpf.Trim()))
                erros.Add("O campo \"cpf\" é obrigatório");
            
            if (Cpf.Length < 11)
                erros.Add("O campo \"cpf\" precisa ter 11 digítos");


            return erros;
        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }
    }
}
