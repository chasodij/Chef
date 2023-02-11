namespace chef
{
    public interface IFilterRow
    {
        string GetStatement { get; }
        void CancelFiltration();
    }
}
