using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipBoardManager.Services
{
    internal class RegistryDataBuilder
    {
        void BuildRegistryData(string param)
        {
            
        }

        void BuildRegistryKey(string param)
        {
            Registry.CurrentUser.CreateSubKey(param);
        }

        void DeleteRegistryKey(string param)
        {
            Registry.CurrentUser.DeleteValue(param);
        }
    }
}
