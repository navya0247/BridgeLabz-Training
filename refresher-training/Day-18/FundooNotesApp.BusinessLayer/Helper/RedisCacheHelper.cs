using StackExchange.Redis;

namespace FundooNotesApp.BusinessLayer.Helper
{
    public class RedisCacheHelper
    {
        private readonly IDatabase _cache;

        // redis connection injected here
        public RedisCacheHelper(string connectionString)
        {
            var redis = ConnectionMultiplexer.Connect(connectionString);
            _cache = redis.GetDatabase();
        }

        // stores token with expiry
        public void SetToken(string key, string token, TimeSpan expiry)
        {
            _cache.StringSet(key, token, expiry);
        }

        // retrieves token, null if expired or not found
        public string? GetToken(string key)
        {
            return _cache.StringGet(key);
        }

        // removes token, used on logout
        public void RemoveToken(string key)
        {
            _cache.KeyDelete(key);
        }

        // checks if token exists (for blacklist/session validation)
        public bool Exists(string key)
        {
            return _cache.KeyExists(key);
        }
    }
}