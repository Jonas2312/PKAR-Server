

using Newtonsoft.Json;

namespace PKAR.AnamneseFormular.WebApplication.Extensions
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            var serialzedValue = JsonConvert.SerializeObject(value);
            Console.WriteLine(serialzedValue);
            session.SetString(key, serialzedValue);
        }

        public static T? Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            Console.WriteLine(value);
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
