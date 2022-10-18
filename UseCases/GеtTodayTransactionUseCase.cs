using CoreBuisness;
using System;
using System.Collections.Generic;
using System.Web;

namespace UseCases
{
    public class GеtTodayTransactionUseCase : IGetTodayTransactionUseCase
    {
        private readonly ITransactionRepository transactionRepository;

        public GеtTodayTransactionUseCase(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }
        public IEnumerable<Transaction> Execute(string cashierName)
        {
            return transactionRepository.GetByDay(cashierName, DateTime.Now);
        }
    }
}