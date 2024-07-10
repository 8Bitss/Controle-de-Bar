namespace ControleDeBar.Dominio.ModuloConta
{
    public interface IControladorAdicionaisConta
    {
        string ToolTipGerarRelatorios { get; }

        void GerarRelatorios();
    }
}
