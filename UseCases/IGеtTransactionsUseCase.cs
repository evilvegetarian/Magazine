using CoreBuisness;
using System;
using System.Collections.Generic;

namespace UseCases
{
    public interface IGеtTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endData);
    }
}