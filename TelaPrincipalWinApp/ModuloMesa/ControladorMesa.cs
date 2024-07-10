using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloProduto;
using ControleDeBar.WinApp.Compartilhado;
using TelaPrincipalWinApp;

namespace ControleDeBar.WinApp.ModuloMesa
{
    public class ControladorMesa : ControladorBase
    {
        private IRepositorioMesa repositorioMesa;
        private TabelaMesaControl tabelaMesa;

        public ControladorMesa(IRepositorioMesa repositorio)
        {
            repositorioMesa = repositorio;
        }

        public override string TipoCadastro { get { return "Mesa"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova mesa"; } }

        public override string ToolTipEditar { get { return "Editar uma mesa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma mesa existente"; } }

        public override void Adicionar()
        {
            TelaMesaForm telaMesa = new TelaMesaForm();

            DialogResult resultado = telaMesa.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Mesa novoMesa = telaMesa.Mesa;

            repositorioMesa.Cadastrar(novoMesa);

            CarregarMesas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"A mesa de nº \"{novoMesa.Numero}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaMesaForm telaMesa = new TelaMesaForm();

            int idSelecionado = tabelaMesa.ObterRegistroSelecionado();

            Mesa mesaSelecionado =
                repositorioMesa.SelecionarPorId(idSelecionado);

            if (mesaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaMesa.Mesa = mesaSelecionado;

            DialogResult resultado = telaMesa.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Mesa mesaEditada = telaMesa.Mesa;

            repositorioMesa.Editar(mesaSelecionado.Id, mesaEditada);

            CarregarMesas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"A mes de nº \"{mesaEditada.Numero}\" foi editada com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMesa.ObterRegistroSelecionado();

            Mesa mesaSelecionada =
                repositorioMesa.SelecionarPorId(idSelecionado);

            if (mesaSelecionada == null)
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
                $"Você deseja realmente excluir a mesa de nº \"{mesaSelecionada.Numero}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioMesa.Excluir(mesaSelecionada.Id);

            CarregarMesas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"A mesa de nº \"{mesaSelecionada.Numero}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMesa == null)
                tabelaMesa = new TabelaMesaControl();

            CarregarMesas();

            return tabelaMesa;
        }

        private void CarregarMesas()
        {
            List<Mesa> mesas = repositorioMesa.SelecionarTodos();

            tabelaMesa.AtualizarRegistros(mesas);
        }
    }
}
