namespace HomeBudget.Logic.Converters
{
    public interface IViewModelConverter<V, M>
    {
        V Convert(M model);
        M Convert(V viewModel);
    }
}