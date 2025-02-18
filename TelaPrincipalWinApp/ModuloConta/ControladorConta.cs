﻿using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloProduto;
using ControleDeBar.WinApp.Compartilhado;
using TelaPrincipalWinApp;

namespace ControleDeBar.WinApp.ModuloConta
{
    public class ControladorConta : ControladorBase, IControladorAdicionaisConta
    {
        private IRepositorioConta repositorioConta;
        private IRepositorioGarcom repositorioGarcom;
        private IRepositorioMesa repositorioMesa;
        private IRepositorioProduto repositorioProduto;

        private TabelaContaControl tabelaConta;

        public ControladorConta(IRepositorioConta repositorio, IRepositorioMesa repositorioMesa, IRepositorioGarcom repositorioGarcom, IRepositorioProduto repositorioProduto)
        {
            repositorioConta = repositorio;
            this.repositorioMesa = repositorioMesa;
            this.repositorioGarcom = repositorioGarcom;
            this.repositorioProduto = repositorioProduto;
        }

        public override string TipoCadastro { get { return "Contas"; } }
        public override string ToolTipAdicionar { get { return "Cadastrar uma novo conta"; } }
        public override string ToolTipEditar { get { return "Atualizar um pedido existente"; } }
        public override string ToolTipExcluir { get { return "Excluir uma conta existente"; } }

        public string ToolTipGerarRelatorios { get { return "Gerar relatórios da conta"; } }

        public override void Adicionar()
        {
            List<Mesa> mesasCadastradas = repositorioMesa.SelecionarTodos();
            List<Garcom> garconsCadastrados = repositorioGarcom.SelecionarTodos();
            List<Produto> produtosCadastrados = repositorioProduto.SelecionarTodos();

            TelaContaForm telaConta = new TelaContaForm(mesasCadastradas, garconsCadastrados, produtosCadastrados);

            telaConta.CarregarProdutos(produtosCadastrados);

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
            List<Mesa> mesasCadastradas = repositorioMesa.SelecionarTodos();
            List<Garcom> garconsCadastrados = repositorioGarcom.SelecionarTodos();
            List<Produto> produtosCadastrados = repositorioProduto.SelecionarTodos();

            TelaContaForm telaConta = new TelaContaForm(mesasCadastradas, garconsCadastrados, produtosCadastrados);

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

            repositorioConta.Editar(contaSelecionado, contaEditado);

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

            repositorioConta.Excluir(contaSelecionado);

            CarregarContas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{contaSelecionado.Id}\" foi excluído com sucesso!");
        }

        public void GerarRelatorios()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaConta == null)
                tabelaConta = new TabelaContaControl();

            CarregarContas();

            return tabelaConta;
        }

        private void CarregarContas()
        {
            List<Conta> contas = repositorioConta.SelecionarTodos();

            tabelaConta.AtualizarRegistros(contas);
        }
    }
}
