#region Import dos Modulos
using ControleDeBar.WinApp.Compartilhado;

using ControleDeBar.WinApp.ModuloGarcom;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Infra.Memoria.ModuloGarcom;

using ControleDeBar.WinApp.ModuloConta;
using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Infra.Memoria.ModuloConta;

using ControleDeBar.Dominio.ModuloProduto;
using ControleDeBar.Infra.Memoria.ModuloProduto;
using ControleDeBar.WinApp.ModuloProduto;
#endregion

namespace TelaPrincipalWinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        #region Repositórios
        IRepositorioGarcom repositorioGarcom;
        IRepositorioProduto repositorioProduto;
        IRepositorioConta repositorioConta;
        #endregion

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            #region Instancias de Repositorio
            repositorioGarcom = new RepositorioGarcomEmMemoria();
            repositorioConta = new RepositorioContaEmMemoria();
            repositorioProduto = new RepositorioProdutoEmMemoria();
            #endregion
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        #region Botões CRUD
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
        #endregion

        #region Botões do Menu Strip
        private void produtoMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorProduto(repositorioProduto);

            ConfigurarTelaPrincipal(controlador);
        }

        private void garcomMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorGarcom(repositorioGarcom);

            ConfigurarTelaPrincipal(controlador);
        }

        private void contaMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorConta(repositorioConta, repositorioGarcom, repositorioProduto);

            ConfigurarTelaPrincipal(controlador);
        }
        #endregion

        #region Configurações Gerais
        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagem = controladorSelecionado.ObterListagem();
            listagem.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            ConfigurarToolTips(controladorSelecionado);
        }
        #endregion
    }
}
