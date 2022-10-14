using CoreBuisness;
using System.Collections.Generic;

namespace UseCases
{
    interface IViewCategoryUseCases
    {
        IEnumerable<Category> Execute();
    }
}