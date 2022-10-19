using CoreBuisness;
using System;
using System.Collections.Generic;

namespace UseCases
{
    public class GеtTransactionsUseCase : IGеtTransactionsUseCase
    {
        private readonly ITransactionRepository transactionRepository;

        public GеtTransactionsUseCase(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }
        public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endData)
        {
            return transactionRepository.Search(cashierName, startDate, endData);
        }
    }
}