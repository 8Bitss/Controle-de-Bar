namespace ControleDeBar.Dominio.ModuloConta
{
    public interface IControladorPedido
    {
        string ToolTipAdicionarPedido { get; }
        string ToolTipConcluirPedido { get; }

        void AdicionarPedido();
        void AtualizarPedido();
        void ConcluirPedido();
    }
}