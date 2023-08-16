using BotCrypt;

namespace MicroserviceDemo.Core.Utilities.Encryption.BotCrypt
{
    public static class BcHashingHelper
    {
        public static string _securityKey = "mysupersecretkey";

        public static string EncodeString(string key)
        {
            return Crypter.EncryptString(_securityKey, key);
        }

        public static string DecodeString(string key)
        {
            return Crypter.DecryptString(_securityKey, key);
        }
    }
}
