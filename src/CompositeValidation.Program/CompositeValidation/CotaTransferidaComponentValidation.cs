using CompositeValidation.Abstractions;
using CompositeValidation.Notifications;
using CompositeValidation.Program.Models;

namespace CompositeValidation.Program.CompositeValidation
{
    public class CotaTransferidaComponentValidation : IComponentValidation<Cota>
    {
        public Notification Validate(Cota cota)
        {
            if (cota?.Versao == 0) return new Notification(isValid: true);

            return new Notification(
                key: "Cota:",
                message: "Cota transferida ou excluida",
                isValid: false
              );
        }
    }
}
