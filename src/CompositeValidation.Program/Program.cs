using CompositeValidation.Program.CompositeValidation;
using CompositeValidation.Program.Models;

var cota = new Cota(10, 10, 3, DateTime.UtcNow);
var cotaCompositeValidation = new CompositeValidation<Cota>();
var cotaComponentValidation = new CotaTransferidaComponentValidation();
var cotaContempladaComponentValidation = new CotaContempladaComponetValidation();

cotaCompositeValidation.Add(cotaComponentValidation);
cotaCompositeValidation.Add(cotaContempladaComponentValidation);
var notifications = cotaCompositeValidation.Validate(cota);

Console.WriteLine(notifications);