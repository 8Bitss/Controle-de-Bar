using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using TelaPrincipalWinApp;

namespace ControleDeBar.WinApp.ModuloConta
{
    public partial class TelaContaForm : Form
    {
        private Conta conta;

        public Conta Conta
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.NomeCliente;
                cmbMesa.SelectedItem = value.Mesa;
                cmbGarcom.SelectedItem = value.Garcom;
            }
            get
            {
                return conta;
            }
        }

        public TelaContaForm()
        {
            InitializeComponent();
        }

        public void CarregarGarcons(List<Garcom> garcons)
        {
            cmbGarcom.Items.Clear();

            foreach (Garcom g in garcons)
                cmbGarcom.Items.Add(g);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNome.Text;
            Mesa mesa = cmbMesa.SelectedItem as Mesa;
            Garcom garcom = cmbGarcom.SelectedItem as Garcom;

            conta = new Conta(nomeCliente, garcom);

            List<string> erros = conta.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
