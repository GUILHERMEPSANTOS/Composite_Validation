using System;
using System.Transactions;

namespace CompositeValidation.Abstractions
{
    public interface ICompositeValidation<TValidated> : IComponentValidation<TValidated>
    {
        void Add(IComponentValidation<TValidated> componentValidation);
        void Remove(IComponentValidation<TValidated> componentValidation);
    }
}
