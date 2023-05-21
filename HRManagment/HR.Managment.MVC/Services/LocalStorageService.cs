using Hanssens.Net;
using HRManagment.MVC.Contarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagment.MVC.Services
{
    public class LocalStorageService : ILocalStorageService
    {
        private LocalStorage _storage;
        public LocalStorageService()
        {
            var config = new LocalStorageConfiguration()
            {
                AutoLoad = true,
                AutoSave = true,
                Filename = "HR.LEAVEMGMT"
            };
            _storage = new LocalStorage(config);
        }

        public void ClearStorage(List<string> keys)
        {
            foreach (var key in keys)
            {
                _storage.Remove(key);
            }
        }

        public bool Exists(string keys)
        {
            return _storage.Exists(keys);
        }

        public T GetStorageValue<T>(string keys)
        {
            return _storage.Get<T>(keys);
        }

        public void SetStorageValue<T>(string keys, T value)
        {
            _storage.Store(keys, value);
            _storage.Persist();
        }
    }
}
