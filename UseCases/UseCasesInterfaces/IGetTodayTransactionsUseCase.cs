using CoreBuisness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IGetTodayTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
    }
}