using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ODEV2MUSTAFAL─░KAGANKUCUK.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}