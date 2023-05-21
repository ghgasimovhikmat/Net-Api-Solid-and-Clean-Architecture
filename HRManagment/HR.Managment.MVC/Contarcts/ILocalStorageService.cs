using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagment.MVC.Contarcts
{
    public interface ILocalStorageService
    {
        void ClearStorage(List<string> keys);
        bool Exists(string keys);
        T GetStorageValue<T>(string keys);
        void SetStorageValue<T>(string keys,T value);

    }
}
