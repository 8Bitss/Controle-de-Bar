#region Import dos Modulos
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Infra.Memoria.ModuloGarcom;
using ControleDeBar.WinApp.ModuloGarcom;
#endregion

using ControleDeBar.WinApp.Compartilhado;
using ControleDeBar.Dominio.ModuloProduto;
using ControleDeBar.Infra.Memoria.ModuloProduto;
using ControleDeBar.WinApp.ModuloProduto;

namespace TelaPrincipalWinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        #region Repositórios
        IRepositorioGarcom repositorioGarcom;
        IRepositorioProduto repositorioProduto;
        #endregion

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            #region Instancias de Repositorio
            repositorioGarcom = new RepositorioGarcomEmMemoria();
            repositorioProduto = new RepositorioProdutoEmMemoria();
            #endregion
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        #region Botão Adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }
        #endregion

        #region Botão Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }
        #endregion

        #region Botão Excluir
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
        #endregion

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
        }
    }
}
