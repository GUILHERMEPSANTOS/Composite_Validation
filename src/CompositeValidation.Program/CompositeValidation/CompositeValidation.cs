using CompositeValidation.Abstractions;
using CompositeValidation.Notifications;


namespace CompositeValidation.Program.CompositeValidation
{
    public class CompositeValidation<TValidated> : ICompositeValidation<TValidated>
    {
        public NotificationContext notificationContext;

        public List<IComponentValidation<TValidated>> ComponentValidations { get; set; }

        public CompositeValidation()
        {
            ComponentValidations = new List<IComponentValidation<TValidated>>();
            notificationContext = new NotificationContext();
        }

        public void Add(IComponentValidation<TValidated> componentValidation)
        {
            ComponentValidations.Add(componentValidation);
        }

        public void Remove(IComponentValidation<TValidated> componentValidation)
        {
            ComponentValidations.Remove(componentValidation);
        }

        public Notification Validate(TValidated validatedClass)
        {
            var notifications = ComponentValidations.Select(component => component.Validate(validatedClass));

            notificationContext.AddNotifications(notifications);

            return notificationContext.GetCombinedNotification();
        }
    }
}