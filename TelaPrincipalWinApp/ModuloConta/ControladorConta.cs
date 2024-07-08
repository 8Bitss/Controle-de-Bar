using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloProduto;
using ControleDeBar.WinApp.Compartilhado;
using TelaPrincipalWinApp;

namespace ControleDeBar.WinApp.ModuloConta
{
    public class ControladorConta : ControladorBase, IControladorPedido
    {
        private IRepositorioConta repositorioConta;
        private IRepositorioGarcom repositorioGarcom;

        private TabelaContaControl tabelaConta;

        public ControladorConta(IRepositorioConta repositorio, IRepositorioGarcom repositorioGarcom)
        {
            repositorioConta = repositorio;
            this.repositorioGarcom = repositorioGarcom;
        }

        public override string TipoCadastro { get { return "Contas"; } }
        public override string ToolTipAdicionar { get { return "Cadastrar uma novo conta"; } }
        public override string ToolTipEditar { get { return "Editar uma conta existente"; } }
        public override string ToolTipExcluir { get { return "Excluir uma conta existente"; } }

        public string ToolTipAdicionarPedido { get { return "Adicionar pedido"; } }
        public string ToolTipConcluirPedido { get { return "Concluir pedido"; } }

        public override void Adicionar()
        {
            TelaContaForm telaConta = new TelaContaForm();

            List<Garcom> garconsCadastrados = repositorioGarcom.SelecionarTodos();

            telaConta.CarregarGarcons(garconsCadastrados);

            DialogResult resultado = telaConta.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Conta novaConta = telaConta.Conta;

            repositorioConta.Cadastrar(novaConta);

            CarregarContas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaConta.Id}\" foi criado com sucesso!");
        }

        public override void Editar()
        {

            TelaContaForm telaConta = new TelaContaForm();

            int idSelecionado = tabelaConta.ObterRegistroSelecionado();

            Conta contaSelecionado =
                repositorioConta.SelecionarPorId(idSelecionado);

            if (contaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaConta.Conta = contaSelecionado;

            DialogResult resultado = telaConta.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Conta contaEditado = telaConta.Conta;

            repositorioConta.Editar(contaSelecionado.Id, contaEditado);

            CarregarContas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{contaEditado.Id}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {

            int idSelecionado = tabelaConta.ObterRegistroSelecionado();

            Conta contaSelecionado =
                repositorioConta.SelecionarPorId(idSelecionado);

            if (contaSelecionado == null)
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
                $"Você deseja realmente excluir o registro \"{contaSelecionado.Id}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioConta.Excluir(contaSelecionado.Id);

            CarregarContas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{contaSelecionado.Id}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaConta == null)
                tabelaConta = new TabelaContaControl();

            CarregarContas();

            return tabelaConta;
        }

        public void AdicionarPedido()
        {
            throw new NotImplementedException();
        }

        public void AtualizarPedido()
        {
            throw new NotImplementedException();
        }

        public void ConcluirPedido()
        {
            throw new NotImplementedException();
        }

        private void CarregarContas()
        {
            List<Conta> contas = repositorioConta.SelecionarTodos();

            tabelaConta.AtualizarRegistros(contas);
        }
    }
}
