using System;
using CompositeValidation.Notifications;

namespace CompositeValidation.Abstractions
{
    public interface IComponentValidation<TValidated>
    {

        Notification Validate(TValidated @validatedClass);
    }
}
