using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Caching;

namespace SubscribersManagement
{
    class CashingSystem
    {
        ObjectCache cache = MemoryCache.Default;

        public void AddToCache(string name, string duration)
        {
            var cacheItemPolicy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(Double.Parse(duration))
            };
            cache.Add(name, name, cacheItemPolicy);
        }

        public void PrintCache()
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine("All key-values at " + dt.Second);
            //loop through all key-value pairs and print them
            foreach (var item in cache)
            {
                Console.WriteLine("cache object key-value: " + item.Key + "-" + item.Value);
            }
        }
    }
}
