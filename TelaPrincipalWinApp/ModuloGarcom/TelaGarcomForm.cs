using ControleDeBar.Dominio.ModuloGarcom;
using TelaPrincipalWinApp;

namespace ControleDeBar.WinApp.ModuloGarcom
{
    public partial class TelaGarcomForm : Form
    {
        private Garcom garcom;

        public Garcom Garcom
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtCpf.Text = value.Cpf;
            }
            get
            {
                return garcom;
            }
        }

        public TelaGarcomForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;

            garcom = new Garcom(nome, cpf);

            List<string> erros = garcom.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
