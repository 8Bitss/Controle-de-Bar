using ControleDeBar.Dominio.ModuloMesa;
using TelaPrincipalWinApp;

namespace ControleDeBar.WinApp.ModuloMesa
{
    public partial class TelaMesaForm : Form
    {
        private Mesa mesa;

        public Mesa Mesa
        {
            set
            {
                txtIdMesa.Text = value.Id.ToString();
                txtNumeroMesa.Value = value.Numero;
                mesaOcupada.Checked = false;
            }
            get
            {
                return mesa;
            }
        }

        public TelaMesaForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumeroMesa.Value);
            bool tmesaOcupada = mesaOcupada.Checked;

            mesa = new Mesa(numero, tmesaOcupada);

            List<string> erros = mesa.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
