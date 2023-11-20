using GutenBerg.MrGut.Debugging;

namespace GutenBerg.MrGut
{
    public class MrGutConsts
    {
        public const string LocalizationSourceName = "MrGut";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ef23855a38434e3ea6c741ce8a35c857";
    }
}
