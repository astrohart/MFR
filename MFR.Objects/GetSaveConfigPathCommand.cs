namespace MFR.Objects
{
    /// <summary>
    /// Gets a reference to an instance of an object that implements the
    /// <see
    ///     cref="T:MFR.Objects.ICommand" />
    /// interface and provides
    /// access to the operation of saving the path of a configuration file to
    /// the system Registry.
    /// </summary>
    public static class GetSaveConfigPathCommand
    {
        /// <summary>
        /// Provides access to the
        /// <see
        ///     cref="T:MFR.Objects.ICommand" />
        /// -derived object that
        /// allows saving the pathname of a configuration file to the system Registry.
        /// </summary>
        /// <param name="value">
        /// (Required.) Fully-qualified pathname that is to be saved in the
        /// system Registry. This value can, optionally, be surrounded by double
        /// quotation marks, which become mandatory in the case that the path
        /// contains spaces.
        /// </param>
        /// <returns>
        /// </returns>
        public static ICommand<IRegOperationMetadata<string>> ForPath(
            string value)
            => GetCommand
               .For<IRegOperationMetadata<string>>(
                   MessageType.SaveStringToRegistry
               )
               .WithInput(
                   MakeNewRegOperationMetadata.FromScatch<string>()
                                              .ForKeyPath(
                                                  ConfigurationProvider
                                                      .ConfigurationKeyName
                                              )
                                              .AndValueName(
                                                  ConfigurationProvider
                                                      .ConfigurationPathValueName
                                              )
                                              .WithValue(value)
               );
    }
}