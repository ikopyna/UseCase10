namespace ValidationProject.Configuration
{
    /// <summary>
    /// Class with constants.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Allowed special symbols.
        /// </summary>
        public const string SPECIAL_SYMBOLS = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

        /// <summary>
        /// Infix used in regex pattern to mark the place where an actual number should be.
        /// </summary>
        public const string MAX_LENGTH_INFIX = "{MAX_LENGTH}";

        /// <summary>
        /// Regex template that validates whether string contains at least one uppercase letter, 
        /// one lowercase letter, one digit and one special character. Also, the string should not 
        /// contain any whitespaces and should not exceed the max length.
        /// 
        /// NOTE: <see cref="MAX_LENGTH_INFIX"/> should be replaced with actual number.
        /// </summary>
        public const string REGEX_TEMPLATE = "^(?=.*[a-z]+)(?=.*[A-Z]+)(?=.*\\d+)(?=.*[" + SPECIAL_SYMBOLS + "]+)[^\\s]{1," + MAX_LENGTH_INFIX + "}$";
    }
}
