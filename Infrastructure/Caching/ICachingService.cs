using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisToDoList.API.Infrastructure.Caching
{
    public interface ICachingService
    {
        Task SetAsync(string key, string value);
        Task<string> GetAsync(string key);
    }
}