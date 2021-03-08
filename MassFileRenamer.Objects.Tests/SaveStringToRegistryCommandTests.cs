using NUnit.Framework;
using System.IO;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.SaveStringToRegistryCommand" />
    /// class.
    /// </summary>
    [TestFixture]
    public class
        SaveStringToRegistryCommandTests : RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.LoadStringFromRegistryAction.Execute" />
        /// method correctly loads a path from the system Registry.
        /// </summary>
        [Test]
        public void Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry()
            => Assert.DoesNotThrow(
                () => GetCommand
                      .For<IRegOperationMetadata<string>>(
                          MessageType.SaveStringToRegistry
                      )
                      .WithInput(
                          MakeNewRegOperationMetadata.FromScatch<string>()
                              .ForKeyPath(KEY_PATH)
                              .AndValueName(VALUE_NAME)
                              .WithValue(
                                  Path.Combine(
                                      CONFIG_FILE_DIR, CONFIG_FILE_NAME
                                  )
                              )
                      )
                      .Execute()
            );
    }
}