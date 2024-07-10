using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.WinApp.Compartilhado;

namespace ControleDeBar.WinApp.ModuloMesa
{
    public partial class TabelaMesaControl : UserControl
    {
        public TabelaMesaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Mesa> mesas)
        {
            grid.Rows.Clear();

            foreach (Mesa mesa in mesas)
                grid.Rows.Add(mesa.Id, mesa.Numero, mesa.MesaOcupada);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Numero" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Mesa Ocupada", HeaderText = "Mesa Ocupada" }, 
            };
        }
    }
}
