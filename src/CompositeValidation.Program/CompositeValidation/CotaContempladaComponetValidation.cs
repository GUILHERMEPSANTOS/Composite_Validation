using CompositeValidation.Abstractions;
using CompositeValidation.Notifications;
using CompositeValidation.Program.Models;


namespace CompositeValidation.Program.CompositeValidation
{
    public class CotaContempladaComponetValidation : IComponentValidation<Cota>
    {
        public Notification Validate(Cota cota)
        {
            if (cota.DataContemplacao is not null)
            {
                return new Notification(key: "Cota", message: "Cota já foi contemplada", isValid: false);
            }

            return new Notification(isValid: true);
        }
    }
}
