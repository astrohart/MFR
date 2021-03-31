using NUnit.Framework;

namespace MFR.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.SaveStringToRegistryCommand" />
    /// class.
    /// </summary>
    [TestFixture]
    public class
        SaveStringToRegistryCommandTests : RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.LoadStringFromRegistryAction.Execute" />
        /// method correctly loads a path from the system Registry.
        /// </summary>
        [Test]
        public void Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry()
        {
            Assert.DoesNotThrow(
                () => GetCommand
                      .For<IRegOperationMetadata<string>>(
                          MessageType.SaveStringToRegistry
                      )
                      .WithInput(
                          MakeNewRegOperationMetadata.FromScatch<string>()
                              .ForKeyPath(KEY_PATH)
                              .AndValueName(VALUE_NAME)
                              .WithValue(CONFIG_FILE_PATH)
                      )
                      .Execute()
            );

            Assert.That(KEY_PATH.HasValueWithName(VALUE_NAME));
            Assert.That(
                CONFIG_FILE_PATH,
                Is.EqualTo(
                    SystemPreparer.GetRegistryString(KEY_PATH, VALUE_NAME)
                )
            );
        }
    }
}