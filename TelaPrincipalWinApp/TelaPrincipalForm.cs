namespace TelaPrincipalWinApp
{
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditar.ToolTipText = "Editar Produto";
            btnExcluir.ToolTipText = "Excluir Produto";
        }
    }
}
