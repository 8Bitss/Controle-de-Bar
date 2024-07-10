namespace ControleDeBar.Dominio.ModuloConta
{
    public interface IControladorOpcoesPedido
    {
        string ToolTipAtualizarPedido { get; set; }

        void AtualizarPedido();
    }
}
