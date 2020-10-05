﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltamiraTaskApi.Domain.Repositories
{
    public interface ICacheService
    {
        T Get<T>(string key);
        void Add(string key, object data);
        void Remove(string key);
        void Clear();
        bool Any(string key);
    }
}
