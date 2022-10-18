using CoreBuisness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IGetTodayTransactionUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
    }
}