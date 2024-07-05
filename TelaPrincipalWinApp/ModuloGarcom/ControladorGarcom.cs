using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.WinApp.Compartilhado;
using TelaPrincipalWinApp;

namespace ControleDeBar.WinApp.ModuloGarcom
{
    public class ControladorGarcom : ControladorBase
    {
        private IRepositorioGarcom repositorioGarcom;
        private TabelaGarcomControl tabelaGarcom;

        public ControladorGarcom(IRepositorioGarcom repositorio)
        {
            repositorioGarcom = repositorio;
        }

        public override string TipoCadastro { get { return "Garçons"; } }
        public override string ToolTipAdicionar { get { return "Cadastrar um novo garçom"; } }
        public override string ToolTipEditar { get { return "Editar um garçom existente"; } }
        public override string ToolTipExcluir { get { return "Excluir um garçom existente"; } }

        public override void Adicionar()
        {
            TelaGarcomForm telaGarcom = new TelaGarcomForm();

            DialogResult resultado = telaGarcom.ShowDialog();

            // guardas = bloquear momentos em que a aplicação toma um "caminho triste"
            if (resultado != DialogResult.OK)
                return;

            Garcom novoGarcom = telaGarcom.Garcom;

            repositorioGarcom.Cadastrar(novoGarcom);

            CarregarGarcons();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoGarcom.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaGarcomForm telaGarcom = new TelaGarcomForm();

            int idSelecionado = tabelaGarcom.ObterRegistroSelecionado();

            Garcom garcomSelecionado =
                repositorioGarcom.SelecionarPorId(idSelecionado);

            if (garcomSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaGarcom.Garcom = garcomSelecionado;

            DialogResult resultado = telaGarcom.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Garcom garcomEditado = telaGarcom.Garcom;

            repositorioGarcom.Editar(garcomSelecionado.Id, garcomEditado);

            CarregarGarcons();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{garcomEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaGarcom.ObterRegistroSelecionado();

            Garcom garcomSelecionado =
                repositorioGarcom.SelecionarPorId(idSelecionado);

            if (garcomSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{garcomSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioGarcom.Excluir(garcomSelecionado.Id);

            CarregarGarcons();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{garcomSelecionado.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaGarcom == null)
                tabelaGarcom = new TabelaGarcomControl();

            CarregarGarcons();

            return tabelaGarcom;
        }

        private void CarregarGarcons()
        {
            List<Garcom> garcons = repositorioGarcom.SelecionarTodos();

            tabelaGarcom.AtualizarRegistros(garcons);
        }
    }
}
