using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassFileRenamer.Objects
{
    public static class GetSaveConfigPathCommand
    {
        public static ICommand<IRegOperationMetadata<string>>
            ForPath(string value)
            => GetCommand
               .For<IRegOperationMetadata<string>>(
                   MessageType.SaveStringToRegistry
               )
               .WithInput(
                   MakeNewRegOperationMetadata.FromScatch<string>()
                                              .ForKeyPath(ConfigurationProvider.ConfigurationKeyName)
                                              .AndValueName(
                                                  ConfigurationProvider.ConfigurationPathValueName
                                              )
                                              .WithValue(value)
               );
    }
}
