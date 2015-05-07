using System;

namespace HomeBudget.Contracts
{
    public interface IBaseGridItemViewModel
    {
        int Id { get; set; }
    }

    public class BaseViewModel : IBaseGridItemViewModel
    {
        public int Id { get; set; }
    }
}