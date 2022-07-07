using System.Collections.ObjectModel;

namespace ODEV2MUSTAFALİKAGANKUCUK.Areas.HelpPage.ModelDescriptions
{
    public class ComplexTypeModelDescription : ModelDescription
    {
        public ComplexTypeModelDescription()
        {
            Properties = new Collection<ParameterDescription>();
        }

        public Collection<ParameterDescription> Properties { get; private set; }
    }
}